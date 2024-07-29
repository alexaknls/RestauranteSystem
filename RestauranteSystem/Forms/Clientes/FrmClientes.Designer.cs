namespace RestauranteSystem.Forms.Clientes
{
    partial class FrmClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
<<<<<<< HEAD
            components = new System.ComponentModel.Container();
            Cliente = new Panel();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            direccion = new DataGridViewTextBoxColumn();
            reservas = new DataGridViewTextBoxColumn();
            cedula = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            reservaIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            reservaCodigoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            reservaDateTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            personasCantDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numeroMesaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            reservaEstadoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            reservaCreacionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            reservaClienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            reservasLibBindingSource = new BindingSource(components);
            txtbuscar = new TextBox();
            btmBuscar = new Button();
            panel2 = new Panel();
            btmagregar = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            t = new Label();
            txtdireccion = new TextBox();
            txtapellido = new TextBox();
            txttelefono = new TextBox();
            txtnombre = new TextBox();
            txtemail = new TextBox();
            txtcelula = new TextBox();
            btmver = new Button();
            btmregresar = new Button();
            btmeliminar = new Button();
            btmmodificar = new Button();
            btmguardar = new Button();
            bnrsClientes = new BindingSource(components);
            Cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reservasLibBindingSource).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bnrsClientes).BeginInit();
            SuspendLayout();
            // 
            // Cliente
            // 
            Cliente.Controls.Add(dataGridView1);
            Cliente.Controls.Add(txtbuscar);
            Cliente.Controls.Add(btmBuscar);
            Cliente.Location = new Point(39, 12);
            Cliente.Name = "Cliente";
            Cliente.Size = new Size(555, 327);
            Cliente.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, direccion, reservas, cedula, nombre, apellido, phone, email, reservaIDDataGridViewTextBoxColumn, reservaCodigoDataGridViewTextBoxColumn, reservaDateTimeDataGridViewTextBoxColumn, personasCantDataGridViewTextBoxColumn, numeroMesaDataGridViewTextBoxColumn, reservaEstadoDataGridViewTextBoxColumn, reservaCreacionDataGridViewTextBoxColumn, reservaClienteDataGridViewTextBoxColumn });
            dataGridView1.DataSource = reservasLibBindingSource;
            dataGridView1.Location = new Point(17, 61);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(520, 246);
            dataGridView1.TabIndex = 7;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 125;
            // 
            // direccion
            // 
            direccion.HeaderText = "Direccion";
            direccion.MinimumWidth = 6;
            direccion.Name = "direccion";
            direccion.ReadOnly = true;
            direccion.Width = 125;
            // 
            // reservas
            // 
            reservas.HeaderText = "Reservas";
            reservas.MinimumWidth = 6;
            reservas.Name = "reservas";
            reservas.ReadOnly = true;
            reservas.Width = 125;
            // 
            // cedula
            // 
            cedula.HeaderText = "Cedula";
            cedula.MinimumWidth = 6;
            cedula.Name = "cedula";
            cedula.ReadOnly = true;
            cedula.Width = 125;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            nombre.Width = 125;
            // 
            // apellido
            // 
            apellido.HeaderText = "Apellido";
            apellido.MinimumWidth = 6;
            apellido.Name = "apellido";
            apellido.ReadOnly = true;
            apellido.Width = 125;
            // 
            // phone
            // 
            phone.HeaderText = "Phone";
            phone.MinimumWidth = 6;
            phone.Name = "phone";
            phone.ReadOnly = true;
            phone.Width = 125;
            // 
            // email
            // 
            email.HeaderText = "Email";
            email.MinimumWidth = 6;
            email.Name = "email";
            email.ReadOnly = true;
            email.Width = 125;
            // 
            // reservaIDDataGridViewTextBoxColumn
            // 
            reservaIDDataGridViewTextBoxColumn.DataPropertyName = "ReservaID";
            reservaIDDataGridViewTextBoxColumn.HeaderText = "ReservaID";
            reservaIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            reservaIDDataGridViewTextBoxColumn.Name = "reservaIDDataGridViewTextBoxColumn";
            reservaIDDataGridViewTextBoxColumn.ReadOnly = true;
            reservaIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // reservaCodigoDataGridViewTextBoxColumn
            // 
            reservaCodigoDataGridViewTextBoxColumn.DataPropertyName = "ReservaCodigo";
            reservaCodigoDataGridViewTextBoxColumn.HeaderText = "ReservaCodigo";
            reservaCodigoDataGridViewTextBoxColumn.MinimumWidth = 6;
            reservaCodigoDataGridViewTextBoxColumn.Name = "reservaCodigoDataGridViewTextBoxColumn";
            reservaCodigoDataGridViewTextBoxColumn.ReadOnly = true;
            reservaCodigoDataGridViewTextBoxColumn.Width = 125;
            // 
            // reservaDateTimeDataGridViewTextBoxColumn
            // 
            reservaDateTimeDataGridViewTextBoxColumn.DataPropertyName = "ReservaDateTime";
            reservaDateTimeDataGridViewTextBoxColumn.HeaderText = "ReservaDateTime";
            reservaDateTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            reservaDateTimeDataGridViewTextBoxColumn.Name = "reservaDateTimeDataGridViewTextBoxColumn";
            reservaDateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            reservaDateTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // personasCantDataGridViewTextBoxColumn
            // 
            personasCantDataGridViewTextBoxColumn.DataPropertyName = "PersonasCant";
            personasCantDataGridViewTextBoxColumn.HeaderText = "PersonasCant";
            personasCantDataGridViewTextBoxColumn.MinimumWidth = 6;
            personasCantDataGridViewTextBoxColumn.Name = "personasCantDataGridViewTextBoxColumn";
            personasCantDataGridViewTextBoxColumn.ReadOnly = true;
            personasCantDataGridViewTextBoxColumn.Width = 125;
            // 
            // numeroMesaDataGridViewTextBoxColumn
            // 
            numeroMesaDataGridViewTextBoxColumn.DataPropertyName = "NumeroMesa";
            numeroMesaDataGridViewTextBoxColumn.HeaderText = "NumeroMesa";
            numeroMesaDataGridViewTextBoxColumn.MinimumWidth = 6;
            numeroMesaDataGridViewTextBoxColumn.Name = "numeroMesaDataGridViewTextBoxColumn";
            numeroMesaDataGridViewTextBoxColumn.ReadOnly = true;
            numeroMesaDataGridViewTextBoxColumn.Width = 125;
            // 
            // reservaEstadoDataGridViewTextBoxColumn
            // 
            reservaEstadoDataGridViewTextBoxColumn.DataPropertyName = "ReservaEstado";
            reservaEstadoDataGridViewTextBoxColumn.HeaderText = "ReservaEstado";
            reservaEstadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            reservaEstadoDataGridViewTextBoxColumn.Name = "reservaEstadoDataGridViewTextBoxColumn";
            reservaEstadoDataGridViewTextBoxColumn.ReadOnly = true;
            reservaEstadoDataGridViewTextBoxColumn.Width = 125;
            // 
            // reservaCreacionDataGridViewTextBoxColumn
            // 
            reservaCreacionDataGridViewTextBoxColumn.DataPropertyName = "ReservaCreacion";
            reservaCreacionDataGridViewTextBoxColumn.HeaderText = "ReservaCreacion";
            reservaCreacionDataGridViewTextBoxColumn.MinimumWidth = 6;
            reservaCreacionDataGridViewTextBoxColumn.Name = "reservaCreacionDataGridViewTextBoxColumn";
            reservaCreacionDataGridViewTextBoxColumn.ReadOnly = true;
            reservaCreacionDataGridViewTextBoxColumn.Width = 125;
            // 
            // reservaClienteDataGridViewTextBoxColumn
            // 
            reservaClienteDataGridViewTextBoxColumn.DataPropertyName = "ReservaCliente";
            reservaClienteDataGridViewTextBoxColumn.HeaderText = "ReservaCliente";
            reservaClienteDataGridViewTextBoxColumn.MinimumWidth = 6;
            reservaClienteDataGridViewTextBoxColumn.Name = "reservaClienteDataGridViewTextBoxColumn";
            reservaClienteDataGridViewTextBoxColumn.ReadOnly = true;
            reservaClienteDataGridViewTextBoxColumn.Width = 125;
            // 
            // reservasLibBindingSource
            // 
            reservasLibBindingSource.DataSource = typeof(RestauranteLib.ReservasLib);
            // 
            // txtbuscar
            // 
            txtbuscar.Location = new Point(159, 16);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(326, 27);
            txtbuscar.TabIndex = 6;
            // 
            // btmBuscar
            // 
            btmBuscar.Location = new Point(51, 16);
            btmBuscar.Name = "btmBuscar";
            btmBuscar.Size = new Size(94, 29);
            btmBuscar.TabIndex = 1;
            btmBuscar.Text = "Buscar";
            btmBuscar.UseVisualStyleBackColor = true;
            btmBuscar.Click += btmBuscar_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btmagregar);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(t);
            panel2.Controls.Add(txtdireccion);
            panel2.Controls.Add(txtapellido);
            panel2.Controls.Add(txttelefono);
            panel2.Controls.Add(txtnombre);
            panel2.Controls.Add(txtemail);
            panel2.Controls.Add(txtcelula);
            panel2.Controls.Add(btmver);
            panel2.Controls.Add(btmregresar);
            panel2.Controls.Add(btmeliminar);
            panel2.Controls.Add(btmmodificar);
            panel2.Controls.Add(btmguardar);
            panel2.Location = new Point(56, 361);
            panel2.Name = "panel2";
            panel2.Size = new Size(520, 323);
            panel2.TabIndex = 1;
            // 
            // btmagregar
            // 
            btmagregar.Location = new Point(140, 224);
            btmagregar.Name = "btmagregar";
            btmagregar.Size = new Size(94, 29);
            btmagregar.TabIndex = 16;
            btmagregar.Text = "Agregar";
            btmagregar.UseVisualStyleBackColor = true;
            btmagregar.Click += btmagregar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(292, 144);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 15;
            label6.Text = "Direccion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(314, 93);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 14;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(297, 45);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 13;
            label4.Text = "Telefono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 138);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 12;
            label3.Text = "Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 90);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 11;
            label2.Text = "Nombre";
            // 
            // t
            // 
            t.AutoSize = true;
            t.Location = new Point(36, 39);
            t.Name = "t";
            t.Size = new Size(69, 20);
            t.TabIndex = 2;
            t.Text = "N.Cedula";
            // 
            // txtdireccion
            // 
            txtdireccion.Location = new Point(370, 141);
            txtdireccion.Name = "txtdireccion";
            txtdireccion.Size = new Size(125, 27);
            txtdireccion.TabIndex = 10;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(111, 141);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(125, 27);
            txtapellido.TabIndex = 9;
            // 
            // txttelefono
            // 
            txttelefono.Location = new Point(370, 42);
            txttelefono.Name = "txttelefono";
            txttelefono.Size = new Size(125, 27);
            txttelefono.TabIndex = 8;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(111, 90);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(125, 27);
            txtnombre.TabIndex = 7;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(370, 90);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(125, 27);
            txtemail.TabIndex = 6;
            // 
            // txtcelula
            // 
            txtcelula.Location = new Point(111, 42);
            txtcelula.Name = "txtcelula";
            txtcelula.Size = new Size(125, 27);
            txtcelula.TabIndex = 5;
            // 
            // btmver
            // 
            btmver.Location = new Point(36, 270);
            btmver.Name = "btmver";
            btmver.Size = new Size(94, 29);
            btmver.TabIndex = 4;
            btmver.Text = "Vercliente";
            btmver.UseVisualStyleBackColor = true;
            btmver.Click += btmver_Click;
            // 
            // btmregresar
            // 
            btmregresar.Location = new Point(359, 270);
            btmregresar.Name = "btmregresar";
            btmregresar.Size = new Size(94, 29);
            btmregresar.TabIndex = 3;
            btmregresar.Text = "Regresar";
            btmregresar.UseVisualStyleBackColor = true;
            btmregresar.Click += btmregresar_Click;
            // 
            // btmeliminar
            // 
            btmeliminar.Location = new Point(249, 270);
            btmeliminar.Name = "btmeliminar";
            btmeliminar.Size = new Size(94, 29);
            btmeliminar.TabIndex = 2;
            btmeliminar.Text = "Eliminar";
            btmeliminar.UseVisualStyleBackColor = true;
            btmeliminar.Click += btmeliminar_Click;
            // 
            // btmmodificar
            // 
            btmmodificar.Location = new Point(140, 270);
            btmmodificar.Name = "btmmodificar";
            btmmodificar.Size = new Size(94, 29);
            btmmodificar.TabIndex = 1;
            btmmodificar.Text = "Modificar";
            btmmodificar.UseVisualStyleBackColor = true;
            btmmodificar.Click += btmmodificar_Click;
            // 
            // btmguardar
            // 
            btmguardar.Location = new Point(36, 224);
            btmguardar.Name = "btmguardar";
            btmguardar.Size = new Size(94, 29);
            btmguardar.TabIndex = 0;
            btmguardar.Text = "Guardar";
            btmguardar.UseVisualStyleBackColor = true;
            btmguardar.Click += btmguardar_Click;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 696);
            Controls.Add(panel2);
            Controls.Add(Cliente);
            Name = "FrmClientes";
            Text = "FrmClientes";
            Load += FrmClientes_Load;
            Cliente.ResumeLayout(false);
            Cliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)reservasLibBindingSource).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bnrsClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Cliente;
        private Panel panel2;
        private Button btmBuscar;
        private Button btmver;
        private Button btmregresar;
        private Button btmeliminar;
        private Button btmmodificar;
        private Button btmguardar;
        private TextBox txttelefono;
        private TextBox txtnombre;
        private TextBox txtemail;
        private TextBox txtcelula;
        private TextBox txtdireccion;
        private TextBox txtapellido;
        private TextBox txtbuscar;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label t;
        private Button btmagregar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn direccion;
        private DataGridViewTextBoxColumn reservas;
        private DataGridViewTextBoxColumn cedula;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn email;
        private BindingSource bnrsClientes;
        private DataGridViewTextBoxColumn reservaIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn reservaCodigoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn reservaDateTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn personasCantDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numeroMesaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn reservaEstadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn reservaCreacionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn reservaClienteDataGridViewTextBoxColumn;
        private BindingSource reservasLibBindingSource;
=======
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "FrmClientes";
        }

        #endregion
>>>>>>> ba77c355c82dc54ca88a7c89bb4bc2dd77c8fc9e
    }
}