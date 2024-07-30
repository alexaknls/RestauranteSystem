using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RestauranteLib;
using RestauranteLib.Controladores.Seguridad;
using RestauranteLib.Seguridad;
using RestauranteSystem.Forms.Login.Seguridad.Verificaciones;

namespace RestauranteSystem.Forms.Login
{
    public partial class FrmVerificaciones : Form
    {
        private wwwVerificaciones _controladorVerificaciones;
        private List<Verificacion> _verificacionLista;
        private Verificacion _verificacionLib;

        public FrmVerificaciones()
        {
            InitializeComponent();
            _controladorVerificaciones = new wwwVerificaciones();
            _verificacionLista = _controladorVerificaciones.wwwObtenerVerificaciones();
            bndSrcVerificaciones.DataSource = _verificacionLista;
        }

        private void dgvVerificaciones_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVerificaciones.SelectedRows.Count > 0)
            {
                _verificacionLib = (Verificacion)dgvVerificaciones.SelectedRows[0].DataBoundItem;
            }
        }

        private void FrmVerificaciones_Load(object sender, EventArgs e)
        {
            dgvVerificaciones.DataSource = bndSrcVerificaciones;
        }

        private void btnVerVerificacion_Click(object sender, EventArgs e)
        {
            if (_verificacionLib != null)
            {
                VerificacionesEnum mostrarForm = new VerificacionesEnum();
                mostrarForm.Modo = EModoFormulario.Consultar;
                mostrarForm.Verificacion = _verificacionLib;
                mostrarForm.ShowDialog();
                mostrarForm.Dispose();
            }
        }

        private void btnEliminarVerificacion_Click(object sender, EventArgs e)
        {
            if (_verificacionLib != null)
            {
                VerificacionesEnum eliminarForm = new VerificacionesEnum();
                eliminarForm.Modo = EModoFormulario.Eliminar;
                eliminarForm.Verificacion = _verificacionLib;
               
                if (eliminarForm.ShowDialog() == DialogResult.OK)
                {

                    bool verificacionEliminada = _controladorVerificaciones.EliminarVerificacion(eliminarForm.Verificacion);

                    if (verificacionEliminada)
                    {
                        _verificacionLista = _controladorVerificaciones.wwwObtenerVerificaciones();
                        bndSrcVerificaciones.DataSource = _verificacionLista;
                        bndSrcVerificaciones.ResetBindings(false);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar la verificación. Inténtelo nuevamente.");
                    }
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (_verificacionLib != null)
            {
                VerificacionesEnum editarForm = new VerificacionesEnum();
                editarForm.Modo = EModoFormulario.Modificar;
                editarForm.Verificacion = _verificacionLib;

                if (editarForm.ShowDialog() == DialogResult.OK)
                {
                    bool verificacionActualizada = _controladorVerificaciones.ActualizarVerificacion(editarForm.Verificacion, _verificacionLib);
                    if (verificacionActualizada)
                    {
                        _verificacionLista = _controladorVerificaciones.wwwObtenerVerificaciones();
                        bndSrcVerificaciones.DataSource = _verificacionLista;
                        bndSrcVerificaciones.ResetBindings(false);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar la verificación. Inténtelo nuevamente.");
                    }

                }
                editarForm.Dispose();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            VerificacionesEnum nuevaVerificacionForm = new VerificacionesEnum();
            nuevaVerificacionForm.Modo = EModoFormulario.Nuevo;
            if (nuevaVerificacionForm.ShowDialog() == DialogResult.OK)
            {
                _verificacionLista = _controladorVerificaciones.wwwObtenerVerificaciones();
                    bndSrcVerificaciones.DataSource = _verificacionLista;
                    bndSrcVerificaciones.ResetBindings(false);
            }
            nuevaVerificacionForm.Dispose();
        }
    }
}
