using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
=======
using DocumentFormat.OpenXml.Drawing.Diagrams;
>>>>>>> ba77c355c82dc54ca88a7c89bb4bc2dd77c8fc9e
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
<<<<<<< HEAD
        private ControladorReservas _controladorReservas;
        private DateTime _fechaHoraSeleccionada;
        public int MesaSeleccionada { get; private set; }
=======

        private ControladorReservas _controladorReservas;
        private List<ReservasLib> _reservaList;
        private BindingSource bnSrcReservas;
>>>>>>> ba77c355c82dc54ca88a7c89bb4bc2dd77c8fc9e
        public int NumeroMesasSeleccionada { get => numeroMesasSeleccionada; set => numeroMesasSeleccionada = value; }

        public MenuMesas(DateTime _fechaHoraSeleccionada)
        {
            InitializeComponent();
            _controladorReservas = new ControladorReservas();
<<<<<<< HEAD
=======
            bnSrcReservas = new BindingSource();
            _reservaList = _controladorReservas.ObtenerReservas();

            bnSrcReservas.DataSource = _reservaList;
>>>>>>> ba77c355c82dc54ca88a7c89bb4bc2dd77c8fc9e
            DeshabilitarMesasOcupadas(_fechaHoraSeleccionada);
            BtnMesasControls();
        }

        private void DeshabilitarMesasOcupadas(DateTime fechaHoraSeleccionada)
        {
<<<<<<< HEAD
            List<int> mesasOcupadas = _controladorReservas.ObtenerMesasOcupadas(fechaHoraSeleccionada);

            foreach (int mesa in mesasOcupadas)
            {
                string btnMesaOcupada = "btnMesa" + mesa.ToString();
                Button buttonMesa = this.Controls.Find(btnMesaOcupada, true).FirstOrDefault() as Button;
                if (buttonMesa != null)
                {
                    buttonMesa.Enabled = false;
                    buttonMesa.BackColor = SystemColors.ControlDarkDark;
                    buttonMesa.FlatStyle = FlatStyle.Flat;
                }
            }
=======
            var mesasOcupadas = _controladorReservas.ObtenerMesasOcupadas(fechaHoraSeleccionada);

            string mesasTexto = "-Mesas Ocupadas- \n";

            foreach (var mesa in mesasOcupadas)
            {
                int numeroMesa = mesa.Key;
                List<ReservasLib> reservas = mesa.Value;
                bool mostrarMesa = false;
                string horarios = "";

                foreach (ReservasLib reserva in reservas)
                {
                    if (reserva.ReservaEstado != "INA")
                    {
                        mostrarMesa = true;
                        horarios += $"  - {reserva.ReservaDateTime.ToString("dd/MM/yyyy HH:mm")} \n";
                    }
                }

                if (mostrarMesa)
                {
                    mesasTexto += $"Mesa {numeroMesa}:\n{horarios}\n";

                    Button buttonMesa = this.Controls.Find("btnMesa" + numeroMesa.ToString(), true).FirstOrDefault() as Button;
                    if (buttonMesa != null)
                    {
                        buttonMesa.Enabled = false;
                        buttonMesa.BackColor = SystemColors.ControlDarkDark;
                        buttonMesa.FlatStyle = FlatStyle.Flat;
                    }
                }
                else
                {
                    Button buttonMesa = this.Controls.Find("btnMesa" + numeroMesa.ToString(), true).FirstOrDefault() as Button;
                    if (buttonMesa != null)
                    {
                        buttonMesa.Enabled = true;
                        buttonMesa.BackColor = SystemColors.Control;
                        buttonMesa.FlatStyle = FlatStyle.Standard;
                    }
                }
            }

            lblMesasOcupadas.Text = mesasTexto;
>>>>>>> ba77c355c82dc54ca88a7c89bb4bc2dd77c8fc9e
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

