namespace RestauranteLib
{
    public class ReservasLib
    {
        private int _reservaID;
        private DateOnly _reservaDate;
        private TimeOnly _reservaTime;
        private int _personasCant;
        private int _numeroMesa;
        private string _reservaEstado;
        private DateTime _reservaCreacion;

        public int ReservaID { get => _reservaID; set => _reservaID = value; }
        public DateOnly ReservaDate { get => _reservaDate; set => _reservaDate = value; }
        public TimeOnly ReservaTime { get => _reservaTime; set => _reservaTime = value; }
        public int ClienteID { get => _clienteID; set => _clienteID = value; }
        public int PersonasCant { get => _personasCant; set => _personasCant = value; }
        public int NumeroMesa { get => _numeroMesa; set => _numeroMesa = value; }
        public string ReservaEstado { get => _reservaEstado; set => _reservaEstado = value; }
        public DateTime ReservaCreacion { get => _reservaCreacion; set => _reservaCreacion = value; }

        public ReservasLib()
        {
            ReservaID = 0;
            ReservaDate = DateOnly.MinValue;
            ReservaTime = TimeOnly.MinValue;
            PersonasCant = 0;
            NumeroMesa = 0;
            ReservaEstado = "";
            ReservaCreacion = DateTime.MinValue;
        }

        public ReservasLib(
            int reservaID,
            DateOnly reservaDate,
            TimeOnly reservaTime,
            int personasCant,
            int numeroMesa,
            string reservaEstado,
            DateTime reservaCreacion
            )
        {
            ReservaID = reservaID;
            ReservaDate = reservaDate;
            ReservaTime = reservaTime;
            PersonasCant = personasCant;
            NumeroMesa = numeroMesa;
            _reservaEstado = reservaEstado;
            ReservaCreacion = reservaCreacion;
        }
    }
}
