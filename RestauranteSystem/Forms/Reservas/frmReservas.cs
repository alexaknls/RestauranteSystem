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

namespace RestauranteSystem.Reservas
{
    public partial class frmReservas : Form
    {
        private ControladorReservas _controladorReservas;
        private List<ReservasLib> _reservasLista;
        private ReservasLib _selectedReserva;


        public frmReservas()
        {
            InitializeComponent();
            _controladorReservas = new ControladorReservas();
            _reservasLista = _controladorReservas.ObtenerReservas();
            bnSrcReservas.DataSource = _reservasLista;
        }
        private void dgvReservasView_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvReservasView.SelectedRows.Count > 0)
            {
                _selectedReserva = (ReservasLib)dgvReservasView.SelectedRows[0].DataBoundItem;
            }
        }
    }
}
