namespace RestauranteSystem.Login
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip = new MenuStrip();
            viewMenu = new ToolStripMenuItem();
            controlAdminOpc = new ToolStripMenuItem();
            mnuReservasOpc = new ToolStripMenuItem();
            mnuClientesOpc = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolBarToolStripMenuItem = new ToolStripMenuItem();
            statusBarToolStripMenuItem = new ToolStripMenuItem();
            toolsMenu = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            controladorReservasOpc = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            controladorClientesOpc = new ToolStripMenuItem();
            helpMenu = new ToolStripMenuItem();
            controladorBibliotecaOpc = new ToolStripMenuItem();
            windowsMenu = new ToolStripMenuItem();
            newWindowToolStripMenuItem = new ToolStripMenuItem();
            cascadeToolStripMenuItem = new ToolStripMenuItem();
            tileVerticalToolStripMenuItem = new ToolStripMenuItem();
            tileHorizontalToolStripMenuItem = new ToolStripMenuItem();
            closeAllToolStripMenuItem = new ToolStripMenuItem();
            arrangeIconsToolStripMenuItem = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolTip = new ToolTip(components);
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { viewMenu, toolsMenu, clientesToolStripMenuItem, helpMenu, windowsMenu });
            menuStrip.Location = new Point(0, 0);
            menuStrip.MdiWindowListItem = windowsMenu;
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(8, 3, 0, 3);
            menuStrip.Size = new Size(588, 30);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            // 
            // viewMenu
            // 
            viewMenu.DropDownItems.AddRange(new ToolStripItem[] { controlAdminOpc, mnuReservasOpc, mnuClientesOpc, toolStripMenuItem2, toolBarToolStripMenuItem, statusBarToolStripMenuItem });
            viewMenu.Name = "viewMenu";
            viewMenu.Size = new Size(132, 24);
            viewMenu.Text = "&Administradores";
            // 
            // controlAdminOpc
            // 
            controlAdminOpc.Name = "controlAdminOpc";
            controlAdminOpc.Size = new Size(332, 26);
            controlAdminOpc.Text = "Controlador Para Administradores";
            // 
            // mnuReservasOpc
            // 
            mnuReservasOpc.Name = "mnuReservasOpc";
            mnuReservasOpc.Size = new Size(332, 26);
            mnuReservasOpc.Text = "Menu de Reservas";
            mnuReservasOpc.Click += mnuReservasOpc_Click;
            // 
            // mnuClientesOpc
            // 
            mnuClientesOpc.Name = "mnuClientesOpc";
            mnuClientesOpc.Size = new Size(332, 26);
            mnuClientesOpc.Text = "Menu de Clientes";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(332, 26);
            toolStripMenuItem2.Text = "----------------------------------------";
            // 
            // toolBarToolStripMenuItem
            // 
            toolBarToolStripMenuItem.Checked = true;
            toolBarToolStripMenuItem.CheckOnClick = true;
            toolBarToolStripMenuItem.CheckState = CheckState.Checked;
            toolBarToolStripMenuItem.Name = "toolBarToolStripMenuItem";
            toolBarToolStripMenuItem.Size = new Size(332, 26);
            toolBarToolStripMenuItem.Text = "&Barra de herramientas";
            toolBarToolStripMenuItem.Click += ToolBarToolStripMenuItem_Click;
            // 
            // statusBarToolStripMenuItem
            // 
            statusBarToolStripMenuItem.Checked = true;
            statusBarToolStripMenuItem.CheckOnClick = true;
            statusBarToolStripMenuItem.CheckState = CheckState.Checked;
            statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            statusBarToolStripMenuItem.Size = new Size(332, 26);
            statusBarToolStripMenuItem.Text = "&Barra de estado";
            statusBarToolStripMenuItem.Click += StatusBarToolStripMenuItem_Click;
            // 
            // toolsMenu
            // 
            toolsMenu.DropDownItems.AddRange(new ToolStripItem[] { optionsToolStripMenuItem });
            toolsMenu.Name = "toolsMenu";
            toolsMenu.Size = new Size(80, 24);
            toolsMenu.Text = "&Reservas";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { controladorReservasOpc });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(224, 26);
            optionsToolStripMenuItem.Text = "Abrir";
            // 
            // controladorReservasOpc
            // 
            controladorReservasOpc.Name = "controladorReservasOpc";
            controladorReservasOpc.Size = new Size(254, 26);
            controladorReservasOpc.Text = "Controlador de Reservas";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { abrirToolStripMenuItem });
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(75, 24);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { controladorClientesOpc });
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(125, 26);
            abrirToolStripMenuItem.Text = "Abrir";
            // 
            // controladorClientesOpc
            // 
            controladorClientesOpc.Name = "controladorClientesOpc";
            controladorClientesOpc.Size = new Size(249, 26);
            controladorClientesOpc.Text = "Controlador de Clientes";
            // 
            // helpMenu
            // 
            helpMenu.DropDownItems.AddRange(new ToolStripItem[] { controladorBibliotecaOpc });
            helpMenu.Name = "helpMenu";
            helpMenu.Size = new Size(90, 24);
            helpMenu.Text = "&Biblioteca";
            // 
            // controladorBibliotecaOpc
            // 
            controladorBibliotecaOpc.Name = "controladorBibliotecaOpc";
            controladorBibliotecaOpc.Size = new Size(264, 26);
            controladorBibliotecaOpc.Text = "Controlador de Biblioteca";
            // 
            // windowsMenu
            // 
            windowsMenu.DropDownItems.AddRange(new ToolStripItem[] { newWindowToolStripMenuItem, cascadeToolStripMenuItem, tileVerticalToolStripMenuItem, tileHorizontalToolStripMenuItem, closeAllToolStripMenuItem, arrangeIconsToolStripMenuItem });
            windowsMenu.Name = "windowsMenu";
            windowsMenu.Size = new Size(82, 24);
            windowsMenu.Text = "&Ventanas";
            // 
            // newWindowToolStripMenuItem
            // 
            newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            newWindowToolStripMenuItem.Size = new Size(219, 26);
            newWindowToolStripMenuItem.Text = "&Nueva ventana";
            newWindowToolStripMenuItem.Click += ShowNewForm;
            // 
            // cascadeToolStripMenuItem
            // 
            cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            cascadeToolStripMenuItem.Size = new Size(219, 26);
            cascadeToolStripMenuItem.Text = "&Cascada";
            cascadeToolStripMenuItem.Click += CascadeToolStripMenuItem_Click;
            // 
            // tileVerticalToolStripMenuItem
            // 
            tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            tileVerticalToolStripMenuItem.Size = new Size(219, 26);
            tileVerticalToolStripMenuItem.Text = "Mosaico &vertical";
            tileVerticalToolStripMenuItem.Click += TileVerticalToolStripMenuItem_Click;
            // 
            // tileHorizontalToolStripMenuItem
            // 
            tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            tileHorizontalToolStripMenuItem.Size = new Size(219, 26);
            tileHorizontalToolStripMenuItem.Text = "Mosaico &horizontal";
            tileHorizontalToolStripMenuItem.Click += TileHorizontalToolStripMenuItem_Click;
            // 
            // closeAllToolStripMenuItem
            // 
            closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            closeAllToolStripMenuItem.Size = new Size(219, 26);
            closeAllToolStripMenuItem.Text = "C&errar todo";
            closeAllToolStripMenuItem.Click += CloseAllToolStripMenuItem_Click;
            // 
            // arrangeIconsToolStripMenuItem
            // 
            arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            arrangeIconsToolStripMenuItem.Size = new Size(219, 26);
            arrangeIconsToolStripMenuItem.Text = "&Organizar iconos";
            arrangeIconsToolStripMenuItem.Click += ArrangeIconsToolStripMenuItem_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 326);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 19, 0);
            statusStrip.Size = new Size(588, 26);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(54, 20);
            toolStripStatusLabel.Text = "Estado";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 352);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem toolBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private ToolStripMenuItem controlAdminOpc;
        private ToolStripMenuItem mnuReservasOpc;
        private ToolStripMenuItem mnuClientesOpc;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem controladorReservasOpc;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem controladorClientesOpc;
        private ToolStripMenuItem controladorBibliotecaOpc;
    }
}



