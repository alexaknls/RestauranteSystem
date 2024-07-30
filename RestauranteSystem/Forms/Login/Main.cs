using RestauranteLib.Controladores.Seguridad;
using RestauranteLib.Seguridad;
using RestauranteSystem.Login;
using RestauranteSystem.Forms.Login.Seguridad.Usuarios;
using RestauranteSystem.Login.Seguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestauranteSystem.Reservas;

namespace RestauranteSystem.Login
{
    public partial class Main : Form
    {
        private int childFormNumber = 0;
        private wwwUsuarios usuarios = new wwwUsuarios();
        private bool isLogged = false;
        private Usuario usuario;
        public Main()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            usuarios.VerificarSeguridad();

            if (!isLogged)
            {
                Login.Seguridad.Login frmLogin = new Seguridad.Login();
                frmLogin.ShowDialog();
                if (frmLogin.UsuarioSession != null && frmLogin.DialogResult == DialogResult.OK)
                {
                    isLogged = true;
                    usuario = frmLogin.UsuarioSession;
                    if (usuarios.IsAuthorized(usuario.ID, "MnuReservas"))
                    {
                        mnuReservasOpc.Visible = false;
                    }
                    toolStripStatusLabel.Text = "Usuario: " + usuario.User;
                }
                else
                {
                    Close();
                }
            }
        }
        
        private void mnuReservasOpc_Click(object sender, EventArgs e)
        {
            frmReservas FrmReservas = new frmReservas();
            FrmReservas.MdiParent = this;
            FrmReservas.Show();
        }
    }
}
