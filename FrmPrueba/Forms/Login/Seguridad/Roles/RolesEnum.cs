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

        public RolesEnum()
        {
            InitializeComponent();
        }

        public Rol Rol
        {
            get => _rol;
            set
            {
                _rol = value;
                setRolToControls();
            }
        }

        public EModoFormulario Modo
        {
            get => _modo;
            set
            {
                _modo = value;
                switch (value)
                {
                    case EModoFormulario.Modificar:
                    case EModoFormulario.Eliminar:
                    case EModoFormulario.Consultar:
                        setRolToControls();
                        break;
                    case EModoFormulario.Nuevo:
                        break;
                }
            }
        }

        private void setRolToControls()
        {
            if (_rol == null) return;
            if (_rol.RolId > 0)
            {
                txtCodigo.Text = _rol.RolId.ToString();
                txtNombre.Text = _rol.RolName;
                cboEstado.Text = _rol.Estado;
                dtpRolFecha.Value = _rol.RolCreacion;
                setReadOnly();
                establecerTitulo();
            }
        }

        private void establecerTitulo()
        {
            if (_rol.RolId > 0)
            {
                switch (_modo)
                {
                    case EModoFormulario.Modificar:
                        tituloFormulario.Text = "Modificando Rol";
                        Text = "Modificando Rol";
                        break;
                    case EModoFormulario.Eliminar:
                        tituloFormulario.Text = "Eliminando Rol";
                        Text = "Eliminando Rol";
                        break;
                    case EModoFormulario.Consultar:
                        tituloFormulario.Text = "Detalle del Rol";
                        Text = "Detalle del Rol";
                        break;
                }
            }
        }

        private void setReadOnly()
        {
            if (_modo == EModoFormulario.Consultar || _modo == EModoFormulario.Eliminar)
            {
                txtCodigo.Enabled = false;
                txtNombre.Enabled = false;
                cboEstado.Enabled = false;
                dtpRolFecha.Enabled = false;
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
            try
            {
                string estado = cboEstado.Text == "Activo" ? ECommonStatus.ACT : ECommonStatus.INA;

                this._rol = new Rol(
                    int.Parse(txtCodigo.Text),
                    txtNombre.Text,
                    estado,
                    DateTime.Now
                );
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
