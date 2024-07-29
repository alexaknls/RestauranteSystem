using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteLib
{
    public class MesasMenu
    {
        public int NumeroMesa { get; set; }
        public DateTime FechaYHora { get; set; }

        public MesasMenu(int numeroMesa, DateTime fechaYHora)
        {
            NumeroMesa = numeroMesa;
            FechaYHora = fechaYHora;
        }
    }
}
