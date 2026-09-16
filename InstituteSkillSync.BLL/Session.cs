using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteSkillSync.BLL
{
    public static class Session
    {
        //usuario
        private static string _nomeOp;


        public static string NomeOp
        {
            get { return Session._nomeOp; }
            set { Session._nomeOp = value; }
        }
    }
}
