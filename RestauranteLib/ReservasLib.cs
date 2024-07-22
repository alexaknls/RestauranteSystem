namespace RestauranteLib
{
    public class ReservasLib
    {
        private int _reservaID;
        private DateOnly _reservaDate;
        private TimeOnly _reservaTime;
        private int _clienteID;
        private int _personasCant;
        private int _numeroMesa;
        private string _reservaEstado;

        public int ReservaID { get => _reservaID; set => _reservaID = value; }
        public DateOnly ReservaDate { get => _reservaDate; set => _reservaDate = value; }
        public TimeOnly ReservaTime { get => _reservaTime; set => _reservaTime = value; }
        public int ClienteID { get => _clienteID; set => _clienteID = value; }
        public int PersonasCant { get => _personasCant; set => _personasCant = value; }
        public int NumeroMesa { get => _numeroMesa; set => _numeroMesa = value; }
        public string ReservaEstado { get => _reservaEstado; set => _reservaEstado = value; }

        public ReservasLib()
        {
            ReservaID = 0;
            ClienteID = 0;
            PersonasCant = 0;
            NumeroMesa = 0;
            _reservaEstado = "";
        }

        public ReservasLib(
            int reservaID,
            DateOnly reservaDate,
            TimeOnly reservaTime,
            int clienteID,
            int personasCant,
            int numeroMesa,
            string reservaEstado
            )
        {
            ReservaID = reservaID;
            ReservaDate = reservaDate;
            ReservaTime = reservaTime;
            ClienteID = clienteID;
            PersonasCant = personasCant;
            NumeroMesa = numeroMesa;
            _reservaEstado = reservaEstado;
        }

       
    }
}
