using InstituteSkillSync.DTO;

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteSkillSync.DAL
{
    public class OperadorDAL:Conexao
    {
        //autenticar
        public OperadorDTO Autenticar(string operador, string senha)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT * FROM Operador WHERE NomeOp = @NomeOp AND SenhaOp = @SenhaOp;", conn);
                cmd.Parameters.AddWithValue("@NomeOp", operador);
                cmd.Parameters.AddWithValue("@SenhaOp", senha);
                dr = cmd.ExecuteReader();

                OperadorDTO _operador = null;
                if (dr.Read())
                {
                    _operador = new OperadorDTO();
                    _operador.NomeOp = dr["NomeOp"].ToString();
                    _operador.SenhaOp = dr["SenhaOp"].ToString();

                }
                return _operador;
            }
            catch (Exception ex)
            {

                throw new Exception($"Operador não cadastrado !! {ex.Message}");
            }
            finally
            {
                Desconectar();
            }
        }

        //pesquisar
        public OperadorDTO Pesquisar(int id)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT * FROM Operador WHERE IdOp = @IdOperador;", conn);
                cmd.Parameters.AddWithValue("@IdOperador", id);
                dr = cmd.ExecuteReader();

                OperadorDTO _id = null;
                if (dr.Read())
                {
                    _id = new OperadorDTO();
                    _id.IdOp = Convert.ToInt32(dr["IdOperador"]);
                    _id.NomeOp = dr["NomeOperador"].ToString();
                    _id.CpfOp = dr["CpfOp"].ToString();
                    _id.EmailOp = dr["EmailOperador"].ToString();
                    _id.SenhaOp = dr["SenhaOperador"].ToString();
                }
                return _id;
            }
            catch (Exception ex)
            {

                throw new Exception($"Operador não cadastrado !! {ex.Message}");
            }
            finally
            {
                Desconectar();
            }

        }

        //CRUD
        //Create
        public void Create(OperadorDTO operador)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("INSERT INTO Operador (NomeOperador, CpfOperador, EmailOperador, SenhaOperador ) VALUES (@NomeOp, @CpfOp, @EmailOp, @SenhaOp)", conn);
                cmd.Parameters.AddWithValue("@NomeOperador", operador.NomeOp);
                cmd.Parameters.AddWithValue("@CpfOperador", operador.CpfOp);
                cmd.Parameters.AddWithValue("@EmailOperador", operador.EmailOp);
                cmd.Parameters.AddWithValue("@SenhaOperador", operador.SenhaOp);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        //Read
        public List<OperadorDTO> Read()
        {
            try
            {
                Conectar();
                cmd = new SqlCommand(" SELECT IdOp, NomeOp, CpfOp, EmailOp, SenhaOp FROM Operador", conn);
                dr = cmd.ExecuteReader();
                List<OperadorDTO> Lista = new List<OperadorDTO>();
                while (dr.Read())
                {
                    OperadorDTO operador = new OperadorDTO();
                    operador.IdOp = Convert.ToInt32(dr["IdOperador"]);
                    operador.NomeOp = dr["NomeOperador"].ToString();
                    operador.CpfOp = dr["CpfOperador"].ToString();
                    operador.EmailOp = dr["EmailOperador"].ToString();
                    operador.SenhaOp = dr["SenhaOperador"].ToString();

                    Lista.Add(operador);

                }
                return Lista;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        //Update
        public void Update(OperadorDTO operador)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand(" UPDATE Operador SET NomeOperador=@NomeOp, CpfOperador=@CpfOp, EmailOperador=@EmailOp, SenhaOperador=@SenhaOp WHERE IdOperador = @IdOp;", conn);
                cmd.Parameters.AddWithValue("@IdOperador", operador.IdOp);
                cmd.Parameters.AddWithValue("@NomeOperador", operador.NomeOp);
                cmd.Parameters.AddWithValue("@CpfOperador", operador.CpfOp);
                cmd.Parameters.AddWithValue("@EmailOperador", operador.EmailOp);
                cmd.Parameters.AddWithValue("@SenhaOperador", operador.SenhaOp);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        //Delete
        public void Delete(int IdOperador)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("DELETE FROM Operador WHERE IdOperador=@IdOp", conn);
                cmd.Parameters.AddWithValue("@IdOp", IdOperador);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }



    }
}
