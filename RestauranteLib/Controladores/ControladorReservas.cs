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

namespace RestauranteLib.Controladores
{
    public class ControladorReservas
    {
        private RestauranteDataSet restauranteDataSet;
        private ReservasTableAdapter _adapter;

        public ControladorReservas()
        {
            restauranteDataSet = RestauranteDAO.Contexto.GetDataSet();
            _adapter = new ReservasTableAdapter();
        }

        public List<ReservasLib> ObtenerReservas()
        {
            List<ReservasLib> _reservaLista = new List<ReservasLib>();

            _adapter.Fill(restauranteDataSet.Reservas);
            foreach (RestauranteDataSet.ReservasRow reservasRow in restauranteDataSet.Reservas)
            {
                string reservasCodigo = reservasRow.IsReservaCodigoNull() ? string.Empty : reservasRow.ReservaCodigo;

                ReservasLib reservasItem = new ReservasLib(
                        reservasRow.ReservaID,
                        reservasCodigo,
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
            _adapter.FillBy(restauranteDataSet.Reservas, id);
            RestauranteDataSet.ReservasRow _reservasRow = restauranteDataSet.Reservas.FirstOrDefault(); 

            if (_reservasRow != null)
            {
                string reservasCodigo = _reservasRow.IsReservaCodigoNull() ? string.Empty : _reservasRow.ReservaCodigo;
                reservas = new ReservasLib(
                    _reservasRow.ReservaID,
                    reservasCodigo,
                    _reservasRow.ReservaDateTime,
                    _reservasRow.PersonasCant,
                    _reservasRow.NumeroMesa,
                    _reservasRow.ReservaEstado,
                    _reservasRow.ReservaCreacion
                    );
            }
            return reservas;
        }

        public void AgregarReserva(ReservasLib reservas)
        {
            int result = _adapter.Insert(
                    reservas.ReservaCodigo,
                    reservas.ReservaDateTime,
                    reservas.PersonasCant,
                    reservas.NumeroMesa,
                    reservas.ReservaEstado,
                    reservas.ReservaCreacion
                );
            _adapter.Fill(restauranteDataSet.Reservas);
        }

        public string GeneradordeCodigoReserva()
        {
            string fechaHoraReserva = DateTime.Now.ToString("yyyyMMddHHmmss");
            string numeroAleatorio = new Random().Next(1000, 9999).ToString();
            string codigoGeneradoReserva = $"RES-{fechaHoraReserva}-{numeroAleatorio}";

            return codigoGeneradoReserva;
        }
    }
}
