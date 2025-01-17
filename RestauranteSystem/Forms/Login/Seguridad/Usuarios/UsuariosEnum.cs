﻿using RestauranteLib.Seguridad;
using RestauranteLib.Controladores.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Wordprocessing;
using RestauranteLib;
using static RestauranteDAO.RestauranteDataSet;

namespace RestauranteSystem.Forms.Login.Seguridad.Usuarios
{
    public partial class UsuariosEnum : Form
    {
        private EModoFormulario _modo;
        private Usuario _usuario;
        private wwwUsuarios _controladorUsuarios;

        public UsuariosEnum()
        {
            InitializeComponent();
            _usuario = new Usuario();
            _controladorUsuarios = new wwwUsuarios();
            txtCodigo.Hide();
            lblCodigoID.Hide();
        }

        public Usuario Usuario
        {
            get => _usuario;
            set
            {
                _usuario = value;
                setClientToControls();
                
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
                        setClientToControls();
                        break;
                    case EModoFormulario.Nuevo:
                        break;
                }
            }
        }

        private void setClientToControls()
        {
            if (_usuario == null) return;
            if (_usuario.ID > 0)
            {
                txtNombre.Text = _usuario.Name;
                txtUser.Text = _usuario.User;
                cboEstado.Text = _usuario.Estado == "ACT" ? "Activo" : "Inactivo";
                txtCodigo.Text = _usuario.ID.ToString();
                txtCodigo.Enabled = false;
                setReadOnly();
                establecerTitulo();
            }
        }

        private void establecerTitulo()
        {
            if (_modo == EModoFormulario.Nuevo)
            {
                tituloFormulario.Text = "Ingresando Nuevo Usuario";
                Text = "Ingresando Nuevo Usuario";
            }
            if (_usuario.ID > 0)
            {
                switch (_modo)
                {
                    case EModoFormulario.Modificar:
                        tituloFormulario.Text = "Modificando Usuario";
                        Text = "Modificando Usuario";
                        break;
                    case EModoFormulario.Eliminar:
                        tituloFormulario.Text = "Eliminando Usuario";
                        Text = "Eliminando Usuario";
                        break;
                    case EModoFormulario.Consultar:
                        tituloFormulario.Text = "Detalle de Usuario";
                        Text = "Detalle de Usuario";
                        break;
                }
            }
        }

        private void setReadOnly()
        {
            if (_modo == EModoFormulario.Consultar || _modo == EModoFormulario.Eliminar)
            {
                txtUser.Enabled = false;
                txtNombre.Enabled = false;
                txtPassword.Enabled = false;
                cboEstado.Enabled = false;
                if (_modo == EModoFormulario.Consultar)
                {
                    btnConfirmar.Visible = false;
                }
            }
        }
      /*  private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            byte[] passwordSaltBytes;
            string passwordHash = PasswordUtility.hashPassword(txtPassword.Text, out passwordSaltBytes);
            string passwordSalt = Convert.ToHexString(passwordSaltBytes);
            string password = passwordSalt + passwordHash;
            try
            {
                string estado = cboEstado.Text == "Activo" ? ECommonStatus.ACT : ECommonStatus.INA;

                this._usuario = new Usuario(
                int.Parse(txtCodigo.Text),
                txtUser.Text,
                password,
                DateTime.Now.AddDays(90),
                passwordHash,
                passwordSalt,
                txtNombre.Text,
                cboEstado.Text == "Activo" ? "ACT" : "INA"
            );

                if (_modo == EModoFormulario.Modificar)
                {
                    if (_controladorUsuarios.actualizarUsuario(_usuario, _usuario))
                    {
                        MessageBox.Show("Usuario actualizada exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar el usuario");
                    }
                }
                else if (_modo == EModoFormulario.Nuevo)
                {
                    if (_controladorUsuarios.agregarUsuario(_usuario))
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }*/

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }

}
