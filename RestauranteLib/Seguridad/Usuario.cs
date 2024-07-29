using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteLib.Seguridad
{
    public class Usuario
    {
        private string status;
        public int ID { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public DateTime PasswordExpires { get; set; }
        public string Name { get; set; }

        public string Estado
        {
            get => status;
            set
            {
                if (value == ECommonStatus.ACT || value == ECommonStatus.INA)
                {
                    status = value;
                }
                else
                {
                    throw new Exception("Estado no es Valido");
                }
            }
        }
        public Usuario()
        {
            ID = 0;
            User = "";
            Password = "";
            PasswordExpires = DateTime.Now.AddDays(30);
            Name = "";
            Estado = ECommonStatus.ACT;
        }
        public Usuario(int id, string user, string password, DateTime passwordExpires, string name, string estado)
        {
            ID = id;
            User = user;
            Password = password;
            PasswordExpires = passwordExpires;
            Name = name;
            Estado = estado;
        }
    }
}
