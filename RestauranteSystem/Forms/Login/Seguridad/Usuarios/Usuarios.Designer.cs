namespace RestauranteSystem.Forms.Login.Seguridad.Usuarios
{
    partial class Usuarios
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
            btnNuevo = new Button();
            btnVer = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            label1 = new Label();
            dgvUsuarios = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colUser = new DataGridViewTextBoxColumn();
            colPassword = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            bndSrcUsuarios = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bndSrcUsuarios).BeginInit();
            SuspendLayout();
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(332, 246);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(94, 29);
            btnNuevo.TabIndex = 17;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnVer
            // 
            btnVer.Location = new Point(232, 246);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(94, 29);
            btnVer.TabIndex = 16;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(132, 246);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(32, 246);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 14;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(80, 25);
            label1.TabIndex = 13;
            label1.Text = "Usuarios";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { colId, colUser, colPassword, colEstado });
            dgvUsuarios.Location = new Point(12, 52);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(428, 188);
            dgvUsuarios.TabIndex = 12;
            dgvUsuarios.SelectionChanged += dgvUsuarios_SelectionChanged;
            // 
            // colId
            // 
            colId.DataPropertyName = "ID";
            colId.HeaderText = "ID";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.Width = 125;
            // 
            // colUser
            // 
            colUser.DataPropertyName = "User";
            colUser.HeaderText = "User";
            colUser.MinimumWidth = 6;
            colUser.Name = "colUser";
            colUser.Width = 125;
            // 
            // colPassword
            // 
            colPassword.DataPropertyName = "Password";
            colPassword.HeaderText = "Password";
            colPassword.MinimumWidth = 6;
            colPassword.Name = "colPassword";
            colPassword.Width = 125;
            // 
            // colEstado
            // 
            colEstado.DataPropertyName = "Estado";
            colEstado.HeaderText = "Estado";
            colEstado.MinimumWidth = 6;
            colEstado.Name = "colEstado";
            colEstado.Width = 125;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 310);
            Controls.Add(btnNuevo);
            Controls.Add(btnVer);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(label1);
            Controls.Add(dgvUsuarios);
            Name = "Usuarios";
            Text = "Usuarios";
            Load += Usuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)bndSrcUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNuevo;
        private Button btnVer;
        private Button btnEliminar;
        private Button btnEditar;
        private Label label1;
        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colUser;
        private DataGridViewTextBoxColumn colPassword;
        private DataGridViewTextBoxColumn colEstado;
        private BindingSource bndSrcUsuarios;
    }
}