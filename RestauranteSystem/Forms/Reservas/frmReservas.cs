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
using System.Diagnostics.Eventing.Reader;
using System.Xml.Serialization;

namespace RestauranteSystem.Reservas
{
    public partial class frmReservas : Form
    {
        private ControladorReservas _controladorReservas;
        private List<ReservasLib> _reservasLista;
        private ReservasLib _selectedReserva;
        private string nuevoCodigoReserva;

        private bool _esEdicion = false;
        private bool _esEliminacion = false;
        private bool _esVerReserva = false;
        private ReservasLib _originalReserva = null;
        private DateTime reservaDatetime;


        public frmReservas()
        {
            InitializeComponent();
            _controladorReservas = new ControladorReservas();
            _reservasLista = _controladorReservas.ObtenerReservas();
            bnSrcReservas.DataSource = _reservasLista;
            dtpReservaHora.CloseUp += new EventHandler(dtpReservaHora_CloseUp);

            GeneradordeCodigoReservaFromForm();
            LimpiarFormulario();
        }
        private void frmReservas_Load(object sender, EventArgs e)
        {
            dgvReservasView.DataSource = bnSrcReservas;
            LimpiarFormulario();

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
        private void ActualizarTextBoxReserva()
        {
            if (_selectedReserva != null)
            {
                txbClienteID.Text = _selectedReserva.ReservaCliente;
                txbReservaCodigo.Text = _selectedReserva.ReservaCodigo;
                dtpReservaFecha.Value = _selectedReserva.ReservaDateTime.Date;
                dtpReservaHora.Value = _selectedReserva.ReservaDateTime;

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

                DateTime reservaFecha = dtpReservaFecha.Value;
                DateTime reservaHora = dtpReservaHora.Value;
                DateTime reservaDatetime = new DateTime(reservaFecha.Year, reservaFecha.Month, reservaFecha.Day, reservaHora.Hour, reservaHora.Minute, reservaHora.Second);

                _selectedReserva.ReservaCodigo = txbReservaCodigo.Text;
                _selectedReserva.ReservaDateTime = reservaDatetime;
                _selectedReserva.PersonasCant = int.Parse(txbCantPersonas.Text);
                _selectedReserva.NumeroMesa = int.Parse(txbMesasNum.Text);
                _selectedReserva.ReservaEstado = cboReservaEstado.Text;
                _selectedReserva.ReservaCreacion = dtpReservaCreacion.Value;
                _selectedReserva.ReservaCliente = txbClienteID.Text;


                if (_esEdicion)
                {
                    bool actualizarReserva = _controladorReservas.EditarReserva(_selectedReserva, _originalReserva);

                    if (actualizarReserva)
                    {
                        MessageBox.Show("Reserva actualizada exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar la reserva.");
                    }

                }
                else
                {
                    if (_esEliminacion)
                    {
                        DialogResult dialogResult = MessageBox.Show("¿Seguro que quiere eliminar el registro?", "Confirmar eliminación",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Warning
                                 );
                        if (dialogResult == DialogResult.Yes)
                        {
                            bool eliminarReserva = _controladorReservas.EliminarReserva(_selectedReserva);
                            if (eliminarReserva)
                            {

                                MessageBox.Show("Reserva eliminada exitosamente.");
                            }
                            else
                            {
                                MessageBox.Show("Error al eliminar la reserva.");
                            }
                        }
                    }
                    else
                    {
                        cboReservaEstado.Enabled = false;
                        ReservasLib nuevaReserva = new ReservasLib
                        {
                            ReservaCodigo = reservaCodigo,
                            ReservaDateTime = reservaDatetime,
                            PersonasCant = personasCant,
                            NumeroMesa = numeroMesa,
                            ReservaEstado = reservaEstado,
                            ReservaCreacion = reservaCreacion,
                            ReservaCliente = reservaCliente

                        };
                        _controladorReservas.AgregarReserva(nuevaReserva);
                    }

                }

                _esEdicion = false;
                _esEliminacion = false;
                btnGuardar.Text = "Guardar";

                LimpiarFormulario();
                ActivateElements();

                _originalReserva = null;
                _reservasLista = _controladorReservas.ObtenerReservas();
                bnSrcReservas.DataSource = _reservasLista;
                bnSrcReservas.ResetBindings(true);
            }
            catch
            {
                MessageBox.Show("Error al guardar la reserva");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            ActivateElements();
            _esEdicion = false;
            _esEliminacion = false;
            btnGuardar.Text = "Guardar";
        }

        private void btnMesasView_Click(object sender, EventArgs e)
        {
            DateTime fechaHoraSeleccionada = new DateTime(dtpReservaFecha.Value.Year, dtpReservaFecha.Value.Month, dtpReservaFecha.Value.Day, dtpReservaHora.Value.Hour, dtpReservaHora.Value.Minute, dtpReservaHora.Value.Second);

            MenuMesas menuMesas = new MenuMesas(fechaHoraSeleccionada);
            menuMesas.ShowDialog();

            if (menuMesas.DialogResult == DialogResult.OK)
            {
                txbMesasNum.Text = menuMesas.NumeroMesasSeleccionada.ToString();
            }
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
            if (_esVerReserva == true)
            {
                _esVerReserva = false;
                ActivateElements();
            }
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
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DeactivateElements();
            _esEliminacion = true;
            ActualizarTextBoxReserva();
            btnGuardar.Text = "Eliminar";
            btnCancelar.Enabled = true;

        }

        private void DeactivateElements()
        {
            foreach (Control _controls in this.pnlNuevaReserva.Controls)
            {
                if (_controls is TextBox)
                {
                    _controls.Enabled = false;
                }
                if (_controls is DateTimePicker)
                {
                    _controls.Enabled = false;
                }
                if (_controls is Button)
                {
                    _controls.Enabled = false;
                    btnGuardar.Enabled = true;
                }
            }
        }
        private void ActivateElements()
        {
            foreach (Control _controls in this.pnlNuevaReserva.Controls)
            {
                if (_controls is TextBox)
                {
                    _controls.Enabled = true;
                    txbMesasNum.Enabled = false;
                    txbReservaCodigo.Enabled = false;
                }
                if (_controls is DateTimePicker)
                {
                    _controls.Enabled = true;
                    dtpReservaCreacion.Enabled = false;
                }
                if (_controls is Button)
                {
                    _controls.Enabled = true;
                }
            }
        }

        private void btnVerReserva_Click(object sender, EventArgs e)
        {
            _esVerReserva = true;
            ActualizarTextBoxReserva();
            DeactivateElements();
            btnGuardar.Enabled = false;
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            ExportarAExcel excel = new ExportarAExcel();
            if (saveDialogExcel.ShowDialog() == DialogResult.OK)
            {
                string archivoAGuardar = saveDialogExcel.FileName;
                excel.ExportarListaAExcel(_reservasLista, archivoAGuardar);
                MessageBox.Show("Archivo Guardado Exitosamente");
            }
        }

        private void btnImportarExcel_Click(object sender, EventArgs e)
        {
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                string ArchivoALeer = openDialog.FileName;
                XmlSerializer serializador = new XmlSerializer(
                    typeof(List<ReservasLib>)
                );
                StreamReader lector = new StreamReader(ArchivoALeer);
                _reservasLista = (List<ReservasLib>)serializador.Deserialize(lector) ?? new List<ReservasLib>();
                bnSrcReservas.DataSource = _reservasLista;
                MessageBox.Show("Archivo Abierto Exitosamente");

            }
        }

        private void btnExportarXML_Click(object sender, EventArgs e)
        {
            if (saveDialogX.ShowDialog() == DialogResult.OK)
            {
                string ArchivoGuardado = saveDialogX.FileName;
                XmlSerializer serializador = new XmlSerializer(
                    typeof(List<ReservasLib>)
                    );
                StreamWriter guardador = new StreamWriter(ArchivoGuardado);
                serializador.Serialize(guardador, _reservasLista);
                MessageBox.Show("Archivo Guardado Exitosamente");
            }
        }

        private void dtpReservaHora_CloseUp(object sender, EventArgs e)
        {
            // Obtener el valor actual del DateTimePicker
            DateTime fechaHoraSeleccionada = dtpReservaHora.Value;

            // Crear un nuevo DateTime con los segundos establecidos en 00
            DateTime fechaHoraSinSegundos = new DateTime(
                fechaHoraSeleccionada.Year,
                fechaHoraSeleccionada.Month,
                fechaHoraSeleccionada.Day,
                fechaHoraSeleccionada.Hour,
                fechaHoraSeleccionada.Minute,
                0
            );

            // Actualizar el valor del DateTimePicker
            dtpReservaHora.Value = fechaHoraSinSegundos;
        }
    }
}
