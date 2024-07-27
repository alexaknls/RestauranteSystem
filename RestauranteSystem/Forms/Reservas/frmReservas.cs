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

        public frmReservas()
        {
            InitializeComponent();
            _controladorReservas = new ControladorReservas();
            _reservasLista = _controladorReservas.ObtenerReservas();
            bnSrcReservas.DataSource = _reservasLista;

            GeneradordeCodigoReservaFromForm();

        }
        private void frmReservas_Load(object sender, EventArgs e)
        {
            dgvReservasView.DataSource = bnSrcReservas;
        }
        private void dgvReservasView_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvReservasView.SelectedRows.Count > 0)
            {
                _selectedReserva = (ReservasLib)dgvReservasView.SelectedRows[0].DataBoundItem;
            }
        }
        private void GeneradordeCodigoReservaFromForm()
        {
            nuevoCodigoReserva = _controladorReservas.GeneradordeCodigoReserva();
            txbReservaCodigo.Text = nuevoCodigoReserva;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string reservaCodigo = txbReservaCodigo.Text;
                DateTime reservaFecha = dtpReservaFecha.Value;
                DateTime reservaHora = dtpReservaHora.Value;
                DateTime reservaDatetime = new DateTime(reservaFecha.Year, reservaFecha.Month, reservaFecha.Day, reservaHora.Hour, reservaHora.Minute, reservaHora.Second);

                int personasCant = int.Parse(txbCantPersonas.Text);
                int numeroMesa = int.Parse(txbMesasNum.Text);
                string reservaEstado = cboReservaEstado.SelectedItem.ToString();
                DateTime reservaCreacion = dtpReservaCreacion.Value;

                ReservasLib nuevaReserva = new ReservasLib
                {
                    ReservaCodigo = reservaCodigo,
                    ReservaDateTime = reservaDatetime,
                    PersonasCant = personasCant,
                    NumeroMesa = numeroMesa,
                    ReservaEstado = reservaEstado,
                    ReservaCreacion = reservaCreacion

                };
                _controladorReservas.AgregarReserva(nuevaReserva);

                _reservasLista = _controladorReservas.ObtenerReservas();
                bnSrcReservas.DataSource = _reservasLista;
                bnSrcReservas.ResetBindings(false);
                LimpiarFormulario();
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
            cboReservaEstado.SelectedIndex = 1;
            dtpReservaCreacion.Value = DateTime.Now;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnMesasView_Click(object sender, EventArgs e)
        {

        }
    }
}
