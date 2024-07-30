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
            UsuariosEnum nuevoUsuarioForm = new UsuariosEnum();
            nuevoUsuarioForm.Modo = EModoFormulario.Nuevo;

            if (nuevoUsuarioForm.ShowDialog() == DialogResult.OK)
            {
                Usuario nuevoUser = nuevoUsuarioForm.Usuario;

                bool userAgregado = _wwwUsuarios.agregarUsuario(nuevoUser);

                if (userAgregado)
                {
                    MessageBox.Show("User agregado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _usuariosLista = _wwwUsuarios.obtenerUsuarios();
                    bndSrcUsuarios.DataSource = _usuariosLista;
                    bndSrcUsuarios.ResetBindings(false);
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (_usuarioSeleccionado != null)
            {
                UsuariosEnum usuarioForm = new UsuariosEnum();
                usuarioForm.Modo = EModoFormulario.Consultar;
                usuarioForm.Usuario = _usuarioSeleccionado;
                usuarioForm.ShowDialog();
                usuarioForm.Dispose();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario de la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            UsuariosEnum eliminarForm = new UsuariosEnum();
            eliminarForm.Modo = EModoFormulario.Eliminar;
            if (_usuarioSeleccionado != null)
            {
                DialogResult result = MessageBox.Show(
                    "¿Estás seguro de que deseas eliminar este usuario?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    bool eliminado = _wwwUsuarios.eliminarUsuario(_usuarioSeleccionado);
                    if (eliminado)
                    {
                        MessageBox.Show("Usuario eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _usuariosLista = _wwwUsuarios.obtenerUsuarios();
                        bndSrcUsuarios.DataSource = _usuariosLista;
                        bndSrcUsuarios.ResetBindings(false);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (_usuarioSeleccionado != null)
            {
                UsuariosEnum editarForm = new UsuariosEnum();
                editarForm.Modo = EModoFormulario.Modificar;
                editarForm.Usuario = _usuarioSeleccionado;

                if (editarForm.ShowDialog() == DialogResult.OK)
                {
                    var userActualizado = editarForm.Usuario;
                    bool userModificado = _wwwUsuarios.actualizarUsuario(userActualizado, _usuarioSeleccionado);

                    if (userModificado)
                    {
                        _usuariosLista = _wwwUsuarios.obtenerUsuarios();
                        bndSrcUsuarios.DataSource = _usuariosLista;
                        bndSrcUsuarios.ResetBindings(false);
                        MessageBox.Show("Usuario actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                editarForm.Dispose();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un user de la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
