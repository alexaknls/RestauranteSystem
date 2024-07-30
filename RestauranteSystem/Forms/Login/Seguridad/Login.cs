using RestauranteLib.Seguridad;
using RestauranteSystem.Forms.Login;
using RestauranteSystem.Forms.Login.Seguridad.Roles;
using RestauranteSystem.Forms.Login.Seguridad.Usuarios;
using RestauranteLib.Controladores.Seguridad;
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
        private Usuario usuarioSession;
        private wwwUsuarios wwwUsuarios;

        public Login()
        {
            InitializeComponent();
           wwwUsuarios = new wwwUsuarios();

        }

        public Usuario UsuarioSession { get ; set ; }

        private void btnSession_Click(object sender, EventArgs e)
        {
           /* UsuarioSession = wwwUsuarios.Login(txtUser.Text, txtPasword.Text);
            if (UsuarioSession != null)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
    }
}
