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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            label2 = new Label();
            txtUser = new TextBox();
            txtPasword = new TextBox();
            btnSession = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 219);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 286);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(107, 242);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(178, 27);
            txtUser.TabIndex = 2;
            // 
            // txtPasword
            // 
            txtPasword.Location = new Point(107, 309);
            txtPasword.Name = "txtPasword";
            txtPasword.PasswordChar = '*';
            txtPasword.Size = new Size(178, 27);
            txtPasword.TabIndex = 3;
            // 
            // btnSession
            // 
            btnSession.Location = new Point(118, 366);
            btnSession.Name = "btnSession";
            btnSession.Size = new Size(140, 29);
            btnSession.TabIndex = 4;
            btnSession.Text = "Iniciar Sessión";
            btnSession.UseVisualStyleBackColor = true;
            btnSession.Click += btnSession_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(118, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(153, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 463);
            Controls.Add(pictureBox1);
            Controls.Add(btnSession);
            Controls.Add(txtPasword);
            Controls.Add(txtUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUser;
        private TextBox txtPasword;
        private Button btnSession;
        private PictureBox pictureBox1;
    }
}