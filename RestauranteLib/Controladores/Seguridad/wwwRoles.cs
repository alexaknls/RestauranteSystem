using RestauranteDAO.RestauranteDataSetTableAdapters;
using RestauranteDAO;
using RestauranteLib.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace RestauranteLib.Controladores.Seguridad
{
    public class wwwRoles
    {
        private RestauranteDataSet restaurantedataset;
        private RolesTableAdapter rolesTableAdapter;
        private List<Rol> _rolLista;
        private VerificacionesXRolTableAdapter rolesVerificacionesTableAdapter;

        public wwwRoles()
        {
            restaurantedataset = new RestauranteDataSet();
            rolesTableAdapter = new RolesTableAdapter();
            rolesVerificacionesTableAdapter = new VerificacionesXRolTableAdapter();
            _rolLista = new List<Rol>();
        }

        public List<Rol> ObtenerRoles()
        {
            List<Rol> roles = new List<Rol>();
            foreach (var rol in rolesTableAdapter.GetData())
            {
                roles.Add(new Rol(rol.RolID, rol.RolName, rol.RolEstado, rol.RolCreacion));
            }
            return roles;
        }
        public Rol? ObtenerRol(string codigo)
        {
            var rol = rolesTableAdapter.GetDataByRolName(codigo).FirstOrDefault();
            if (rol == null)
            {
                return null;
            }
            return new Rol(rol.RolID ,rol.RolName, rol.RolEstado, rol.RolCreacion);
        }
        public bool InsertarRol(Rol rol)
        {
            try
            {
                rolesTableAdapter.Insert(
                    rol.RolId,
                    rol.RolName,
                    rol.Estado,
                    rol.RolCreacion
                );
                rolesTableAdapter.Fill(restaurantedataset.Roles);
                this.FillRoles();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool ActualizarRol(Rol rolActualizado, Rol rolOriginal)
        {
            try
            {
                rolesTableAdapter.Update(
                    rolActualizado.RolId,
                    rolActualizado.RolName,
                    rolActualizado.Estado,
                    rolActualizado.RolCreacion,
                    rolOriginal.RolId,
                    rolOriginal.RolName,
                    rolOriginal.Estado,
                    rolOriginal.RolCreacion
                );
                rolesTableAdapter.Fill(restaurantedataset.Roles);
                this.FillRoles();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool EliminarRol(Rol rol)
        {
            try
            {
                rolesTableAdapter.Delete(
                    rol.RolId,
                    rol.RolName,
                    rol.Estado,
                    rol.RolCreacion
                );
                rolesTableAdapter.Fill(restaurantedataset.Roles);
                this.FillRoles();
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void FillRoles()
        {
            _rolLista.Clear();
            foreach (RestauranteDataSet.RolesRow rol in restaurantedataset.Roles.Rows)
            {
                _rolLista.Add(new Rol(
                    rol.RolID,
                    rol.RolName,
                    rol.RolEstado,
                    rol.RolCreacion
                ));
            }
        }

        public void AgregarVerificacionARol(Rol rol, Verificacion verificacion)
        {
            if (rol == null)
            {
                throw new Exception("El rol no puede ser nulo");
            }
            if (verificacion == null)
            {
                throw new Exception("La verificacion no puede ser nula");
            }

            var existingEntry = rolesVerificacionesTableAdapter.GetDataBy(rol.RolName, verificacion.VerificacionID);
            if (existingEntry.Rows.Count > 0)
            {
                // Actualizar la verificación existente
                rolesVerificacionesTableAdapter.Update(
                    rol.RolName,
                    verificacion.Codigo,
                    DateTime.Now.AddDays(360),
                    ECommonStatus.ACT,
                    rol.RolName,
                    verificacion.Codigo,
                    DateTime.Now.AddDays(360),
                    ECommonStatus.ACT
                );
            }
            else
            {
                // Insertar nueva verificación
                rolesVerificacionesTableAdapter.Insert(
                    rol.RolName,
                    verificacion.Codigo,
                    DateTime.Now.AddDays(360),
                    ECommonStatus.ACT
                );
            }
        }






    }
}

