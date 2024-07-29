using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteLib.Seguridad
{
    public class Rol
    {
        private int rolId;
        private string rolName;
        private string estado;
        private DateTime rolCreacion;
        

        public string Estado
        {
            get => estado; set
            {
                if (value == ECommonStatus.ACT || value == ECommonStatus.INA)
                {
                    this.estado = value;
                }
                else
                {
                    throw new Exception("Estado no valido");
                }
            }
        }

        public int RolId { get => rolId; set => rolId = value; }
        public DateTime RolCreacion { get => rolCreacion; set => rolCreacion = value; }
        public string RolName { get => rolName; set => rolName = value; }

        public Rol()
        {
            RolId = 0;
            RolName = "";
            Estado = ECommonStatus.ACT;
            RolCreacion = DateTime.Now;
        }
        public Rol(int rolId, string name, string estado, DateTime rolCreacion)
        {
            RolId = rolId; 
            RolName = name;
            Estado = estado;
            RolCreacion = rolCreacion;
        }
    }
}
