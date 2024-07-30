namespace RestauranteSystem.Forms.Login.Seguridad.Usuarios
{
    partial class UsuariosEnum
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
            label3 = new Label();
            label2 = new Label();
            cboEstado = new ComboBox();
            txtNombre = new TextBox();
            tituloFormulario = new Label();
            label1 = new Label();
            txtUser = new TextBox();
            label5 = new Label();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // lblCodigoID
            // 
            lblCodigoID.AutoSize = true;
            lblCodigoID.Location = new Point(47, 220);
            lblCodigoID.Name = "lblCodigoID";
            lblCodigoID.Size = new Size(24, 20);
            lblCodigoID.TabIndex = 32;
            lblCodigoID.Text = "ID";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(103, 217);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(125, 27);
            txtCodigo.TabIndex = 31;
            txtCodigo.Text = "1";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(260, 215);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 30;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(360, 215);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(94, 29);
            btnConfirmar.TabIndex = 29;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(260, 73);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 27;
            label3.Text = "Estado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 69);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 26;
            label2.Text = "Nombre";
            // 
            // cboEstado
            // 
            cboEstado.FormattingEnabled = true;
            cboEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cboEstado.Location = new Point(330, 70);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(144, 28);
            cboEstado.TabIndex = 25;
            cboEstado.Text = "Activo";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(103, 66);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 24;
            // 
            // tituloFormulario
            // 
            tituloFormulario.AutoSize = true;
            tituloFormulario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tituloFormulario.Location = new Point(18, 22);
            tituloFormulario.Name = "tituloFormulario";
            tituloFormulario.Size = new Size(245, 28);
            tituloFormulario.TabIndex = 23;
            tituloFormulario.Text = "Ingresando Nuevo Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 143);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 35;
            label1.Text = "Usuario";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(103, 140);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(125, 27);
            txtUser.TabIndex = 34;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(255, 146);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 37;
            label5.Text = "Contraseña";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(344, 143);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(130, 27);
            txtPassword.TabIndex = 36;
            // 
            // UsuariosEnum
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 273);
            Controls.Add(label5);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Controls.Add(txtUser);
            Controls.Add(lblCodigoID);
            Controls.Add(txtCodigo);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cboEstado);
            Controls.Add(txtNombre);
            Controls.Add(tituloFormulario);
            Name = "UsuariosEnum";
            Text = "UsuariosEnum";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigoID;
        private TextBox txtCodigo;
        private Button btnCancelar;
        private Button btnConfirmar;
        private Label label3;
        private Label label2;
        private ComboBox cboEstado;
        private TextBox txtNombre;
        private Label tituloFormulario;
        private Label label1;
        private TextBox txtUser;
        private Label label5;
        private TextBox txtPassword;
    }
}