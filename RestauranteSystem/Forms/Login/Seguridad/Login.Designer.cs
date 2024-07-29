namespace RestauranteSystem.Login.Seguridad
{
    partial class Login
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
            btnVerificaciones = new Button();
            btnRoles = new Button();
            btnUsuarios = new Button();
            SuspendLayout();
            // 
            // btnVerificaciones
            // 
            btnVerificaciones.Location = new Point(210, 145);
            btnVerificaciones.Name = "btnVerificaciones";
            btnVerificaciones.Size = new Size(131, 29);
            btnVerificaciones.TabIndex = 0;
            btnVerificaciones.Text = "Verificaciones";
            btnVerificaciones.UseVisualStyleBackColor = true;
            btnVerificaciones.Click += btnSession_Click;
            // 
            // btnRoles
            // 
            btnRoles.Location = new Point(110, 145);
            btnRoles.Name = "btnRoles";
            btnRoles.Size = new Size(94, 29);
            btnRoles.TabIndex = 1;
            btnRoles.Text = "Roles";
            btnRoles.UseVisualStyleBackColor = true;
            btnRoles.Click += btnRoles_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Location = new Point(10, 145);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(94, 29);
            btnUsuarios.TabIndex = 2;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 186);
            Controls.Add(btnUsuarios);
            Controls.Add(btnRoles);
            Controls.Add(btnVerificaciones);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
        }

        #endregion

        private Button btnVerificaciones;
        private Button btnRoles;
        private Button btnUsuarios;
    }
}