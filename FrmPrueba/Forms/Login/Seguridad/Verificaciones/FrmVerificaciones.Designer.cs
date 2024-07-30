namespace RestauranteSystem.Forms.Login
{
    partial class FrmVerificaciones
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
            dgvVerificaciones = new DataGridView();
            colVerificacionID = new DataGridViewTextBoxColumn();
            colCodigo = new DataGridViewTextBoxColumn();
            colDescripcion = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            label1 = new Label();
            bndSrcVerificaciones = new BindingSource(components);
            btnEditarVerificacion = new Button();
            btnEliminarVerificacion = new Button();
            btnVerVerificacion = new Button();
            btnNuevoVerificacion = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVerificaciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bndSrcVerificaciones).BeginInit();
            SuspendLayout();
            // 
            // dgvVerificaciones
            // 
            dgvVerificaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVerificaciones.Columns.AddRange(new DataGridViewColumn[] { colVerificacionID, colCodigo, colDescripcion, colEstado });
            dgvVerificaciones.Location = new Point(12, 53);
            dgvVerificaciones.Name = "dgvVerificaciones";
            dgvVerificaciones.RowHeadersWidth = 51;
            dgvVerificaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVerificaciones.Size = new Size(428, 188);
            dgvVerificaciones.TabIndex = 0;
            dgvVerificaciones.SelectionChanged += dgvVerificaciones_SelectionChanged;
            // 
            // colVerificacionID
            // 
            colVerificacionID.DataPropertyName = "VerificacionID";
            colVerificacionID.HeaderText = "VerificacionID";
            colVerificacionID.MinimumWidth = 6;
            colVerificacionID.Name = "colVerificacionID";
            colVerificacionID.Width = 125;
            // 
            // colCodigo
            // 
            colCodigo.DataPropertyName = "Codigo";
            colCodigo.HeaderText = "Codigo";
            colCodigo.MinimumWidth = 6;
            colCodigo.Name = "colCodigo";
            colCodigo.Width = 125;
            // 
            // colDescripcion
            // 
            colDescripcion.DataPropertyName = "Descripcion";
            colDescripcion.HeaderText = "Descripcion";
            colDescripcion.MinimumWidth = 6;
            colDescripcion.Name = "colDescripcion";
            colDescripcion.Width = 125;
            // 
            // colEstado
            // 
            colEstado.DataPropertyName = "Estado";
            colEstado.HeaderText = "Estado";
            colEstado.MinimumWidth = 6;
            colEstado.Name = "colEstado";
            colEstado.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(118, 25);
            label1.TabIndex = 1;
            label1.Text = "Verificaciones";
            // 
            // btnEditarVerificacion
            // 
            btnEditarVerificacion.Location = new Point(32, 247);
            btnEditarVerificacion.Name = "btnEditarVerificacion";
            btnEditarVerificacion.Size = new Size(94, 29);
            btnEditarVerificacion.TabIndex = 2;
            btnEditarVerificacion.Text = "Editar";
            btnEditarVerificacion.UseVisualStyleBackColor = true;
            btnEditarVerificacion.Click += btnEditar_Click;
            // 
            // btnEliminarVerificacion
            // 
            btnEliminarVerificacion.Location = new Point(132, 247);
            btnEliminarVerificacion.Name = "btnEliminarVerificacion";
            btnEliminarVerificacion.Size = new Size(94, 29);
            btnEliminarVerificacion.TabIndex = 3;
            btnEliminarVerificacion.Text = "Eliminar";
            btnEliminarVerificacion.UseVisualStyleBackColor = true;
            btnEliminarVerificacion.Click += btnEliminarVerificacion_Click;
            // 
            // btnVerVerificacion
            // 
            btnVerVerificacion.Location = new Point(232, 247);
            btnVerVerificacion.Name = "btnVerVerificacion";
            btnVerVerificacion.Size = new Size(94, 29);
            btnVerVerificacion.TabIndex = 4;
            btnVerVerificacion.Text = "Ver";
            btnVerVerificacion.UseVisualStyleBackColor = true;
            btnVerVerificacion.Click += btnVerVerificacion_Click;
            // 
            // btnNuevoVerificacion
            // 
            btnNuevoVerificacion.Location = new Point(332, 247);
            btnNuevoVerificacion.Name = "btnNuevoVerificacion";
            btnNuevoVerificacion.Size = new Size(94, 29);
            btnNuevoVerificacion.TabIndex = 5;
            btnNuevoVerificacion.Text = "Nuevo";
            btnNuevoVerificacion.UseVisualStyleBackColor = true;
            btnNuevoVerificacion.Click += btnNuevo_Click;
            // 
            // FrmVerificaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 293);
            Controls.Add(btnNuevoVerificacion);
            Controls.Add(btnVerVerificacion);
            Controls.Add(btnEliminarVerificacion);
            Controls.Add(btnEditarVerificacion);
            Controls.Add(label1);
            Controls.Add(dgvVerificaciones);
            Name = "FrmVerificaciones";
            Text = "FrmVerificaciones";
            Load += FrmVerificaciones_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVerificaciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)bndSrcVerificaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVerificaciones;
        private Label label1;
        private BindingSource bndSrcVerificaciones;
        private Button btnEditarVerificacion;
        private Button btnEliminarVerificacion;
        private Button btnVerVerificacion;
        private Button btnNuevoVerificacion;
        private DataGridViewTextBoxColumn colVerificacionID;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colDescripcion;
        private DataGridViewTextBoxColumn colEstado;
    }
}