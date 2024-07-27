namespace RestauranteSystem.Reservas
{
    partial class frmReservas
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReservas));
            pnlNuevaReserva = new Panel();
            dtpReservaHora = new DateTimePicker();
            label10 = new Label();
            cboReservaEstado = new ComboBox();
            label4 = new Label();
            dtpReservaFecha = new DateTimePicker();
            txbMesasNum = new TextBox();
            btnMesasView = new Button();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            btnCancelar = new Button();
            btnBuscarClienteID = new Button();
            label7 = new Label();
            btnGuardar = new Button();
            txbClienteID = new TextBox();
            label2 = new Label();
            dtpReservaCreacion = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            txbCantPersonas = new TextBox();
            label9 = new Label();
            txbReservaCodigo = new TextBox();
            panel2 = new Panel();
            btnExportarXML = new Button();
            btnImportarXML = new Button();
            btnExportarExcel = new Button();
            btnVerReserva = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            txbBuscadorReserva = new TextBox();
            btnBuscadorReserva = new Button();
            dgvReservasView = new DataGridView();
            colReservaCodigo = new DataGridViewTextBoxColumn();
            colReservaDateTime = new DataGridViewTextBoxColumn();
            colPersonasCant = new DataGridViewTextBoxColumn();
            colNumeroMesa = new DataGridViewTextBoxColumn();
            colReservaEstado = new DataGridViewTextBoxColumn();
            colReservaCreacion = new DataGridViewTextBoxColumn();
            colCedula = new DataGridViewTextBoxColumn();
            bnSrcReservas = new BindingSource(components);
            label1 = new Label();
            saveDialogExcel = new SaveFileDialog();
            openDialog = new OpenFileDialog();
            saveDialogXML = new SaveFileDialog();
            saveDialogX = new SaveFileDialog();
            pnlNuevaReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservasView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bnSrcReservas).BeginInit();
            SuspendLayout();
            // 
            // pnlNuevaReserva
            // 
            pnlNuevaReserva.BorderStyle = BorderStyle.FixedSingle;
            pnlNuevaReserva.Controls.Add(dtpReservaHora);
            pnlNuevaReserva.Controls.Add(label10);
            pnlNuevaReserva.Controls.Add(cboReservaEstado);
            pnlNuevaReserva.Controls.Add(label4);
            pnlNuevaReserva.Controls.Add(dtpReservaFecha);
            pnlNuevaReserva.Controls.Add(txbMesasNum);
            pnlNuevaReserva.Controls.Add(btnMesasView);
            pnlNuevaReserva.Controls.Add(label8);
            pnlNuevaReserva.Controls.Add(pictureBox1);
            pnlNuevaReserva.Controls.Add(btnCancelar);
            pnlNuevaReserva.Controls.Add(btnBuscarClienteID);
            pnlNuevaReserva.Controls.Add(label7);
            pnlNuevaReserva.Controls.Add(btnGuardar);
            pnlNuevaReserva.Controls.Add(txbClienteID);
            pnlNuevaReserva.Controls.Add(label2);
            pnlNuevaReserva.Controls.Add(dtpReservaCreacion);
            pnlNuevaReserva.Controls.Add(label6);
            pnlNuevaReserva.Controls.Add(label5);
            pnlNuevaReserva.Controls.Add(label3);
            pnlNuevaReserva.Controls.Add(txbCantPersonas);
            pnlNuevaReserva.Controls.Add(label9);
            pnlNuevaReserva.Location = new Point(12, 50);
            pnlNuevaReserva.Name = "pnlNuevaReserva";
            pnlNuevaReserva.Size = new Size(588, 297);
            pnlNuevaReserva.TabIndex = 0;
            // 
            // dtpReservaHora
            // 
            dtpReservaHora.Format = DateTimePickerFormat.Time;
            dtpReservaHora.Location = new Point(335, 93);
            dtpReservaHora.Name = "dtpReservaHora";
            dtpReservaHora.Size = new Size(219, 27);
            dtpReservaHora.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(287, 93);
            label10.Name = "label10";
            label10.Size = new Size(42, 20);
            label10.TabIndex = 24;
            label10.Text = "Hora";
            // 
            // cboReservaEstado
            // 
            cboReservaEstado.BackColor = SystemColors.ScrollBar;
            cboReservaEstado.Enabled = false;
            cboReservaEstado.FormattingEnabled = true;
            cboReservaEstado.Items.AddRange(new object[] { "INA", "ACT" });
            cboReservaEstado.Location = new Point(360, 186);
            cboReservaEstado.Name = "cboReservaEstado";
            cboReservaEstado.Size = new Size(193, 28);
            cboReservaEstado.TabIndex = 23;
            cboReservaEstado.Text = "ACT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(287, 189);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 22;
            label4.Text = "Estado";
            // 
            // dtpReservaFecha
            // 
            dtpReservaFecha.Location = new Point(71, 89);
            dtpReservaFecha.Name = "dtpReservaFecha";
            dtpReservaFecha.Size = new Size(193, 27);
            dtpReservaFecha.TabIndex = 21;
            // 
            // txbMesasNum
            // 
            txbMesasNum.Enabled = false;
            txbMesasNum.Location = new Point(416, 143);
            txbMesasNum.Name = "txbMesasNum";
            txbMesasNum.ReadOnly = true;
            txbMesasNum.Size = new Size(103, 27);
            txbMesasNum.TabIndex = 20;
            // 
            // btnMesasView
            // 
            btnMesasView.Location = new Point(525, 142);
            btnMesasView.Name = "btnMesasView";
            btnMesasView.Size = new Size(29, 29);
            btnMesasView.TabIndex = 19;
            btnMesasView.Text = "+";
            btnMesasView.UseVisualStyleBackColor = true;
            btnMesasView.Click += btnMesasView_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(148, 206);
            label8.Name = "label8";
            label8.Size = new Size(92, 28);
            label8.TabIndex = 17;
            label8.Text = "Antojitos";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 189);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(360, 237);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnBuscarClienteID
            // 
            btnBuscarClienteID.Location = new Point(192, 33);
            btnBuscarClienteID.Name = "btnBuscarClienteID";
            btnBuscarClienteID.Size = new Size(72, 29);
            btnBuscarClienteID.TabIndex = 14;
            btnBuscarClienteID.Text = "Buscar";
            btnBuscarClienteID.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 41);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 13;
            label7.Text = "Cliente";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(460, 237);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txbClienteID
            // 
            txbClienteID.Location = new Point(61, 36);
            txbClienteID.Name = "txbClienteID";
            txbClienteID.Size = new Size(125, 27);
            txbClienteID.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(274, 37);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 11;
            label2.Text = "Fecha de Creación";
            // 
            // dtpReservaCreacion
            // 
            dtpReservaCreacion.Enabled = false;
            dtpReservaCreacion.Format = DateTimePickerFormat.Custom;
            dtpReservaCreacion.Location = new Point(412, 34);
            dtpReservaCreacion.Name = "dtpReservaCreacion";
            dtpReservaCreacion.Size = new Size(142, 27);
            dtpReservaCreacion.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(287, 146);
            label6.Name = "label6";
            label6.Size = new Size(123, 20);
            label6.TabIndex = 8;
            label6.Text = "Numero de Mesa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 144);
            label5.Name = "label5";
            label5.Size = new Size(151, 20);
            label5.TabIndex = 7;
            label5.Text = "Cantidad de Personas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 89);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 4;
            label3.Text = "Fecha";
            // 
            // txbCantPersonas
            // 
            txbCantPersonas.Location = new Point(175, 144);
            txbCantPersonas.Name = "txbCantPersonas";
            txbCantPersonas.Size = new Size(89, 27);
            txbCantPersonas.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(143, 227);
            label9.Name = "label9";
            label9.Size = new Size(117, 28);
            label9.TabIndex = 18;
            label9.Text = "Lo De María";
            // 
            // txbReservaCodigo
            // 
            txbReservaCodigo.Cursor = Cursors.No;
            txbReservaCodigo.Enabled = false;
            txbReservaCodigo.Location = new Point(372, 36);
            txbReservaCodigo.Name = "txbReservaCodigo";
            txbReservaCodigo.ReadOnly = true;
            txbReservaCodigo.Size = new Size(194, 27);
            txbReservaCodigo.TabIndex = 0;
            txbReservaCodigo.TabStop = false;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnExportarXML);
            panel2.Controls.Add(btnImportarXML);
            panel2.Controls.Add(btnExportarExcel);
            panel2.Controls.Add(btnVerReserva);
            panel2.Controls.Add(btnEliminar);
            panel2.Controls.Add(btnEditar);
            panel2.Controls.Add(txbBuscadorReserva);
            panel2.Controls.Add(btnBuscadorReserva);
            panel2.Controls.Add(dgvReservasView);
            panel2.Location = new Point(12, 370);
            panel2.Name = "panel2";
            panel2.Size = new Size(588, 347);
            panel2.TabIndex = 1;
            // 
            // btnExportarXML
            // 
            btnExportarXML.Location = new Point(166, 303);
            btnExportarXML.Name = "btnExportarXML";
            btnExportarXML.Size = new Size(114, 29);
            btnExportarXML.TabIndex = 27;
            btnExportarXML.Text = "Exportar XML";
            btnExportarXML.UseVisualStyleBackColor = true;
            btnExportarXML.Click += btnExportarXML_Click;
            // 
            // btnImportarXML
            // 
            btnImportarXML.Location = new Point(18, 303);
            btnImportarXML.Name = "btnImportarXML";
            btnImportarXML.Size = new Size(136, 29);
            btnImportarXML.TabIndex = 26;
            btnImportarXML.Text = "Importar XML";
            btnImportarXML.UseVisualStyleBackColor = true;
            btnImportarXML.Click += btnImportarExcel_Click;
            // 
            // btnExportarExcel
            // 
            btnExportarExcel.Location = new Point(429, 303);
            btnExportarExcel.Name = "btnExportarExcel";
            btnExportarExcel.Size = new Size(124, 29);
            btnExportarExcel.TabIndex = 25;
            btnExportarExcel.Text = "Exportar a Excel";
            btnExportarExcel.UseVisualStyleBackColor = true;
            btnExportarExcel.Click += btnExportarExcel_Click;
            // 
            // btnVerReserva
            // 
            btnVerReserva.Location = new Point(335, 247);
            btnVerReserva.Name = "btnVerReserva";
            btnVerReserva.Size = new Size(94, 29);
            btnVerReserva.TabIndex = 24;
            btnVerReserva.Text = "Ver Reserva";
            btnVerReserva.UseVisualStyleBackColor = true;
            btnVerReserva.Click += btnVerReserva_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(235, 247);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 23;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(135, 247);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 22;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // txbBuscadorReserva
            // 
            txbBuscadorReserva.Location = new Point(169, 15);
            txbBuscadorReserva.Name = "txbBuscadorReserva";
            txbBuscadorReserva.PlaceholderText = "NUMERO DE CEDULA [CLIENTE]";
            txbBuscadorReserva.Size = new Size(389, 27);
            txbBuscadorReserva.TabIndex = 19;
            // 
            // btnBuscadorReserva
            // 
            btnBuscadorReserva.Location = new Point(22, 15);
            btnBuscadorReserva.Name = "btnBuscadorReserva";
            btnBuscadorReserva.Size = new Size(141, 29);
            btnBuscadorReserva.TabIndex = 18;
            btnBuscadorReserva.Text = "Buscar Reservas";
            btnBuscadorReserva.UseVisualStyleBackColor = true;
            btnBuscadorReserva.Click += btnBuscadorReserva_Click;
            // 
            // dgvReservasView
            // 
            dgvReservasView.AllowUserToAddRows = false;
            dgvReservasView.AllowUserToDeleteRows = false;
            dgvReservasView.AutoGenerateColumns = false;
            dgvReservasView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservasView.Columns.AddRange(new DataGridViewColumn[] { colReservaCodigo, colReservaDateTime, colPersonasCant, colNumeroMesa, colReservaEstado, colReservaCreacion, colCedula });
            dgvReservasView.DataSource = bnSrcReservas;
            dgvReservasView.Location = new Point(22, 50);
            dgvReservasView.Name = "dgvReservasView";
            dgvReservasView.ReadOnly = true;
            dgvReservasView.RowHeadersWidth = 51;
            dgvReservasView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReservasView.Size = new Size(536, 191);
            dgvReservasView.TabIndex = 0;
            dgvReservasView.SelectionChanged += dgvReservasView_SelectionChanged;
            // 
            // colReservaCodigo
            // 
            colReservaCodigo.DataPropertyName = "ReservaCodigo";
            colReservaCodigo.HeaderText = "Codigo";
            colReservaCodigo.MinimumWidth = 6;
            colReservaCodigo.Name = "colReservaCodigo";
            colReservaCodigo.ReadOnly = true;
            colReservaCodigo.Width = 125;
            // 
            // colReservaDateTime
            // 
            colReservaDateTime.DataPropertyName = "ReservaDateTime";
            colReservaDateTime.HeaderText = "Fecha y Hora";
            colReservaDateTime.MinimumWidth = 6;
            colReservaDateTime.Name = "colReservaDateTime";
            colReservaDateTime.ReadOnly = true;
            colReservaDateTime.Width = 125;
            // 
            // colPersonasCant
            // 
            colPersonasCant.DataPropertyName = "PersonasCant";
            colPersonasCant.HeaderText = "Cantidad de Personas";
            colPersonasCant.MinimumWidth = 6;
            colPersonasCant.Name = "colPersonasCant";
            colPersonasCant.ReadOnly = true;
            colPersonasCant.Width = 125;
            // 
            // colNumeroMesa
            // 
            colNumeroMesa.DataPropertyName = "NumeroMesa";
            colNumeroMesa.HeaderText = "Numero de Mesa";
            colNumeroMesa.MinimumWidth = 6;
            colNumeroMesa.Name = "colNumeroMesa";
            colNumeroMesa.ReadOnly = true;
            colNumeroMesa.Width = 125;
            // 
            // colReservaEstado
            // 
            colReservaEstado.DataPropertyName = "ReservaEstado";
            colReservaEstado.HeaderText = "Estado";
            colReservaEstado.MinimumWidth = 6;
            colReservaEstado.Name = "colReservaEstado";
            colReservaEstado.ReadOnly = true;
            colReservaEstado.Width = 125;
            // 
            // colReservaCreacion
            // 
            colReservaCreacion.DataPropertyName = "ReservaCreacion";
            colReservaCreacion.HeaderText = "Fecha de Creación";
            colReservaCreacion.MinimumWidth = 6;
            colReservaCreacion.Name = "colReservaCreacion";
            colReservaCreacion.ReadOnly = true;
            colReservaCreacion.Width = 125;
            // 
            // colCedula
            // 
            colCedula.DataPropertyName = "ReservaCliente";
            colCedula.HeaderText = "Cliente Cedula";
            colCedula.MinimumWidth = 6;
            colCedula.Name = "colCedula";
            colCedula.ReadOnly = true;
            colCedula.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 34);
            label1.Name = "label1";
            label1.Size = new Size(139, 28);
            label1.TabIndex = 1;
            label1.Text = "Nueva Reserva";
            // 
            // saveDialogExcel
            // 
            saveDialogExcel.DefaultExt = "xlsx";
            saveDialogExcel.FileName = "reservasDataBU";
            saveDialogExcel.Filter = "Archivos de Excel 2007+ | *.xlsx";
            // 
            // openDialog
            // 
            openDialog.DefaultExt = "xml";
            openDialog.FileName = "restauranteReserasListado";
            openDialog.Filter = "Archivos XML (*.xml) | *.xml";
            // 
            // saveDialogXML
            // 
            saveDialogXML.DefaultExt = "xlsx";
            saveDialogXML.FileName = "reservasDataBU";
            saveDialogXML.Filter = "Archivos de Excel 2007+ | *.xlsx";
            // 
            // saveDialogX
            // 
            saveDialogX.DefaultExt = "xml";
            saveDialogX.FileName = "saveXMLReservas";
            saveDialogX.Filter = "Archivos XML (*.xml) | *.xml";
            // 
            // frmReservas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 729);
            Controls.Add(txbReservaCodigo);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(pnlNuevaReserva);
            Name = "frmReservas";
            Text = "frmReservas";
            pnlNuevaReserva.ResumeLayout(false);
            pnlNuevaReserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservasView).EndInit();
            ((System.ComponentModel.ISupportInitialize)bnSrcReservas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlNuevaReserva;
        private Panel panel2;
        private DataGridView dgvReservasView;
        private Button btnGuardar;
        private TextBox txbReservaCodigo;
        private Label label1;
        private TextBox txbCantPersonas;
        private Label label3;
        private Label label6;
        private Label label5;
        private ComboBox cmbNumMesa;
        private Label label2;
        private DateTimePicker dtpReservaCreacion;
        private Button btnBuscarClienteID;
        private Label label7;
        private TextBox txbClienteID;
        private Button btnCancelar;
        private Label label8;
        private PictureBox pictureBox1;
        private Label label9;
        private Button btnBuscadorReserva;
        private Button btnMesasView;
        private TextBox txbMesasNum;
        private BindingSource bnSrcReservas;
        private DateTimePicker dtpReservaFecha;
        private ComboBox cboReservaEstado;
        private Label label4;
        private DateTimePicker dtpReservaHora;
        private Label label10;
        private TextBox txbBuscadorReserva;
        private DataGridViewTextBoxColumn colReservaCodigo;
        private DataGridViewTextBoxColumn colReservaDateTime;
        private DataGridViewTextBoxColumn colPersonasCant;
        private DataGridViewTextBoxColumn colNumeroMesa;
        private DataGridViewTextBoxColumn colReservaEstado;
        private DataGridViewTextBoxColumn colReservaCreacion;
        private DataGridViewTextBoxColumn colCedula;
        private Button btnExportarExcel;
        private Button btnVerReserva;
        private Button btnEliminar;
        private Button btnEditar;
        private SaveFileDialog saveDialogExcel;
        private OpenFileDialog openDialog;
        private Button btnImportarXML;
        private Button btnExportarXML;
        private SaveFileDialog saveDialogXML;
        private SaveFileDialog saveDialogX;
    }
}