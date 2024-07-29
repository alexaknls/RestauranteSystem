using RestauranteLib.Controladores.Seguridad;
using RestauranteLib.Seguridad;
using RestauranteLib;
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
    public partial class RolesEnum : Form
    {
        private EModoFormulario _modo;
        private Rol _rol;
        private wwwRoles _wwwRoles;
        public RolesEnum()
        {
            InitializeComponent();
            _rol = new Rol();
            _wwwRoles = new wwwRoles();
        }
        public Rol Rol
        {
            get => _rol;
            set
            {
                _rol = value;
                setClientToControls();
            }
        }
        public EModoFormulario Modo
        {
            get => _modo;
            set
            {
                switch (value)
                {
                    case EModoFormulario.Modificar:
                    case EModoFormulario.Eliminar:
                    case EModoFormulario.Consultar:
                        setClientToControls();
                        break;
                    case EModoFormulario.Nuevo:
                        break;
                }
                _modo = value;
            }
        }
        private void setClientToControls()
        {
            if (_rol == null) return;
            if (_rol.RolId > 0)
            {
                establecerTitulo();
                txtNombre.Text = _rol.RolName;
                cboEstado.Text = _rol.Estado == "ACT" ? "Activo" : "Inactivo";
                dtpRolFecha.Text = DateTime.Now.ToString();
                setReadOnly();
            }
        }

        private void establecerTitulo()
        {

            if (_rol.RolId > 0)
            {
                switch (_modo)
                {
                    case EModoFormulario.Modificar:
                        tituloFormulario.Text = "Modificando Verificación";
                        Text = "Modificando Verificación";
                        break;
                    case EModoFormulario.Eliminar:
                        tituloFormulario.Text = "Eliminando Verificación";
                        Text = "Eliminando Verificación";
                        break;
                    case EModoFormulario.Consultar:
                        tituloFormulario.Text = "Detalle de Verificación";
                        Text = "Detalle de Verificación";
                        break;
                }
            }
        }
        private void setReadOnly()
        {
            if (_modo == EModoFormulario.Consultar || _modo == EModoFormulario.Eliminar)
            {
                txtNombre.Enabled = false;
                dtpRolFecha.Enabled = false;
                cboEstado.Enabled = false;
                if (_modo == EModoFormulario.Consultar)
                {
                    btnConfirmar.Visible = false;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            _rol = new Rol(
                int.Parse(txtCodigo.Text),
                txtNombre.Text,
                cboEstado.SelectedItem.ToString() == "Activo" ? "ACT" : "INA",
                dtpRolFecha.Value
            );

            if (_modo == EModoFormulario.Modificar)
            {
                if (_wwwRoles.ActualizarRoles(_rol, _rol))
                {
                    MessageBox.Show("Verificación actualizada exitosamente");
                }
                else
                {
                    MessageBox.Show("Error al actualizar la verificación");
                }
            }
            else if (_modo == EModoFormulario.Nuevo)
            {
                if (_wwwRoles.InsertarRol(_rol))
                {
                    MessageBox.Show("Nueva verificación agregada exitosamente");
                }
                else
                {
                    MessageBox.Show("Error al agregar la nueva verificación");
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dtpRolFecha_CloseUp(object sender, EventArgs e)
        {
            DateTime fechaHoraCreacion = dtpRolFecha.Value;

            DateTime fechaHoraSinSegundos = new DateTime(
                fechaHoraCreacion.Year,
                fechaHoraCreacion.Month,
                fechaHoraCreacion.Day,
                fechaHoraCreacion.Hour,
                fechaHoraCreacion.Minute,
                0
            );

            dtpRolFecha.Value = fechaHoraSinSegundos;
        }
    }
}
