using RestauranteDAO.RestauranteDataSetTableAdapters;
using RestauranteDAO;
using RestauranteLib.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteLib.Controladores.Seguridad
{
    public class wwwRoles
    {
        private RestauranteDataSet restaurantedataset;
        private RolesTableAdapter rolesTableAdapter;
        private List<Rol> _rolLista;

        public wwwRoles()
        {
            restaurantedataset = new RestauranteDataSet();
            rolesTableAdapter = new RolesTableAdapter();
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






    }
}

