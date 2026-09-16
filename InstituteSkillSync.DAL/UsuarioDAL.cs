using InstituteSkillSync.DTO;

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteSkillSync.DAL
{
    public class UsuarioDAL: Conexao
    {
        //autenticar
        public UsuarioDTO Autenticar(string usuario, string senha)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT * FROM Usuario WHERE NomeUsuario = @NomeUsuario AND SenhaUsuario = @SenhaUsuario;", conn);
                cmd.Parameters.AddWithValue("@NomeUsuario", usuario);
                cmd.Parameters.AddWithValue("@SenhaUsuario", senha);
                dr = cmd.ExecuteReader();

                UsuarioDTO _usuario = null;
                if (dr.Read())
                {
                    _usuario = new UsuarioDTO();
                    _usuario.NomeUsuario = dr["NomeUsuario"].ToString();
                    _usuario.SenhaUsuario = dr["SenhaUsuario"].ToString();
                    
                }
                return _usuario;
            }
            catch (Exception ex)
            {

                throw new Exception($"Usuário não cadastrado !! {ex.Message}");
            }
            finally
            {
                Desconectar();
            }

        }

        //pesquisar
        public UsuarioDTO Pesquisar(int id)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT * FROM usuario WHERE IdUsuario = @IdUsuario;", conn);
                cmd.Parameters.AddWithValue("@IdUsuario", id);
                dr = cmd.ExecuteReader();

                UsuarioDTO _id = null;
                if (dr.Read())
                {
                    _id = new UsuarioDTO();
                    _id.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                    _id.NomeUsuario = dr["NomeUsuario"].ToString();
                    _id.SenhaUsuario = dr["SenhaUsuario"].ToString();
                    _id.TelefoneUsuario = dr["TelefoneUsuario"].ToString();
                    _id.EmailUsuario = dr["EmailUsuario"].ToString();
                    
                }
                return _id;
            }
            catch (Exception ex)
            {

                throw new Exception($"Usuário não cadastrado !! {ex.Message}");
            }
            finally
            {
                Desconectar();
            }

        }



        //CRUD
        //Create
        public void Create(UsuarioDTO usuario)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("INSERT INTO Usuario (NomeUsuario, SenhaUsuario, TelefoneUsuario, EmailUsuario) VALUES (@NomeUsuario, @SenhaUsuario, @TelefoneUsuario, @EmailUsuario)", conn);
                cmd.Parameters.AddWithValue("@NomeUsuario", usuario.NomeUsuario);
                cmd.Parameters.AddWithValue("@SenhaUsuario", usuario.SenhaUsuario);
                cmd.Parameters.AddWithValue("@TelefoneUsuario", usuario.TelefoneUsuario);
                cmd.Parameters.AddWithValue("@EmailUsuario", usuario.EmailUsuario); 
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
        public List<UsuarioDTO> Read()
        {
            try
            {
                Conectar();
                cmd = new SqlCommand(" SELECT IdUsuario,NomeUsuario, TelefoneUsuario, EmailUsuario, SenhaUsuario FROM Usuario", conn);
                dr = cmd.ExecuteReader();
                List<UsuarioDTO> Lista = new List<UsuarioDTO>();
                while (dr.Read())
                {
                    UsuarioDTO usuario = new UsuarioDTO();
                    usuario.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                    usuario.NomeUsuario = dr["NomeUsuario"].ToString();
                    usuario.TelefoneUsuario = dr["TelefoneUsuario"].ToString();
                    usuario.EmailUsuario = dr["EmailUsuario"].ToString();
                    usuario.SenhaUsuario = dr["SenhaUsuario"].ToString();
                   
                    Lista.Add(usuario);

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
        public void Update(UsuarioDTO usuario)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand(" UPDATE Usuario SET NomeUsuario=@NomeUsuario, TelefoneUsuario= @TelefoneUsuario, EmailUsuario=@EmailUsuario, SenhaUsuario=@SenhaUsuario WHERE IdUsuario = @IdUsuario;", conn);
                cmd.Parameters.AddWithValue("@IdUsuario", usuario.IdUsuario);
                cmd.Parameters.AddWithValue("@NomeUsuario", usuario.NomeUsuario);
                cmd.Parameters.AddWithValue("@SenhaUsuario", usuario.SenhaUsuario);
                cmd.Parameters.AddWithValue("@TelefoneUsuario", usuario.TelefoneUsuario);
                cmd.Parameters.AddWithValue("@EmailUsuario", usuario.EmailUsuario);
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
        public void Delete(int IdUsuario)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("DELETE FROM Usuario WHERE IdUsuario=@id", conn);
                cmd.Parameters.AddWithValue("@id", IdUsuario);
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
