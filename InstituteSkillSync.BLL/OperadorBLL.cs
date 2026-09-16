using InstituteSkillSync.DTO;
using InstituteSkillSync.DAL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteSkillSync.BLL
{
    public class OperadorBLL
    {
        OperadorDAL obj = new OperadorDAL();

        //autenticar
        public OperadorDTO AutenticaOperador(string nome, string senha)
        {
            return obj.Autenticar(nome, senha);
        }

        //listar
        public List<OperadorDTO> ListUser()
        {
            return obj.Read();
        }

         //createOperador
        public void CreateOperador(OperadorDTO operador)
        {
            obj.Create(operador);
        }

        //pesquisar
        public OperadorDTO PesquisarOperador(int id)
        {
            return obj.Pesquisar(id);
        }

        //Update
        public void UpdateOperador(OperadorDTO operador)
        {
            obj.Update(operador);
        }

        // Deletar
        public void DeleteOperador(int id)
        {
            obj.Delete(id);
        }

    }
}
