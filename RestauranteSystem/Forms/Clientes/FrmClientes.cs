using RestauranteLib;
using RestauranteSystem.Reservas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DocumentFormat.OpenXml.Drawing.Spreadsheet;
using RestauranteDAO;
using RestauranteDAO.RestauranteDataSetTableAdapters;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using SixLabors.Fonts;
using RestauranteLib.Controladores;

namespace RestauranteSystem.Forms.Clientes
{
    public partial class FrmClientes : Form
    {
        private Clienteslib _clienteslib;
        private BindingList<Clienteslib> bindingList;
        private BindingSource _brnsCliente;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private DataGridView dataGridView;
        private ClientData dataset;
        private RestauranteDataSet.ClientesDataTable DataTable;
        private ControladorClientes controladorClientes;
        public FrmClientes()
        {
            InitializeComponent();

            InitializeCustomComponents();
            _clienteslib = new Clienteslib();
            dataGridView1.DataSource = _clienteslib._Clientes;
            dataset = new ClientData();
            DataTable = new RestauranteDataSet.ClientesDataTable();
            _clienteslib = new Clienteslib();
            dataGridView1.DataSource = new BindingList<Clienteslib>(_clienteslib._Clientes);
            ActualizarDataGridView();
            this.btmeliminar.Click += new System.EventHandler(this.btmeliminar_Click);
            this.btmmodificar.Click += new System.EventHandler(this.btmmodificar_Click);
            this.btmver.Click += new System.EventHandler(this.btmver_Click);
        }
        private void ActualizarDataGridView()
        {
            dataGridView1.DataSource = null;  
            dataGridView1.DataSource = _clienteslib._Clientes;  
            dataGridView1.Refresh();  
        }
        private void btmregresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReservas Formulario = new frmReservas();
            Formulario.Show();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {

        }

        private void btmguardar_Click(object sender, EventArgs e)
        {
            string directoryPath = AppDomain.CurrentDomain.BaseDirectory;
            
            string fileName = "clientes.csv"; 
                                              
            string filePath = Path.Combine(directoryPath, fileName);

           
            List<string> lines = new List<string>();
            string headerLine = "";
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                if (i > 0) headerLine += ",";
                headerLine += dataGridView.Columns[i].HeaderText;
            }
            lines.Add(headerLine);

            
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    string rowLine = "";
                    for (int i = 0; i < dataGridView.Columns.Count; i++)
                    {
                        if (i > 0) rowLine += ",";
                      
                        rowLine += row.Cells[i].Value?.ToString() ?? "";
                    }
                    lines.Add(rowLine);
                }
            }

            File.WriteAllLines(filePath, lines);
            MessageBox.Show("Datos guardados exitosamente en " + filePath, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void InitializeCustomComponents()
        {
            btmguardar = new Button();
            btmguardar.Text = "Guardar";
            btmguardar.Location = new Point(10, 280);
            btmguardar.Click += new EventHandler(this.btmguardar_Click);

            btmBuscar = new Button();
            btmBuscar.Text = "Buscar";
            btmBuscar.Location = new Point(10, 10);
            btmBuscar.Click += new EventHandler(this.btmBuscar_Click);


            txtBuscar = new TextBox();
            txtBuscar.Location = new Point(100, 10);


            btmagregar = new Button();
            btmagregar.Text = "Agregar";
            btmagregar.Location = new Point(10, 40);
            btmagregar.Click += new EventHandler(this.btmagregar_Click);



            txtcelula = new TextBox();
            txtcelula.PlaceholderText = "Célula";
            txtcelula.Location = new Point(200, 40);

            txttelefono = new TextBox();
            txttelefono.PlaceholderText = "Teléfono";
            txttelefono.Location = new Point(300, 40);

            txtnombre = new TextBox();
            txtnombre.PlaceholderText = "Nombre";
            txtnombre.Location = new Point(400, 40);

            txtemail = new TextBox();
            txtemail.PlaceholderText = "Email";
            txtemail.Location = new Point(500, 40);

            txtapellido = new TextBox();
            txtapellido.PlaceholderText = "Apellido";
            txtapellido.Location = new Point(600, 40);

            txtdireccion = new TextBox();
            txtdireccion.PlaceholderText = "Dirección";
            txtdireccion.Location = new Point(700, 40);

            // txtreserv = new TextBox();
            //  txtreserv.PlaceholderText = "Reserv";
            // txtreserv.Location = new Point(800, 40);


            this.Controls.Add(btnBuscar);
            this.Controls.Add(txtBuscar);
            this.Controls.Add(btmagregar);

            this.Controls.Add(txtcelula);
            this.Controls.Add(txttelefono);
            this.Controls.Add(txtnombre);
            this.Controls.Add(txtemail);
            this.Controls.Add(txtapellido);
            this.Controls.Add(txtdireccion);
            //this.Controls.Add(txtreserv);


            dataGridView = new DataGridView();
            dataGridView.Location = new Point(10, 80);
            dataGridView.Size = new Size(900, 200);


            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Celula", "Célula");
            dataGridView1.Columns.Add("Telefono", "Teléfono");
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Email", "Email");
            dataGridView1.Columns.Add("Apellido", "Apellido");
            dataGridView1.Columns.Add("Direccion", "Dirección");
            dataGridView1.Columns.Add("Reserv", "Reserv");

            this.Controls.Add(btmguardar);
            this.Controls.Add(dataGridView1);
        }

        private void btmagregar_Click(object sender, EventArgs e)
        {
            string celula = txtcelula.Text;
            string telefono = txttelefono.Text;
            string nombre = txtnombre.Text;
            string email = txtemail.Text;
            string apellido = txtapellido.Text;
            string direccion = txtdireccion.Text;
          //  string reserv = txtreserv.Text;

          
            if (!string.IsNullOrWhiteSpace(celula) &&
                !string.IsNullOrWhiteSpace(telefono) &&
                !string.IsNullOrWhiteSpace(nombre) &&
                !string.IsNullOrWhiteSpace(email) &&
                !string.IsNullOrWhiteSpace(apellido) &&
                !string.IsNullOrWhiteSpace(direccion) )
            {

                var nuevoCliente = new Clienteslib
                {
                     ClienteCelula= Convert.ToInt32(txtcelula.Text),
                    ClientePhone = txttelefono.Text,
                    ClienteNombre = txtnombre.Text,
                    ClienteEmail = txtemail.Text,
                    ClientesApellido = txtapellido.Text,
                    ClienteDireccion = txtdireccion.Text
                };

                _clienteslib.AgregarCliente(nuevoCliente);
                dataGridView1.DataSource = new BindingList<Clienteslib>(_clienteslib._Clientes);
            }
        
            else
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       

        private void btmver_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string mensaje = $"Cedula: {selectedRow.Cells["ClienteCedula"].Value}\n" +
                                 $"Nombre: {selectedRow.Cells["ClienteNombre"].Value}\n" +
                                 $"Apellido: {selectedRow.Cells["ClienteApellido"].Value}\n" +
                                 $"Teléfono: {selectedRow.Cells["ClientePhone"].Value}\n" +
                                 $"Email: {selectedRow.Cells["ClienteEmail"].Value}\n" +
                                 $"Dirección: {selectedRow.Cells["ClienteDireccion"].Value}";

                MessageBox.Show(mensaje, "Información del Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btmeliminar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
            }
        }

        private void btmmodificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                selectedRow.Cells["ClienteCedula"].Value = txtcelula.Text;
                selectedRow.Cells["ClienteNombre"].Value = txtnombre.Text;
                selectedRow.Cells["ClienteApellido"].Value = txtapellido.Text;
                selectedRow.Cells["ClientePhone"].Value = txttelefono.Text;
                selectedRow.Cells["ClienteEmail"].Value = txtemail.Text;
                selectedRow.Cells["ClienteDireccion"].Value = txtdireccion.Text;
            }
        }

        private void btmBuscar_Click(object sender, EventArgs e)
        {
            string nombreBuscado = txtbuscar.Text.ToLower();

            
            bool encontrado = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Nombre"].Value != null &&
                    row.Cells["Nombre"].Value.ToString().ToLower().Contains(nombreBuscado))
                {
                
                    row.Selected = true;
                    dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("No se encontró ningún cliente con ese nombre.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
