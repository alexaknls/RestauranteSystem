using RestauranteDAO;
using RestauranteDAO.RestauranteDataSetTableAdapters;
using RestauranteLib.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestauranteLib.Controladores.Seguridad
{
    public class classVerificaciones
    {
        private RestauranteDataSet restaurantedataset;
        private VerificacionesTableAdapter verificacionesTableAdapter;
        private List<Verificacion> _verificacionLista;

        public classVerificaciones()
        {
            _verificacionLista = new List<Verificacion>();
            verificacionesTableAdapter = new VerificacionesTableAdapter();
            restaurantedataset = RestauranteDAO.Contexto.GetDataSet();
        }
        public List<Verificacion> wwwObtenerVerificaciones()
        {
            verificacionesTableAdapter.Fill(restaurantedataset.Verificaciones);
            FillVerificaciones();
            return _verificacionLista;
        }

        public bool InsertarVerificacion(Verificacion verificacion)
        {
            try
            {
                verificacionesTableAdapter.Insert(
                    verificacion.Codigo,
                    verificacion.Descripcion,
                    verificacion.Estado
                );
                verificacionesTableAdapter.Fill(restaurantedataset.Verificaciones);
                this.FillVerificaciones();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se agrego correctamente -classVerificaciones");
                return false;
            }
        }

        public bool ActualizarVerificacion(Verificacion updateTo, Verificacion updatedFrom)
        {
            try
            {
                verificacionesTableAdapter.Update(
                    updateTo.Codigo,
                    updateTo.Descripcion,
                    updateTo.Estado,
                    updateTo.VerificacionID,
                    updatedFrom.Codigo,
                    updatedFrom.Descripcion,
                    updatedFrom.Estado,
                    updatedFrom.VerificacionID
                );
                verificacionesTableAdapter.Fill(restaurantedataset.Verificaciones);
                this.FillVerificaciones();
                return true;
            }
            catch (Exception ex)
            {
                // Puedes agregar un log o mostrar el mensaje de error
                Console.WriteLine("No se actualizo correctamente -classVerificaciones");
                return false;
            }
        }

        public bool EliminarVerificacion(Verificacion verificacion)
        {
            try
            {
                verificacionesTableAdapter.Delete(
                    verificacion.VerificacionID,
                    verificacion.Codigo,
                    verificacion.Descripcion,
                    verificacion.Estado
                    );
                verificacionesTableAdapter.Fill(restaurantedataset.Verificaciones);
                this.FillVerificaciones();
                return true;
            }
            catch
            {
                return false;
            }
        }
       
        private void FillVerificaciones()
        {
            _verificacionLista.Clear();
            foreach (RestauranteDataSet.VerificacionesRow _verificaciones in restaurantedataset.Verificaciones.Rows)
            {
                _verificacionLista.Add(new Verificacion(
                        _verificaciones.verificacionID,
                        _verificaciones.verificacion,
                        _verificaciones.name,
                        _verificaciones.status
                    )
                );
            }
        }
    }
}
