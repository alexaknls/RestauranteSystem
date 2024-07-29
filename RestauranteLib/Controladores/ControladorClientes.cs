using RestauranteDAO;
using RestauranteDAO.RestauranteDataSetTableAdapters;
using RestauranteLib;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RestauranteDAO.RestauranteDataSet;
using System.Runtime.CompilerServices;
using System.Data;
using DocumentFormat.OpenXml.InkML;
namespace RestauranteLib.Controladores
{
    public class ControladorClientes
    {
        private RestauranteDataSet restauranteDataSet;
        private ClientesTableAdapter _adaptercli;
        private List<Clienteslib> _Clienteslis;
        public ControladorClientes()
        {
            restauranteDataSet = RestauranteDAO.Contexto.GetDataSet();
            _adaptercli = new ClientesTableAdapter();
        }
       

    }


}
