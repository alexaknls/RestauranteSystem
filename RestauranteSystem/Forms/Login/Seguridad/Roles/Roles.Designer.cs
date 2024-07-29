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
            components = new System.ComponentModel.Container();
            btnNuevo = new Button();
            btnVer = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            label1 = new Label();
            dgvRoles = new DataGridView();
            colRolId = new DataGridViewTextBoxColumn();
            colRolName = new DataGridViewTextBoxColumn();
            colRolEstado = new DataGridViewTextBoxColumn();
            colRolCreacion = new DataGridViewTextBoxColumn();
            bndSrcRoles = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvRoles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bndSrcRoles).BeginInit();
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
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnVer
            // 
            btnVer.Location = new Point(232, 238);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(94, 29);
            btnVer.TabIndex = 10;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(132, 238);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(32, 238);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
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
            // dgvRoles
            // 
            dgvRoles.AutoGenerateColumns = false;
            dgvRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoles.Columns.AddRange(new DataGridViewColumn[] { colRolId, colRolName, colRolEstado, colRolCreacion });
            dgvRoles.DataSource = bndSrcRoles;
            dgvRoles.Location = new Point(12, 44);
            dgvRoles.Name = "dgvRoles";
            dgvRoles.RowHeadersWidth = 51;
            dgvRoles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRoles.Size = new Size(428, 188);
            dgvRoles.TabIndex = 6;
            dgvRoles.SelectionChanged += dgvRoles_SelectionChanged;
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
            colRolName.HeaderText = "RolName";
            colRolName.MinimumWidth = 6;
            colRolName.Name = "colRolName";
            colRolName.Width = 125;
            // 
            // colRolEstado
            // 
            colRolEstado.DataPropertyName = "Estado";
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
            Controls.Add(dgvRoles);
            Name = "Roles";
            Text = "Roles";
            Load += Roles_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRoles).EndInit();
            ((System.ComponentModel.ISupportInitialize)bndSrcRoles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNuevo;
        private Button btnVer;
        private Button btnEliminar;
        private Button btnEditar;
        private Label label1;
        private DataGridView dgvRoles;
        private BindingSource bndSrcRoles;
        private DataGridViewTextBoxColumn colRolId;
        private DataGridViewTextBoxColumn colRolName;
        private DataGridViewTextBoxColumn colRolEstado;
        private DataGridViewTextBoxColumn colRolCreacion;
    }
}