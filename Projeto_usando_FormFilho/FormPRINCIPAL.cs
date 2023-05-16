using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_usando_FormFilho
{
    public partial class FormPRINCIPAL : Form
    {
        public FormPRINCIPAL()
        {
            InitializeComponent();

            validaLOGIN();
        }
        private void validaLOGIN()
        {
            labelUSUARIO_user.Text = ClassVARIAVEIS.usuario;

            if (ClassVARIAVEIS.permissao == "admin")
            {
                cadastroToolStripMenuItem.Visible = true;
                labelUSUARIO_icon.Image = Properties.Resources.admin;
            }
            else
            {
                cadastroToolStripMenuItem.Visible = false;
                labelUSUARIO_icon.Image = Properties.Resources.user;
            }
        }

        private void toolStripSplitButtonCADASTRO_ButtonClick(object sender, EventArgs e)
        {
            Form telaCADASTRO = new FormCADASTRO();
            telaCADASTRO.MdiParent = this;
            telaCADASTRO.WindowState = FormWindowState.Maximized;
            telaCADASTRO.Show();
        }

        private void toolStripSplitButtonRELATORIO_ButtonClick(object sender, EventArgs e)
        {
            Form telaRELATORIO = new FormRELATORIO();
            telaRELATORIO.MdiParent = this;
            telaRELATORIO.WindowState = FormWindowState.Maximized;
            telaRELATORIO.Show();
        }       
    }
}
