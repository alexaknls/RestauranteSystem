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
            private List<Rol> _rolesLista;

            public wwwRoles()
            {
                _rolesLista = new List<Rol>();
                rolesTableAdapter = new RolesTableAdapter();
                restaurantedataset = RestauranteDAO.Contexto.GetDataSet();
            }
           
        public List<Rol> wwwObtenerRol()
            {
                rolesTableAdapter.Fill(restaurantedataset.Roles);
                FillRoles();
                return _rolesLista;
            }

            public bool InsertarRol(Rol _rol)
            {
                try
                {
                    rolesTableAdapter.Insert(
                        _rol.RolId,
                        _rol.RolName,
                        _rol.Estado,
                        _rol.RolCreacion
                    );
                    rolesTableAdapter.Fill(restaurantedataset.Roles);
                    this.FillRoles();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("No se agrego correctamente");
                    return false;
                }
            }

            public bool ActualizarRoles(Rol updateTo, Rol updatedFrom)
            {
                try
                {
                    rolesTableAdapter.Update(
                        updateTo.RolId,
                        updateTo.RolName,
                        updateTo.Estado,
                        updateTo.RolCreacion,
                        updatedFrom.RolId,
                        updatedFrom.RolName,
                        updatedFrom.Estado,
                        updatedFrom.RolCreacion
                    );
                    rolesTableAdapter.Fill(restaurantedataset.Roles);
                    this.FillRoles();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("No se actualizo correctamente");
                    return false;
                }
            }

            public bool EliminarRoles(Rol _rol)
            {
                try
                {
                    rolesTableAdapter.Delete(
                        _rol.RolId,
                        _rol.RolName,
                        _rol.Estado,
                        _rol.RolCreacion
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
                _rolesLista.Clear();
                foreach (RestauranteDataSet.RolesRow _rol in restaurantedataset.Roles.Rows)
                {
                    _rolesLista.Add(new Rol(
                            _rol.RolID,
                            _rol.RolName,
                            _rol.RolEstado,
                            _rol.RolCreacion
                        )
                    );
                }
            }
        }
}

