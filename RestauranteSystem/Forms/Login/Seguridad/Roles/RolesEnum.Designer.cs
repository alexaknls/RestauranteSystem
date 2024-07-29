namespace RestauranteSystem.Forms.Login.Seguridad.Roles
{
    partial class RolesEnum
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
            lblCodigoID = new Label();
            txtCodigo = new TextBox();
            btnCancelar = new Button();
            btnConfirmar = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            cboEstado = new ComboBox();
            txtNombre = new TextBox();
            tituloFormulario = new Label();
            dtpRolFecha = new DateTimePicker();
            SuspendLayout();
            // 
            // lblCodigoID
            // 
            lblCodigoID.AutoSize = true;
            lblCodigoID.Location = new Point(79, 69);
            lblCodigoID.Name = "lblCodigoID";
            lblCodigoID.Size = new Size(24, 20);
            lblCodigoID.TabIndex = 21;
            lblCodigoID.Text = "ID";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(135, 66);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(125, 27);
            txtCodigo.TabIndex = 20;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(151, 327);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(251, 327);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(94, 29);
            btnConfirmar.TabIndex = 18;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 210);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 17;
            label4.Text = "Creacion de rol";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 168);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 16;
            label3.Text = "Estado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 111);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 15;
            label2.Text = "Nombre";
            // 
            // cboEstado
            // 
            cboEstado.FormattingEnabled = true;
            cboEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cboEstado.Location = new Point(135, 160);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(125, 28);
            cboEstado.TabIndex = 14;
            cboEstado.Text = "Activo";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(135, 108);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 12;
            // 
            // tituloFormulario
            // 
            tituloFormulario.AutoSize = true;
            tituloFormulario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tituloFormulario.Location = new Point(50, 26);
            tituloFormulario.Name = "tituloFormulario";
            tituloFormulario.Size = new Size(206, 28);
            tituloFormulario.TabIndex = 11;
            tituloFormulario.Text = "Ingresando Nuevo Rol";
            // 
            // dtpRolFecha
            // 
            dtpRolFecha.Location = new Point(67, 233);
            dtpRolFecha.Name = "dtpRolFecha";
            dtpRolFecha.Size = new Size(193, 27);
            dtpRolFecha.TabIndex = 22;
            dtpRolFecha.CloseUp += dtpRolFecha_CloseUp;
            // 
            // RolesEnum
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 368);
            Controls.Add(dtpRolFecha);
            Controls.Add(lblCodigoID);
            Controls.Add(txtCodigo);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cboEstado);
            Controls.Add(txtNombre);
            Controls.Add(tituloFormulario);
            Name = "RolesEnum";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RolesEnum";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigoID;
        private TextBox txtCodigo;
        private Button btnCancelar;
        private Button btnConfirmar;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cboEstado;
        private TextBox txtNombre;
        private Label tituloFormulario;
        private DateTimePicker dtpRolFecha;
    }
}