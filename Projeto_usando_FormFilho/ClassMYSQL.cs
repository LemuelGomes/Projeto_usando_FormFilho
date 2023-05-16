using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Projeto_usando_FormFilho
{
    internal class ClassMYSQL
    {
        public static string servidor = "Server=localhost;Database=bd_login;Uid=root;Pwd=";
        public static MySqlConnection conexao = new MySqlConnection(servidor);
        public static MySqlCommand comando = conexao.CreateCommand();
    }
}
