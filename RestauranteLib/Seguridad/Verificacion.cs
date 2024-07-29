using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteLib.Seguridad
{
    public class Verificacion
    {

        private string estado;
        private int verificacionID;
        public string Codigo { get; set; }
        public string Descripcion { get; set; }

        public string Estado{get => estado; set{if (value == ECommonStatus.ACT || value == ECommonStatus.INA){this.estado = value;}else{throw new Exception("Estado no valido");}}}

        public int VerificacionID { get => verificacionID; set => verificacionID = value; }
       // public string Estado { get => estado; set => estado = value; }

        public Verificacion()
        {
            VerificacionID = 0;

            Codigo = "";
            Descripcion = "";
            Estado = ECommonStatus.ACT;
        }
        public Verificacion(int verificacionID, string codigo, string descripcion, string estado)
        {
            VerificacionID = verificacionID;

            Codigo = codigo;
            Descripcion = descripcion;
            Estado = estado;
        }
    }
}
