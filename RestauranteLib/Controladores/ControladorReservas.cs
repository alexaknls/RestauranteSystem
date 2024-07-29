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
using DocumentFormat.OpenXml.Office2010.Excel;

namespace RestauranteLib.Controladores
{
    public class ControladorReservas
    {
        private RestauranteDataSet restauranteDataSet;
        private ReservasTableAdapter _adapter;
        private List<ReservasLib> _reservas;

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
                string reservasCedulaCliente = reservasRow.IsReservaClienteNull() ? string.Empty : reservasRow.ReservaCliente;

                ReservasLib reservasItem = new ReservasLib(
                        reservasRow.ReservaID,
                        reservasCodigo,
                        reservasRow.ReservaDateTime,
                        reservasRow.PersonasCant,
                        reservasRow.NumeroMesa,
                        reservasRow.ReservaEstado,
                        reservasRow.ReservaCreacion,
                        reservasCedulaCliente 
                    );
                _reservaLista.Add( reservasItem );
            }
            return _reservaLista;
        }
        
        public ReservasLib ObtenerReservas(int id)
        {
            ReservasLib reservas = null;
            _adapter.FillByReservas(restauranteDataSet.Reservas, id);
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
                    _reservasRow.ReservaCreacion,
                    _reservasRow.ReservaCliente
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
                    reservas.ReservaCreacion,
                    reservas.ReservaCliente
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

        public List<ReservasLib> BuscarReservasPorCedula(string cedula)
        {
            List<ReservasLib> _reservaLista = new List<ReservasLib>();


            _adapter.FillByClienteCedula(restauranteDataSet.Reservas, cedula);

            foreach (RestauranteDataSet.ReservasRow reservasRow in restauranteDataSet.Reservas)
            {
                ReservasLib reservasItem = new ReservasLib(
                    reservasRow.ReservaID,
                    reservasRow.ReservaCodigo,
                    reservasRow.ReservaDateTime,
                    reservasRow.PersonasCant,
                    reservasRow.NumeroMesa,
                    reservasRow.ReservaEstado,
                    reservasRow.ReservaCreacion,
                    reservasRow.ReservaCliente
                );
                _reservaLista.Add(reservasItem);
            }
            return _reservaLista;
        }

        public Boolean EditarReserva(ReservasLib reservas, ReservasLib originalReserva)
        {
            try 
            {
                _adapter.Update
                    (
                        reservas.ReservaCodigo,
                        reservas.ReservaDateTime,
                        reservas.PersonasCant,
                        reservas.NumeroMesa,
                        reservas.ReservaEstado, 
                        reservas.ReservaCreacion,
                        reservas.ReservaCliente,
                        originalReserva.ReservaID,
                        originalReserva.ReservaCodigo,
                        originalReserva.ReservaDateTime,
                        originalReserva.PersonasCant,
                        originalReserva.NumeroMesa,
                        originalReserva.ReservaEstado,
                        originalReserva.ReservaCreacion,
                        originalReserva.ReservaCliente
                    );
                _adapter.Fill(restauranteDataSet.Reservas);
                return true;
            } catch (Exception e)
            {
                return false;
            }
        }

        public Boolean EliminarReserva(ReservasLib reservas)
        {
            try
            {
                _adapter.Delete(
                    reservas.ReservaID,
                    reservas.ReservaCodigo,
                    reservas.ReservaDateTime,
                    reservas.PersonasCant,
                    reservas.NumeroMesa,
                    reservas.ReservaEstado,
                    reservas.ReservaCreacion,
                    reservas.ReservaCliente
                 );
                _adapter.Fill(restauranteDataSet.Reservas);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Dictionary<int, List<ReservasLib>> ObtenerMesasOcupadas(DateTime fechaHora)
        {
            var mesasOcupadas = new Dictionary<int, List<ReservasLib>>();

            _adapter.GetByMesasOcupadas(fechaHora);
            foreach (RestauranteDataSet.ReservasRow reservasRow in restauranteDataSet.Reservas)
            {
                string reservasCodigo = reservasRow.IsReservaCodigoNull() ? string.Empty : reservasRow.ReservaCodigo;
                string reservasCedulaCliente = reservasRow.IsReservaClienteNull() ? string.Empty : reservasRow.ReservaCliente;

                var reserva = new ReservasLib(
                    reservasRow.ReservaID,
                    reservasCodigo,
                    reservasRow.ReservaDateTime,
                    reservasRow.PersonasCant,
                    reservasRow.NumeroMesa,
                    reservasRow.ReservaEstado,
                    reservasRow.ReservaCreacion,
                    reservasCedulaCliente
                );

                if (!mesasOcupadas.ContainsKey(reserva.NumeroMesa))
                {
                    mesasOcupadas[reserva.NumeroMesa] = new List<ReservasLib>();
                }

                mesasOcupadas[reserva.NumeroMesa].Add(reserva);
            }

            return mesasOcupadas;
        }










    }
}

