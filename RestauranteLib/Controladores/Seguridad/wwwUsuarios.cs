using DocumentFormat.OpenXml.Spreadsheet;
using RestauranteDAO;
using RestauranteDAO.RestauranteDataSetTableAdapters;
using RestauranteLib.Seguridad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteLib.Controladores.Seguridad
{
    public class wwwUsuarios
    {
        private UsuariosTableAdapter usuariosTableAdapter;
        private wwwRoles rolesController;
        private wwwVerificaciones verificacionesController;
        private RolesXUsuarioTableAdapter rolesXUsuarioTA;

        private RestauranteDataSet restaurantedataset;
        private List<Usuario> _usuarioLista;


        public wwwUsuarios()
        {
            usuariosTableAdapter = new UsuariosTableAdapter();
            rolesController = new wwwRoles();
            verificacionesController = new wwwVerificaciones();
            rolesXUsuarioTA = new RolesXUsuarioTableAdapter();

            restaurantedataset = RestauranteDAO.Contexto.GetDataSet();
            _usuarioLista = new List<Usuario>();

        }
        public int agregarUsuario(Usuario user)
        {
            // Generating Password hash
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

        public void actualizarUsuario(Usuario user, Usuario original)
        {
            byte[] passwordSaltBytes;
            string passwordHash = PasswordUtility.hashPassword(user.Password, out passwordSaltBytes);
            string passwordSalt = Convert.ToHexString(passwordSaltBytes);
            string password = passwordSalt + passwordHash;
            usuariosTableAdapter.Update(
                user.User, 
                password, 
                user.PasswordExpires, 
                user.Name, 
                user.Estado, original.ID, original.User, original.Password, original.PasswordExpires, original.Name, original.Estado);
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

        public List<Usuario> GetUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            foreach (var usuario in usuariosTableAdapter.GetData())
            {
                Usuario nusuario = new Usuario(
                    usuario.Id,
                    usuario.user,
                    usuario.password,
                    usuario.passwordFchExp,
                    usuario.password.Substring(0, 128),
                    usuario.password.Substring(128, 128),
                    usuario.name,
                    usuario.status
                );
                usuarios.Add(nusuario);
            }
            return usuarios;
        }

        public Usuario? GetUsuario(string user)
        {
            Debug.WriteLine(user);
            var usuarioRow = usuariosTableAdapter.GetDataByUser(user).FirstOrDefault();
            Debug.WriteLine(usuarioRow);
            if (usuarioRow != null)
            {
                return new Usuario(
                        usuarioRow.Id,
                        usuarioRow.user,
                        usuarioRow.password,
                        usuarioRow.passwordFchExp,
                        usuarioRow.password.Substring(0, 128),
                        usuarioRow.password.Substring(128, 128),
                        usuarioRow.name,
                        usuarioRow.status
                    );
            }
            return null;
        }

        public void updatePassword(string user, string newPassword)
        {
            byte[] passwordSaltBytes;
            string passwordHash = PasswordUtility.hashPassword(newPassword, out passwordSaltBytes);
            string passwordSalt = Convert.ToHexString(passwordSaltBytes);
            string password = passwordSalt + passwordHash;
            //usuariosTableAdapter.UpdatePassword(password, DateTime.Now.AddDays(90), Id);
        }

        public void VerificarSeguridad()
        {
            Debug.WriteLine("Entrando a Verificar Seguridad");


            int? cantidadUsuarios = usuariosTableAdapter.ContarUsuarios();
            if (cantidadUsuarios == null || cantidadUsuarios == 1)
            {
                Debug.WriteLine("Creando Usuario Administrador");
                Usuario newUserAdmin = new Usuario();
                newUserAdmin.User = "admin";
                newUserAdmin.Password = "Admin1029";
                newUserAdmin.PasswordExpires = DateTime.Now.AddDays(360);
                newUserAdmin.Name = "Administrador";
                newUserAdmin.Estado = ECommonStatus.ACT;
                int result = this.agregarUsuario(newUserAdmin);
                if (result < 1)
                {
                    throw new Exception("No se pudo insertar Usuario");
                }
                Usuario? contextUser = this.GetUsuario(newUserAdmin.User);
                if (contextUser == null)
                {
                    throw new Exception("No se pudo obtener usuario");
                }

                Debug.WriteLine("Creando Roles Predeterminados");

                Rol rolAdministrador = new Rol(1, "admin", ECommonStatus.ACT, DateTime.Now);
                Rol rolUsuario = new Rol(2, "basico", ECommonStatus.ACT, DateTime.Now);
                Rol rolAuditor = new Rol(3, "auditor", ECommonStatus.ACT, DateTime.Now);

                rolesController.InsertarRol(rolAdministrador);
                rolesController.InsertarRol(rolUsuario);
                rolesController.InsertarRol(rolAuditor);

                Debug.WriteLine("Creando Verificaciones Predeterminadas");

                Verificacion verificacionMnuReservas = new Verificacion(1, "MnuReservas", "Menu de Reservas", ECommonStatus.ACT);
                Verificacion verificacionMnuRoles = new Verificacion(2, "MnuRoles", "Menu de Roles", ECommonStatus.ACT);
                Verificacion verificacionMnuUsuarios = new Verificacion(3, "MnuUsuarios", "Menu de Usuarios", ECommonStatus.ACT);
                Verificacion verificacionMnuVerificaciones = new Verificacion(4, "MnuVerificaciones", "Menu de Verificaciones", ECommonStatus.ACT);
                Verificacion verificacionMnuClientes = new Verificacion(5, "MnuClientes", "Menu de Clientes", ECommonStatus.ACT);

                verificacionesController.InsertarVerificacion(verificacionMnuReservas);
                verificacionesController.InsertarVerificacion(verificacionMnuRoles);
                verificacionesController.InsertarVerificacion(verificacionMnuUsuarios);
                verificacionesController.InsertarVerificacion(verificacionMnuVerificaciones);
                verificacionesController.InsertarVerificacion(verificacionMnuClientes);

                Debug.WriteLine("Asignando Roles a Usuario Administrador");
                rolesXUsuarioTA.Insert(contextUser.ID, 
                    rolAdministrador.RolName, 
                    DateTime.Now.AddDays(360), 
                    ECommonStatus.ACT);

                Debug.WriteLine("Asignando Verificaciones a Rol Administrador");
                rolesController.AgregarVerificacionARol(rolAdministrador, verificacionMnuReservas);
                rolesController.AgregarVerificacionARol(rolAdministrador, verificacionMnuRoles);
                rolesController.AgregarVerificacionARol(rolAdministrador, verificacionMnuUsuarios);
                rolesController.AgregarVerificacionARol(rolAdministrador, verificacionMnuVerificaciones);
                rolesController.AgregarVerificacionARol(rolAdministrador, verificacionMnuClientes);
            }
            else
            {
                Rol? rolAdmin = rolesController.ObtenerRol("admin");
                if (rolAdmin == null)
                {
                    rolAdmin = new Rol(1, "admin", ECommonStatus.ACT, DateTime.Now);
                    rolesController.InsertarRol(rolAdmin);
                }
                // Verificar si el rol admin existe, si no, crearlo
                Rol? rolUser = rolesController.ObtenerRol("user");
                if (rolUser == null)
                {
                    rolUser = new Rol(2, "user", ECommonStatus.ACT, DateTime.Now);
                    rolesController.InsertarRol(rolUser);
                }
                Debug.WriteLine("Usuarios y roles existentes, no es necesario crear nuevos.");
            }
        }



        public bool IsAuthorized(int userId, string verificacion)
        {
            if (usuariosTableAdapter == null)
            {
                throw new Exception("usuariosTableAdapter no está inicializado.");
            }

            try
            {
                var result = (int?)usuariosTableAdapter.IsAuthorized(userId, verificacion);
                return result.HasValue && result == 1;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar autorización del usuario.", ex);
            }
        }
        public Usuario? Login(string user, string password)
        {
            Usuario? usuario = GetUsuario(user);

            if (usuario != null)
            {
                if (PasswordUtility.comparePassword(password, usuario.PasswordHash, Convert.FromHexString(usuario.PasswordSalt)))
                {
                    return usuario;
                }

                if (password == usuario.Password) 
                {
                    // Usuario y contraseña correctos
                    Debug.WriteLine($"Login exitoso para el usuario: {user}");
                    return usuario;
                }
                else
                {
                    // Contraseña incorrecta
                    Debug.WriteLine($"Contraseña incorrecta para el usuario: {user}");
                }
            }
            else
            {
                // Usuario no encontrado
                Debug.WriteLine($"No se encontró el usuario: {user}");
            }
            return null;
        }

        public void SaveUserToDatabase(Usuario usuario)
        {
            if (usuario.ID == 0) 
            {
                usuariosTableAdapter.Insert(
                    usuario.User,
                    usuario.Password,
                    usuario.PasswordExpires,
                    usuario.Name,
                    usuario.Estado
                );
            }
            else 
            {
                usuariosTableAdapter.Update(
                    usuario.User,
                    usuario.Password,
                    usuario.PasswordExpires,
                    usuario.Name,
                    usuario.Estado,
                    usuario.ID,
                    usuario.User,
                    usuario.Password,
                    usuario.PasswordExpires,
                    usuario.Name,
                    usuario.Estado
                   
                );
            }
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
                        usuarioRow.password.Substring(0, 128),
                        usuarioRow.password.Substring(128, 128),
                        usuarioRow.name,
                        usuarioRow.status
                    )
                );
            }
        }

    }
}
