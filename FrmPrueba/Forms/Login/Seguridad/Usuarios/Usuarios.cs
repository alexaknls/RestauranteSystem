using RestauranteLib;
using RestauranteLib.Controladores.Seguridad;
using RestauranteLib.Seguridad;
using RestauranteSystem.Forms.Login.Seguridad.Roles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestauranteSystem.Forms.Login.Seguridad.Usuarios
{
    public partial class Usuarios : Form
    {
        private wwwUsuarios _wwwUsuarios;
        private Usuario _usuarioSeleccionado;
        List<Usuario> _usuariosLista;
        public Usuarios()
        {
            InitializeComponent();
            _wwwUsuarios = new wwwUsuarios();
            _usuariosLista = _wwwUsuarios.obtenerUsuarios();
            bndSrcUsuarios.DataSource = _usuariosLista;

        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                _usuarioSeleccionado = (Usuario)dgvUsuarios.SelectedRows[0].DataBoundItem;
            }
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = bndSrcUsuarios;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            UsuariosEnum nuevoUserForm = new UsuariosEnum();
            nuevoUserForm.Modo = EModoFormulario.Nuevo;

            if (nuevoUserForm.ShowDialog() == DialogResult.OK)
            {
                Usuario nuevoUser = nuevoUserForm.Usuario;
                int resultado = _wwwUsuarios.agregarUsuario(nuevoUser);

                if (resultado > 0)
                {
                    MessageBox.Show("Usuario agregado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _usuariosLista = _wwwUsuarios.obtenerUsuarios();
                    bndSrcUsuarios.DataSource = _usuariosLista;
                    bndSrcUsuarios.ResetBindings(false);
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (_usuarioSeleccionado != null)
            {
                UsuariosEnum verUserForm = new UsuariosEnum();
                verUserForm.Modo = EModoFormulario.Consultar;
                verUserForm.Usuario = _usuarioSeleccionado;
                verUserForm.ShowDialog();
            }
        }
    }
}
