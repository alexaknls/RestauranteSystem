using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Vml.Office;
using RestauranteLib;
using RestauranteLib.Controladores.Seguridad;
using RestauranteLib.Seguridad;
using RestauranteSystem.Forms.Login.Seguridad.Verificaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestauranteSystem.Forms.Login.Seguridad.Roles
{
    public partial class Roles : Form
    {
        private wwwRoles _wwwRoles;
        private Rol _rolSeleccionado;
        private List<Rol> _rolesLista;
        public Roles()
        {
            InitializeComponent();
            _wwwRoles = new wwwRoles();
            _rolesLista = _wwwRoles.ObtenerRoles();
            bndSrcRoles.DataSource = _rolesLista;

        }
        private void dgvRoles_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRoles.SelectedRows.Count > 0)
            {
                _rolSeleccionado = (Rol)dgvRoles.SelectedRows[0].DataBoundItem;
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (_rolSeleccionado != null)
            {
                RolesEnum rolForm = new RolesEnum();
                rolForm.Modo = EModoFormulario.Consultar;
                rolForm.Rol = _rolSeleccionado;
                rolForm.ShowDialog();
                rolForm.Dispose();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un rol de la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (_rolSeleccionado != null)
            {
                RolesEnum rolForm = new RolesEnum();
                rolForm.Modo = EModoFormulario.Modificar;
                rolForm.Rol = _rolSeleccionado;

                if (rolForm.ShowDialog() == DialogResult.OK)
                {
                    var rolActualizado = rolForm.Rol;
                    bool rolModificado = _wwwRoles.ActualizarRol(rolActualizado, _rolSeleccionado);

                    if (rolModificado)
                    {
                        _rolesLista = _wwwRoles.ObtenerRoles();
                        bndSrcRoles.DataSource = _rolesLista;
                        bndSrcRoles.ResetBindings(false);
                        MessageBox.Show("Rol actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el rol.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                rolForm.Dispose();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un rol de la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Roles_Load(object sender, EventArgs e)
        {
            dgvRoles.DataSource = bndSrcRoles;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_rolSeleccionado != null)
            {
                DialogResult result = MessageBox.Show(
                    "¿Estás seguro de que deseas eliminar este rol?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    bool eliminado = _wwwRoles.EliminarRol(_rolSeleccionado);
                    if (eliminado)
                    {
                        MessageBox.Show("Rol eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _rolesLista = _wwwRoles.ObtenerRoles();
                        bndSrcRoles.DataSource = _rolesLista;
                        bndSrcRoles.ResetBindings(false);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el rol.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            RolesEnum nuevoRolForm = new RolesEnum();
            nuevoRolForm.Modo = EModoFormulario.Nuevo;

            if (nuevoRolForm.ShowDialog() == DialogResult.OK)
            {
                Rol nuevoRol = nuevoRolForm.Rol;

                bool rolAgregado = _wwwRoles.InsertarRol(nuevoRol);

                if (rolAgregado)
                {
                    MessageBox.Show("Rol agregado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _rolesLista = _wwwRoles.ObtenerRoles();
                    bndSrcRoles.DataSource = _rolesLista;
                    bndSrcRoles.ResetBindings(false);
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el rol.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
