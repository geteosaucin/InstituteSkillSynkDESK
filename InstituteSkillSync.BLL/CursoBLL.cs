using InstituteSkillSync.DAL;
using InstituteSkillSync.DTO;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteSkillSync.BLL
{
    public class CursoBLL
    {

        CursoDAL obj = new CursoDAL();

      
        //listar
        public List<CursoDTO> ListCurso()
        {
            return obj.Read();
        }

        //create
        public void CreateCurso(CursoDTO user)
        {
            obj.Create(user);

        }

        //pesquisar
        public CursoDTO PesquisarCurso(int id)
        {
            return obj.Pesquisar(id);
        }

        //Update
        public void UpdateCurso(CursoDTO curso)
        {
            obj.Update(curso);
        }

        // Deletar
        public void DeleteCurso(int id)
        {
            obj.Delete(id);
        }
    }
}
