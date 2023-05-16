using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto_usando_FormFilho
{
    public partial class FormLOGIN : Form
    {
        public FormLOGIN()
        {
            InitializeComponent();
        }

        private void buttonENTRAR_Click(object sender, EventArgs e)
        {
            try
            {
                ClassMYSQL.conexao.Open();
                ClassMYSQL.comando.CommandText = "SELECT * FROM tbl_usuarios WHERE usuario = '" + textBoxUSUARIO.Text + "' AND senha = '" + textBoxSENHA.Text + "';";
                MySqlDataReader readerLOGIN = ClassMYSQL.comando.ExecuteReader();
                if (readerLOGIN.Read())
                {
                    ClassVARIAVEIS.usuario = readerLOGIN["usuario"].ToString();
                    ClassVARIAVEIS.permissao = readerLOGIN["permissao"].ToString();

                    Form telaPRINCIPAL = new FormPRINCIPAL();
                    telaPRINCIPAL.Show();
                }
                else
                {
                    MessageBox.Show("Usuário e/ou Senha incorretos!");
                }
            }
            catch (Exception erro_mysql)
            {

            }
            finally
            {
                ClassMYSQL.conexao.Close();
            }
        }
    }
}
