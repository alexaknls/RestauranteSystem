using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        private DateTime _fechaHoraSeleccionada;
        public int MesaSeleccionada { get; private set; }
        public int NumeroMesasSeleccionada { get => numeroMesasSeleccionada; set => numeroMesasSeleccionada = value; }

        public MenuMesas(DateTime _fechaHoraSeleccionada)
        {
            InitializeComponent();
            _controladorReservas = new ControladorReservas();
            DeshabilitarMesasOcupadas(_fechaHoraSeleccionada);
            BtnMesasControls();
        }

        private void DeshabilitarMesasOcupadas(DateTime fechaHoraSeleccionada)
        {
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

