using RestauranteDAO;
using RestauranteDAO.RestauranteDataSetTableAdapters;
using RestauranteLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                DateTime reservaDateTime = reservasRow.ReservaDateTime.Add(reservasRow.ReservaDateTime.TimeOfDay);
                ReservasLib reservasItem = new ReservasLib(
                        reservasRow.ReservaID,
                        reservaDateTime,
                        reservasRow.PersonasCant,
                        reservasRow.NumeroMesa,
                        reservasRow.ReservaEstado,
                        reservasRow.ReservaCreacion
                    );
                _reservaLista.Add( reservasItem );
            }
            return _reservaLista;
        }

    }
}
