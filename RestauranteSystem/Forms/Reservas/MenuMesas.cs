using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using RestauranteDAO;
using RestauranteDAO.RestauranteDataSetTableAdapters;
using RestauranteLib;
using RestauranteLib.Controladores;
using RestauranteSystem.Reservas;

namespace RestauranteSystem.Forms.Reservas
{
    public partial class MenuMesas : Form
    {
        private int numeroMesasSeleccionada;

        private ControladorReservas _controladorReservas;
        private List<ReservasLib> _reservaList;
        private BindingSource bnSrcReservas;
        public int NumeroMesasSeleccionada { get => numeroMesasSeleccionada; set => numeroMesasSeleccionada = value; }

        public MenuMesas(DateTime _fechaHoraSeleccionada)
        {
            InitializeComponent();
            _controladorReservas = new ControladorReservas();
            bnSrcReservas = new BindingSource();
            _reservaList = _controladorReservas.ObtenerReservas();

            bnSrcReservas.DataSource = _reservaList;
            DeshabilitarMesasOcupadas(_fechaHoraSeleccionada);
            BtnMesasControls();
        }

        private void DeshabilitarMesasOcupadas(DateTime fechaHoraSeleccionada)
        {
            //List<ReservasLib> reservasOcupadas = _controladorReservas.ObtenerMesasOcupadas(fechaHoraSeleccionada);
            var mesasOcupadas = _controladorReservas.ObtenerMesasOcupadas(fechaHoraSeleccionada);

            string mesasTexto = "-Mesas Ocupadas-";

            foreach (var mesa in mesasOcupadas)
            {
                int numeroMesa = mesa.Key;
                List<ReservasLib> reservas = mesa.Value;

                // Construir el texto para cada mesa con todas sus fechas.
                mesasTexto += $"Mesa {numeroMesa}:\n";
                foreach (ReservasLib reserva in reservas)
                {
                    string estado = reserva.ReservaEstado;
                    Button buttonMesa = this.Controls.Find("btnMesa" + numeroMesa.ToString(), true).FirstOrDefault() as Button;
                    if (buttonMesa != null)
                    {
                        if (estado == "INA")
                        {
                            buttonMesa.Enabled = true;
                            buttonMesa.BackColor = SystemColors.Control;
                            buttonMesa.FlatStyle = FlatStyle.Standard;
                        }
                        else
                        {
                            buttonMesa.Enabled = false;
                            buttonMesa.BackColor = SystemColors.ControlDarkDark;
                            buttonMesa.FlatStyle = FlatStyle.Flat;
                        }
                    }

                    mesasTexto += $"  - {reserva.ReservaDateTime.ToString("dd/MM/yyyy HH:mm")} \n";
                }
                mesasTexto += "\n";
            }

            // Actualizar el texto del label con la información de las mesas ocupadas.
        }
        public void BtnMesasControls()
        {
            foreach (Control _control in this.panelMesas.Controls)
            {
                if (_control is GroupBox)
                {
                    GroupBox groupBox = _control as GroupBox;

                    foreach (Control _innerPanel in groupBox.Controls)
                    {
                        if (_innerPanel is Panel)
                        {
                            Panel _panelesMesas = _innerPanel as Panel;
                            foreach (Control _btnControl in _panelesMesas.Controls)
                            {
                                if (_btnControl is Button)
                                {
                                    Button btnMesa = _btnControl as Button;
                                    btnMesa.Click += BtnMesa_Click;
                                }
                            }
                        }
                    }
                }
            }
        }

        public void BtnMesa_Click(object sender, EventArgs e)
        {
            BtnMesasControls();
            Button btnMesa = sender as Button;
            if(btnMesa != null)
            {
                NumeroMesasSeleccionada = int.Parse(btnMesa.Text);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

       

        /*******************************************************************/
    }
}

