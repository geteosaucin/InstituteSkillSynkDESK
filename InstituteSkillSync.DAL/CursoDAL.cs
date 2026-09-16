using InstituteSkillSync.DTO;

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteSkillSync.DAL
{
    public class CursoDAL:Conexao
    {
        //pesquisar
        public CursoDTO Pesquisar(int id)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT * FROM Curso WHERE IdCurso = @IdCurso;", conn);
                cmd.Parameters.AddWithValue("@IdCurso", id);
                dr = cmd.ExecuteReader();

                CursoDTO _id = null;
                if (dr.Read())
                {
                    _id = new CursoDTO();
                    _id.IdCurso = Convert.ToInt32(dr["IdCurso"]);
                    _id.NomeCurso = dr["NomeCurso"].ToString();
                    _id.DescricaoCurso = dr["DescricaoCurso"].ToString();
                    _id.CargaHrCurso = dr["CargaHrCurso"].ToString();
                    _id.ValorCurso = dr["ValorCurso"].ToString();
                    _id.TpCurso = dr["TpCurso"].ToString();
                    
                }
                return _id;
            }
            catch (Exception ex)
            {

                throw new Exception($"Curso não cadastrado !! {ex.Message}");
            }
            finally
            {
                Desconectar();
            }

        }




        //CRUD
        //Create
        public void Create(CursoDTO curso)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("INSERT INTO Curso (NomeCurso,DescricaoCurso,CargaHrCurso,TpCurso,ValorCurso) VALUES (@NomeCurso,@DescricaoCurso,@CargaHrCurso,@TpCurso,@ValorCurso);", conn);
                cmd.Parameters.AddWithValue("@NomeCurso", curso.NomeCurso);
                cmd.Parameters.AddWithValue("@DescricaoCurso", curso.DescricaoCurso);
                cmd.Parameters.AddWithValue("@CargaHrCurso", curso.CargaHrCurso);
                cmd.Parameters.AddWithValue("@TpCurso", curso.TpCurso);
                cmd.Parameters.AddWithValue("@ValorCurso", curso.ValorCurso);
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
        public List<CursoDTO> Read()
        {
            try
            {
                Conectar();
                cmd = new SqlCommand(" SELECT IdCurso, NomeCurso, DescricaoCurso, CargaHrCurso, TpCurso, ValorCurso FROM Curso", conn);
                dr = cmd.ExecuteReader();
                List<CursoDTO> Lista = new List<CursoDTO>();
                while (dr.Read())
                {
                    CursoDTO curso = new CursoDTO();
                    curso.IdCurso = Convert.ToInt32(dr["IdCurso"]);
                    curso.NomeCurso = dr["NomeCurso"].ToString();
                    curso.DescricaoCurso = dr["DescricaoCurso"].ToString();
                    curso.CargaHrCurso = dr["CargaHrCurso"].ToString();
                    curso.TpCurso = dr["TpCurso"].ToString();
                    curso.ValorCurso = dr["ValorCurso"].ToString();
                    
                    Lista.Add(curso);

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
        public void Update(CursoDTO curso)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand(" UPDATE Curso SET NomeCurso=@NomeCurso, DescricaoCurso=@DescricaoCurso, CargaHrCurso=@cargaHoraria, TpCurso=@TipoCurso, ValorCurso=@valorcurso WHERE IdCurso = @IdCurso;", conn);
                cmd.Parameters.AddWithValue("@IdCurso", curso.IdCurso);
                cmd.Parameters.AddWithValue("@NomeCurso", curso.NomeCurso);
                cmd.Parameters.AddWithValue("@DescricaoCurso", curso.DescricaoCurso);
                cmd.Parameters.AddWithValue("@cargaHoraria", curso.CargaHrCurso);
                cmd.Parameters.AddWithValue("@TipoCurso", curso.TpCurso);
                cmd.Parameters.AddWithValue("@valorcurso", curso.ValorCurso);
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
        public void Delete(int IdCurso)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("DELETE FROM Curso WHERE IdCurso=@id", conn);
                cmd.Parameters.AddWithValue("@id", IdCurso);
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
