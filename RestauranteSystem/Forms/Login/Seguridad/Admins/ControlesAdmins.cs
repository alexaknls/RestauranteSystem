using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestauranteSystem.Forms.Login;
using RestauranteSystem.Forms.Login.Seguridad.Roles;
using RestauranteSystem.Forms.Login.Seguridad.Usuarios;

namespace RestauranteSystem.Forms.Login.Seguridad.Admins
{
    public partial class ControlesAdmins : Form
    {
        public ControlesAdmins()
        {
            InitializeComponent();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios.Usuarios frmUsuarios = new Usuarios.Usuarios();
            frmUsuarios.ShowDialog();
        }

        private void btnVerificaciones_Click(object sender, EventArgs e)
        {
            FrmVerificaciones frmVerificaciones = new FrmVerificaciones();
            frmVerificaciones.ShowDialog();
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            Roles.Roles frmRoles = new Roles.Roles();
            frmRoles.ShowDialog();
        }
    }
}
