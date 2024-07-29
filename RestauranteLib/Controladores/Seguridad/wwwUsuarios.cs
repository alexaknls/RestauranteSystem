using DocumentFormat.OpenXml.Spreadsheet;
using RestauranteDAO;
using RestauranteDAO.RestauranteDataSetTableAdapters;
using RestauranteLib.Seguridad;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteLib.Controladores.Seguridad
{
    public class wwwUsuarios
    {
        private RestauranteDataSet restaurantedataset;
        private UsuariosTableAdapter usuariosTableAdapter;
        private List<Usuario> _usuarioLista;

        public wwwUsuarios()
        {
            _usuarioLista = new List<Usuario>();
            usuariosTableAdapter = new UsuariosTableAdapter();
            restaurantedataset = RestauranteDAO.Contexto.GetDataSet();
        }
        public int agregarUsuario(Usuario user)
        {
            byte[] passwordSaltBytes;
            string passwordHash = PasswordUtility.hashPassword(user.Password, out passwordSaltBytes);
            string passwordSalt = Convert.ToHexString(passwordSaltBytes);
            string password = passwordSalt + passwordHash;

            return usuariosTableAdapter.Insert(
                user.User,
                password,
                DateTime.Now.AddDays(90),
                user.Name,
                user.Estado
            );
        }

        public bool actualizarUsuario(Usuario updateTo, Usuario updatedFrom)
        {
            byte[] passwordSaltBytes;
            string passwordHash = PasswordUtility.hashPassword(updateTo.Password, out passwordSaltBytes);
            string passwordSalt = Convert.ToHexString(passwordSaltBytes);
            string password = passwordSalt + passwordHash;

            try
            {
                usuariosTableAdapter.Update(
                    updateTo.User,
                    password,
                    updateTo.PasswordExpires,
                    updateTo.Name,
                    updateTo.Estado,
                    updateTo.ID,
                    updatedFrom.User,
                    updatedFrom.Password,
                    updatedFrom.PasswordExpires,
                    updatedFrom.Name,
                    updatedFrom.Estado,
                    updatedFrom.ID
                );
                usuariosTableAdapter.Fill(restaurantedataset.Usuarios);
                this.FillUsuarios();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool eliminarUsuario(Usuario user)
        {
            try
            {
                usuariosTableAdapter.Delete(
                    user.ID,
                    user.User,
                    user.Password,
                    user.PasswordExpires,
                    user.Name,
                    user.Estado
                );
                usuariosTableAdapter.Fill(restaurantedataset.Usuarios);
                this.FillUsuarios();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Usuario> obtenerUsuarios()
        {
            usuariosTableAdapter.Fill(restaurantedataset.Usuarios);
            FillUsuarios();
            return _usuarioLista;
        }

        public Usuario? obtenerUsuario(string username)
        {
            var usuario = usuariosTableAdapter.GetDataByUser(username).FirstOrDefault();
            if (usuario == null)
            {
                return null;
            }
            return new Usuario(
                usuario.Id,
                usuario.user,
                usuario.password,
                usuario.passwordFchExp,
                usuario.name,
                usuario.status
            );
        }

        private void FillUsuarios()
        {
            _usuarioLista.Clear();
            foreach (RestauranteDataSet.UsuariosRow usuarioRow in restaurantedataset.Usuarios.Rows)
            {
                _usuarioLista.Add(new Usuario(
                        usuarioRow.Id,
                        usuarioRow.user,
                        usuarioRow.password,
                        usuarioRow.passwordFchExp,
                        usuarioRow.name,
                        usuarioRow.status
                    )
                );
            }
        }

    }
}
