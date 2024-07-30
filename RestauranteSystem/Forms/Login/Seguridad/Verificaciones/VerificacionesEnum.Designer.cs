namespace RestauranteSystem.Forms.Login.Seguridad.Verificaciones
{
    partial class VerificacionesEnum
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
            tituloFormulario = new Label();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            cboEstado = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            txtCodigo = new TextBox();
            lblCodigoID = new Label();
            SuspendLayout();
            // 
            // tituloFormulario
            // 
            tituloFormulario.AutoSize = true;
            tituloFormulario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tituloFormulario.Location = new Point(22, 20);
            tituloFormulario.Name = "tituloFormulario";
            tituloFormulario.Size = new Size(276, 28);
            tituloFormulario.TabIndex = 0;
            tituloFormulario.Text = "Ingresando Nueva Verificación";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(107, 102);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(37, 227);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(195, 123);
            txtDescripcion.TabIndex = 2;
            // 
            // cboEstado
            // 
            cboEstado.FormattingEnabled = true;
            cboEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cboEstado.Location = new Point(107, 154);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(125, 28);
            cboEstado.TabIndex = 3;
            cboEstado.Text = "Activo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 105);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 162);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 5;
            label3.Text = "Estado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 204);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 6;
            label4.Text = "Descripción";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(138, 387);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(94, 29);
            btnConfirmar.TabIndex = 7;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(38, 387);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(107, 60);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(125, 27);
            txtCodigo.TabIndex = 9;
            // 
            // lblCodigoID
            // 
            lblCodigoID.AutoSize = true;
            lblCodigoID.Location = new Point(51, 63);
            lblCodigoID.Name = "lblCodigoID";
            lblCodigoID.Size = new Size(24, 20);
            lblCodigoID.TabIndex = 10;
            lblCodigoID.Text = "ID";
            // 
            // VerificacionesEnum
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(350, 464);
            Controls.Add(lblCodigoID);
            Controls.Add(txtCodigo);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cboEstado);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(tituloFormulario);
            Name = "VerificacionesEnum";
            Text = "VerificacionesEnum";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tituloFormulario;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private ComboBox cboEstado;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnConfirmar;
        private Button btnCancelar;
        private TextBox txtCodigo;
        private Label lblCodigoID;
    }
}