using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestauranteSystem.Forms.Reservas
{
    public partial class MenuMesas : Form
    {
        private int numeroMesasSeleccionada;
        public int NumeroMesasSeleccionada { get => numeroMesasSeleccionada; set => numeroMesasSeleccionada = value; }

        public MenuMesas()
        {
            InitializeComponent();

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

