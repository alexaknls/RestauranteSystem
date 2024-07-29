
namespace RestauranteLib
{
        public class Clienteslib
        {

            public int _id;
            public string _Celula;
            public string _Telefono;
            public string _Nombre;
            public string _Email;
            public string _Apellido;
            public string _Direccion;
            public string _reser;

            public int ClienteID { get => _id; set => _id = value; }
            public string ClienteCelula { get => _Celula; set => _Celula = value; }
            public string ClienteNombre { get => _Nombre; set => _Nombre = value; }
            public string ClientesApellido { get => _Apellido; set => _Apellido = value; }
            public string ClientePhone{ get => _Telefono; set => _Telefono = value; }
            public string ClienteEmail { get => _Email; set => _Email = value; }
            public string ClienteDireccion { get => _Direccion; set => _Direccion = value; }
            public string ClienteReservas { get => _reser; set => _reser = value; }

            public Clienteslib()
            {
                ClienteID = 0;
                ClienteCelula = "";
                ClienteNombre = "";
                ClientesApellido = "";
                ClientePhone = "";
                ClienteEmail = "";
                ClienteDireccion = "";
                ClienteReservas = "";
            }
            public Clienteslib(
            int clienteID,
            string celulac,
            string nombrec,
            string apellidoc,
            string telefonoc,
            string emailc,
            string direccionc,
            string reser
            )
            {
                ClienteID = clienteID;
                ClienteCelula = celulac;
                ClienteNombre = nombrec;
                ClientesApellido = apellidoc;
                ClientePhone= telefonoc;
                ClienteEmail = emailc;
                ClienteDireccion = direccionc;
                ClienteReservas = reser;
            }
        }

    }

