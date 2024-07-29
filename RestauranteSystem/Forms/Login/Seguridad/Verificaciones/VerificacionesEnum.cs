using RestauranteLib.Seguridad;
using RestauranteLib;
using RestauranteLib.Controladores.Seguridad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RestauranteSystem.Forms.Login.Seguridad.Verificaciones
{
    public partial class VerificacionesEnum : Form
    {
        private EModoFormulario _modo;
        private Verificacion _verificacion;
        private classVerificaciones _controladorVerificaciones;
        private int codigoEnTextbox;

        public VerificacionesEnum()
        {
            InitializeComponent();
            _verificacion = new Verificacion();
            _controladorVerificaciones = new classVerificaciones();
        }

        public Verificacion Verificacion
        {
            get => _verificacion;
            set
            {
                _verificacion = value;
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
            if (_verificacion == null) return;
            if (_verificacion.VerificacionID > 0)
            {
                txtDescripcion.Text = _verificacion.Descripcion;
                txtNombre.Text = _verificacion.Codigo;
                cboEstado.Text = _verificacion.Estado == "ACT" ? "Activo" : "Inactivo";
                txtCodigo.Text = _verificacion.VerificacionID.ToString();
                txtCodigo.Enabled = false;
                setReadOnly();
                establecerTitulo();
            }
        }

        private void establecerTitulo()
        {
            if (_modo == EModoFormulario.Nuevo)
            {
                tituloFormulario.Text = "Ingresando Nueva Verificación";
                Text = "Ingresando Nueva Verificación";
            }

            if (_verificacion.VerificacionID > 0)
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
                txtDescripcion.Enabled = false;
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

        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {

                 _verificacion = new Verificacion(
                int.Parse(txtCodigo.Text),
                txtNombre.Text,
                txtDescripcion.Text,
                cboEstado.SelectedItem.ToString() == "Activo" ? "ACT" : "INA"
            );

            // Si el modo es Modificar, llamamos al método ActualizarVerificacion
            if (_modo == EModoFormulario.Modificar)
            {
                if (_controladorVerificaciones.ActualizarVerificacion(_verificacion, _verificacion))
                {
                    MessageBox.Show("Verificación actualizada exitosamente");
                }
                else
                {
                    MessageBox.Show("Error al actualizar la verificación");
                }
            }
            // Si el modo es Nuevo, llamamos al método InsertarVerificacion
            else if (_modo == EModoFormulario.Nuevo)
            {
                if (_controladorVerificaciones.InsertarVerificacion(_verificacion))
                {
                    MessageBox.Show("Nueva verificación agregada exitosamente");
                }
                else
                {
                    MessageBox.Show("Error al agregar la nueva verificación");
                }
            }

            // Cerrar el formulario con un resultado OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
