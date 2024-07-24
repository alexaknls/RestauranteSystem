namespace RestauranteLib
{
    public class ReservasLib
    {
        private int _reservaID;
        private DateTime _reservaDateTime;
        private int _personasCant;
        private int _numeroMesa;
        private string _reservaEstado;
        private DateTime _reservaCreacion;

        public int ReservaID { get => _reservaID; set => _reservaID = value; }
        public DateTime ReservaDateTime { get => _reservaDateTime; set => _reservaDateTime = value; }
        public int PersonasCant { get => _personasCant; set => _personasCant = value; }
        public int NumeroMesa { get => _numeroMesa; set => _numeroMesa = value; }
        public string ReservaEstado { get => _reservaEstado; set => _reservaEstado = value; }
        public DateTime ReservaCreacion { get => _reservaCreacion; set => _reservaCreacion = value; }

        public ReservasLib()
        {
            ReservaID = 0;
            ReservaDateTime = DateTime.MinValue;
            PersonasCant = 0;
            NumeroMesa = 0;
            ReservaEstado = "";
            ReservaCreacion = DateTime.MinValue;
        }

        public ReservasLib(
            int reservaID,
            DateTime reservaDateTime,
            int personasCant,
            int numeroMesa,
            string reservaEstado,
            DateTime reservaCreacion
            )
        {
            ReservaID = reservaID;
            ReservaDateTime = reservaDateTime;
            PersonasCant = personasCant;
            NumeroMesa = numeroMesa;
            _reservaEstado = reservaEstado;
            ReservaCreacion = reservaCreacion;
        }
    }
}
