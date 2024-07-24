using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RestauranteDAO
{
    public class Contexto
    {
        private static RestauranteDataSet dataSet;
        public static RestauranteDataSet GetDataSet()
        {
            if (dataSet == null)
            {
                dataSet = new RestauranteDataSet();
            }
            return dataSet;
        }

        private Contexto()
        {
            dataSet = new RestauranteDataSet();
        }
    }
}

