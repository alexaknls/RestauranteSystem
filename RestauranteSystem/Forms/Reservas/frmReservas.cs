using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using RestauranteLib;
using RestauranteLib.Controladores;
using RestauranteSystem.Forms.Reservas;

namespace RestauranteSystem.Reservas
{
    public partial class frmReservas : Form
    {
        private ControladorReservas _controladorReservas;
        private List<ReservasLib> _reservasLista;
        private ReservasLib _selectedReserva;
        private string nuevoCodigoReserva;
        private DateTime _reservaDateTime;

        private bool _esEdicion = false;
        private ReservasLib _originalReserva = null;


        public frmReservas()
        {
            InitializeComponent();
            DateTime reservaFecha = dtpReservaFecha.Value;
            DateTime reservaHora = dtpReservaHora.Value;
            DateTime _reservaDatetime = new DateTime(reservaFecha.Year, reservaFecha.Month, reservaFecha.Day, reservaHora.Hour, reservaHora.Minute, reservaHora.Second);

            _controladorReservas = new ControladorReservas();
            _reservasLista = _controladorReservas.ObtenerReservas();
            bnSrcReservas.DataSource = _reservasLista;

            GeneradordeCodigoReservaFromForm();
            LimpiarTextBoxReserva();
        }
        private void frmReservas_Load(object sender, EventArgs e)
        {
            dgvReservasView.DataSource = bnSrcReservas;
            LimpiarTextBoxReserva();

        }
        private void GeneradordeCodigoReservaFromForm()
        {
            nuevoCodigoReserva = _controladorReservas.GeneradordeCodigoReserva();
            txbReservaCodigo.Text = nuevoCodigoReserva;
        }

        private void dgvReservasView_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvReservasView.SelectedRows.Count > 0)
            {
                _selectedReserva = (ReservasLib)dgvReservasView.SelectedRows[0].DataBoundItem;
            }

        }
        private void LimpiarTextBoxReserva()
        {
            _reservaDateTime = DateTime.Now;
            txbCantPersonas.Text = string.Empty;
            txbMesasNum.Text = string.Empty;
            cboReservaEstado.Text = string.Empty;
            dtpReservaCreacion.Value = DateTime.Now;
        }
        private void ActualizarTextBoxReserva()
        {
            if (_selectedReserva != null)
            {
                txbClienteID.Text = _selectedReserva.ReservaCliente;
                txbReservaCodigo.Text = _selectedReserva.ReservaCodigo;
                _reservaDateTime = _selectedReserva.ReservaDateTime;
                txbCantPersonas.Text = _selectedReserva.PersonasCant.ToString();
                txbMesasNum.Text = _selectedReserva.NumeroMesa.ToString();
                cboReservaEstado.Text = _selectedReserva.ReservaEstado;
                dtpReservaCreacion.Value = _selectedReserva.ReservaCreacion;
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string reservaCodigo = txbReservaCodigo.Text;
                string reservaCliente = txbClienteID.Text;
                int personasCant = int.Parse(txbCantPersonas.Text);
                int numeroMesa = int.Parse(txbMesasNum.Text);
                string reservaEstado = cboReservaEstado.SelectedItem.ToString();
                DateTime reservaCreacion = dtpReservaCreacion.Value;

                if (_esEdicion)
                {
                    
                    _selectedReserva.ReservaCodigo = txbReservaCodigo.Text;
                    _selectedReserva.ReservaDateTime = _reservaDateTime;
                    _selectedReserva.PersonasCant = int.Parse(txbCantPersonas.Text);
                    _selectedReserva.NumeroMesa = int.Parse(txbMesasNum.Text);
                    _selectedReserva.ReservaEstado = cboReservaEstado.Text;
                    _selectedReserva.ReservaCreacion = dtpReservaCreacion.Value;
                    _selectedReserva.ReservaCliente = txbClienteID.Text;

                    bool actualizado = _controladorReservas.EditarReserva(_selectedReserva, _originalReserva);
                    if (actualizado)
                    {
                        MessageBox.Show("Reserva actualizada exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar la reserva.");
                    }
                    LimpiarFormulario();
                }
                else
                {
                    Button btnGuardarTexto = new Button();
                    btnGuardarTexto.Text = "Guardar";
                    ReservasLib nuevaReserva = new ReservasLib
                    {
                        ReservaCodigo = reservaCodigo,
                        ReservaDateTime = _reservaDateTime,
                        PersonasCant = personasCant,
                        NumeroMesa = numeroMesa,
                        ReservaEstado = reservaEstado,
                        ReservaCreacion = reservaCreacion,
                        ReservaCliente = reservaCliente

                    };
                    _controladorReservas.AgregarReserva(nuevaReserva);
                }
                _esEdicion = false;
                _originalReserva = null;
                LimpiarTextBoxReserva();
                btnGuardar.Text = "Guardar";
                _reservasLista = _controladorReservas.ObtenerReservas();
                bnSrcReservas.DataSource = _reservasLista;
                bnSrcReservas.ResetBindings(true);
            }
            catch
            {
                MessageBox.Show("Error al guardar la reserva");
            }

        }

        private void LimpiarFormulario()
        {
            GeneradordeCodigoReservaFromForm();
            txbClienteID.Text = "";
            dtpReservaFecha.Value = DateTime.Now;
            dtpReservaHora.Value = DateTime.Now;
            txbCantPersonas.Text = "";
            txbMesasNum.Text = "";
            cboReservaEstado.Text = "ACT";
            dtpReservaCreacion.Value = DateTime.Now;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnMesasView_Click(object sender, EventArgs e)
        {
            MenuMesas frmMenuMesas = new MenuMesas();
            if (frmMenuMesas.ShowDialog() == DialogResult.OK)
            {
                txbMesasNum.Text = frmMenuMesas.NumeroMesasSeleccionada.ToString();
            }
            //frmMenuMesas.ShowDialog(this);
        }

        private void btnBuscadorReserva_Click(object sender, EventArgs e)
        {
            string cedula = txbBuscadorReserva.Text;

            if (string.IsNullOrEmpty(cedula))
            {
                MessageBox.Show("Por favor, introduzca la cédula del cliente.");
                return;
            }

            List<ReservasLib> reservasFiltradas = _controladorReservas.BuscarReservasPorCedula(cedula);

            if (reservasFiltradas.Count == 0)
            {
                MessageBox.Show("No se encontraron reservas para la cédula proporcionada.");
            }

            bnSrcReservas.DataSource = reservasFiltradas;
            bnSrcReservas.ResetBindings(true);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (_selectedReserva != null)
            {
                btnGuardar.Text = "Editar";
                cboReservaEstado.Enabled = true;

                _esEdicion = true;
                _originalReserva = new ReservasLib(
                    _selectedReserva.ReservaID,
                    _selectedReserva.ReservaCodigo,
                    _selectedReserva.ReservaDateTime,
                    _selectedReserva.PersonasCant,
                    _selectedReserva.NumeroMesa,
                    _selectedReserva.ReservaEstado,
                    _selectedReserva.ReservaCreacion,
                    _selectedReserva.ReservaCliente
                );
                ActualizarTextBoxReserva();
            }
        }
    }
}
