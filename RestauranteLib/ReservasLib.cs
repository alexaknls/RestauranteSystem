namespace RestauranteLib
{
    public class ReservasLib
    {
        private string _reservaID;
        private string _reservaDate;
        private string _reservaTime;
        private string _clienteID;
        private string _personasCant;
        private string _numeroMesa;

        public string ReservaID { get => _reservaID; set => _reservaID = value; }
        public string ReservaDate { get => _reservaDate; set => _reservaDate = value; }
        public string ReservaTime { get => _reservaTime; set => _reservaTime = value; }
        public string ClienteID { get => _clienteID; set => _clienteID = value; }
        public string PersonasCant { get => _personasCant; set => _personasCant = value; }
        public string NumeroMesa { get => _numeroMesa; set => _numeroMesa = value; }

        public ReservasLib()
        {
            _reservaID = "";
            _reservaDate = "";
            _reservaTime = "";
            _clienteID = "";
            _personasCant = "";
            _numeroMesa = "";
        }

        public ReservasLib(
            string reservaID,
            string reservaDate,
            string reservaTime,
            string clienteID,
            string personasCant,
            string numeroMesa
            )
        {
            _reservaID = reservaID;
            _reservaDate = reservaDate;
            _reservaTime = reservaTime;
            _clienteID = clienteID;
            _personasCant = personasCant;
            _numeroMesa = numeroMesa;
        }
    }
}
