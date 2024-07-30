namespace RestauranteSystem.Forms.Login.Seguridad.Admins
{
    partial class ControlesAdmins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlesAdmins));
            btnUsuarios = new Button();
            btnRoles = new Button();
            btnVerificaciones = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnUsuarios
            // 
            btnUsuarios.Location = new Point(58, 262);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(94, 29);
            btnUsuarios.TabIndex = 5;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnRoles
            // 
            btnRoles.Location = new Point(158, 262);
            btnRoles.Name = "btnRoles";
            btnRoles.Size = new Size(94, 29);
            btnRoles.TabIndex = 4;
            btnRoles.Text = "Roles";
            btnRoles.UseVisualStyleBackColor = true;
            btnRoles.Click += btnRoles_Click;
            // 
            // btnVerificaciones
            // 
            btnVerificaciones.Location = new Point(258, 262);
            btnVerificaciones.Name = "btnVerificaciones";
            btnVerificaciones.Size = new Size(131, 29);
            btnVerificaciones.TabIndex = 3;
            btnVerificaciones.Text = "Verificaciones";
            btnVerificaciones.UseVisualStyleBackColor = true;
            btnVerificaciones.Click += btnVerificaciones_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(109, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(232, 195);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // ControlesAdmins
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 352);
            Controls.Add(pictureBox1);
            Controls.Add(btnUsuarios);
            Controls.Add(btnRoles);
            Controls.Add(btnVerificaciones);
            Name = "ControlesAdmins";
            Text = "ControlesAdmins";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnUsuarios;
        private Button btnRoles;
        private Button btnVerificaciones;
        private PictureBox pictureBox1;
    }
}