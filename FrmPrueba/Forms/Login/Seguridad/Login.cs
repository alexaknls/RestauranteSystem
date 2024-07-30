using RestauranteSystem.Forms.Login;
using RestauranteSystem.Forms.Login.Seguridad.Roles;
using RestauranteSystem.Forms.Login.Seguridad.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestauranteSystem.Login.Seguridad
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnSession_Click(object sender, EventArgs e)
        {
            FrmVerificaciones frmVerificaciones = new FrmVerificaciones();
            frmVerificaciones.ShowDialog();
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            Roles frmRoles = new Roles();
            frmRoles.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios frmUsuarios = new Usuarios();
            frmUsuarios.ShowDialog();
        }
    }
}
