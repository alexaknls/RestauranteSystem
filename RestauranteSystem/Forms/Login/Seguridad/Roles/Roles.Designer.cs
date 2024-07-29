namespace RestauranteSystem.Forms.Login.Seguridad.Roles
{
    partial class Roles
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
            btnNuevo = new Button();
            btnVer = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            label1 = new Label();
            dgvVerificaciones = new DataGridView();
            colRolId = new DataGridViewTextBoxColumn();
            colRolName = new DataGridViewTextBoxColumn();
            colRolEstado = new DataGridViewTextBoxColumn();
            colRolCreacion = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvVerificaciones).BeginInit();
            SuspendLayout();
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(332, 238);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(94, 29);
            btnNuevo.TabIndex = 11;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnVer
            // 
            btnVer.Location = new Point(232, 238);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(94, 29);
            btnVer.TabIndex = 10;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(132, 238);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(32, 238);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 7;
            label1.Text = "Roles";
            // 
            // dgvVerificaciones
            // 
            dgvVerificaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVerificaciones.Columns.AddRange(new DataGridViewColumn[] { colRolId, colRolName, colRolEstado, colRolCreacion });
            dgvVerificaciones.Location = new Point(12, 44);
            dgvVerificaciones.Name = "dgvVerificaciones";
            dgvVerificaciones.RowHeadersWidth = 51;
            dgvVerificaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVerificaciones.Size = new Size(428, 188);
            dgvVerificaciones.TabIndex = 6;
            // 
            // colRolId
            // 
            colRolId.DataPropertyName = "RolId";
            colRolId.HeaderText = "RolID";
            colRolId.MinimumWidth = 6;
            colRolId.Name = "colRolId";
            colRolId.Width = 125;
            // 
            // colRolName
            // 
            colRolName.DataPropertyName = "RolName";
            colRolName.HeaderText = "Rol";
            colRolName.MinimumWidth = 6;
            colRolName.Name = "colRolName";
            colRolName.Width = 125;
            // 
            // colRolEstado
            // 
            colRolEstado.DataPropertyName = "RolEstado";
            colRolEstado.HeaderText = "Estado";
            colRolEstado.MinimumWidth = 6;
            colRolEstado.Name = "colRolEstado";
            colRolEstado.Width = 125;
            // 
            // colRolCreacion
            // 
            colRolCreacion.DataPropertyName = "RolCreacion";
            colRolCreacion.HeaderText = "Creacion";
            colRolCreacion.MinimumWidth = 6;
            colRolCreacion.Name = "colRolCreacion";
            colRolCreacion.Width = 125;
            // 
            // Roles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 286);
            Controls.Add(btnNuevo);
            Controls.Add(btnVer);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(label1);
            Controls.Add(dgvVerificaciones);
            Name = "Roles";
            Text = "Roles";
            ((System.ComponentModel.ISupportInitialize)dgvVerificaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNuevo;
        private Button btnVer;
        private Button btnEliminar;
        private Button btnEditar;
        private Label label1;
        private DataGridView dgvVerificaciones;
        private DataGridViewTextBoxColumn colRolId;
        private DataGridViewTextBoxColumn colRolName;
        private DataGridViewTextBoxColumn colRolEstado;
        private DataGridViewTextBoxColumn colRolCreacion;
    }
}