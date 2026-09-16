using InstituteSkillSync.DTO;
using InstituteSkillSync.DAL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteSkillSync.BLL
{
    public class UsuarioBLL
    {
        UsuarioDAL obj = new UsuarioDAL();

        //autenticar
        public UsuarioDTO AutenticaUsuario(string nome, string senha)
        {
            return obj.Autenticar(nome, senha);
        }

        //listar
        public List<UsuarioDTO> ListUser()
        {
            return obj.Read();
        }

        //createUser
        public void CreateUser(UsuarioDTO user)
        {
            obj.Create(user);

        }


        //pesquisar
        public UsuarioDTO PesquisarUser(int id)
        {
            return obj.Pesquisar(id);
        }

        //Update
        public void UpdateUser(UsuarioDTO usuario)
        {
            obj.Update(usuario);
        }
        // Deletar
        public void DeleteUser(int id)
        {
           obj.Delete(id);
        }

    }
}
