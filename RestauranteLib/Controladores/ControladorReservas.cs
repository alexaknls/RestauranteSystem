using RestauranteDAO;
using RestauranteDAO.RestauranteDataSetTableAdapters;
using RestauranteLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RestauranteDAO.RestauranteDataSet;

namespace RestauranteLib.Controladores
{
    public class ControladorReservas
    {
        private RestauranteDataSet restauranteDataSet;
        private ReservasTableAdapter reservasAdapter;

        public ControladorReservas()
        {
            restauranteDataSet = RestauranteDAO.Contexto.GetDataSet();
            reservasAdapter = new ReservasTableAdapter();
        }

        public List<ReservasLib> ObtenerReservas()
        {
            List<ReservasLib> _reservaLista = new List<ReservasLib>();
            reservasAdapter.Fill(restauranteDataSet.Reservas);
            foreach (RestauranteDataSet.ReservasRow reservasRow in restauranteDataSet.Reservas)
            {
                ReservasLib reservasItem = new ReservasLib(
                        reservasRow.ReservaID,
                        reservasRow.ReservaDateTime,
                        reservasRow.PersonasCant,
                        reservasRow.NumeroMesa,
                        reservasRow.ReservaEstado,
                        reservasRow.ReservaCreacion
                    );
                _reservaLista.Add( reservasItem );
            }
            return _reservaLista;
        }
        
        public ReservasLib ObtenerReservas(int id)
        {
            ReservasLib reservas = null;
            reservasAdapter.FillBy(restauranteDataSet.Reservas, id);
            RestauranteDataSet.ReservasRow _reservasRow = restauranteDataSet.Reservas.FirstOrDefault(); 
            if (_reservasRow != null)
            {
                reservas = new ReservasLib(
                    _reservasRow.ReservaID,
                    _reservasRow.ReservaDateTime,
                    _reservasRow.PersonasCant,
                    _reservasRow.NumeroMesa,
                    _reservasRow.ReservaEstado,
                    _reservasRow.ReservaCreacion
                    );
            }
            return reservas;
        }
    }
}
