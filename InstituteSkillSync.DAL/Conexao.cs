
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteSkillSync.DAL
{
    public class Conexao
    {
        //variaveis
        protected SqlConnection conn;
        protected SqlCommand cmd;
        protected SqlDataReader dr;

        //metodos
        protected void Conectar()
        {
            try
            {
                conn = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog=PROJETO12345Context-5b98f6b0-fcc0-49f2-a872-b01f7f037446 ;Integrated Security = true");
                conn.Open();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        protected void Desconectar()
        {
            try
            {

                conn.Close();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

    }
}
