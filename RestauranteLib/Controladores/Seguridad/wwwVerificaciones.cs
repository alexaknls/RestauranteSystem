using RestauranteDAO;
using RestauranteDAO.RestauranteDataSetTableAdapters;
using RestauranteLib.Seguridad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;

namespace RestauranteLib.Controladores.Seguridad
{
    public class wwwVerificaciones
    {
        private RestauranteDataSet restaurantedataset;
        private VerificacionesTableAdapter verificacionesTableAdapter;
        private List<Verificacion> _verificacionLista;

        public wwwVerificaciones()
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
        public Verificacion? ObtenerVerificacion(string byverificacion)
        {
            try
            {
                // Asegúrate de que el parámetro y método están configurados correctamente
                var verificacionDataTable = verificacionesTableAdapter.GetDataBy(byverificacion);

                // Obtén la primera fila o null si no se encuentra
                var verificacionRow = verificacionDataTable.Rows.Cast<DataRow>().FirstOrDefault();

                if (verificacionRow != null)
                {
                    // Crea y devuelve el objeto Verificacion
                    return new Verificacion
                    {
                        VerificacionID = Convert.ToInt32(verificacionRow["verificacionID"]),
                        Codigo = verificacionRow["verificacion"].ToString(),
                        Descripcion = verificacionRow["name"].ToString(),
                        Estado = verificacionRow["status"].ToString()
                    };
                }
                else
                {
                    Debug.WriteLine($"Verificación no encontrada: {byverificacion}");
                    return null;
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                Debug.WriteLine($"Error al obtener la verificación: {ex.Message}");
                return null;
            }
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
