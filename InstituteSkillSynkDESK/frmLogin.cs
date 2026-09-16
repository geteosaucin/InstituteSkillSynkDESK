using InstituteSkillSync.BLL;
using InstituteSkillSync.DTO;
using InstituteSkillSynkDESK.UI;
using InstituteSkillSynkDESK.utilities;


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace InstituteSkillSynkDESK.UI
{
    public partial class frmLogin : Form
    {

        //criando os objs
        OperadorDTO operador = new OperadorDTO();
        OperadorBLL operadorBLL = new OperadorBLL();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void bntFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Entrar
        private void btnEntrar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                txtNome.Enabled = true;
                MessageBox.Show("Digite um Nome", "Atenção !!", MessageBoxButtons.OK);
                txtNome.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                txtSenha.Enabled = true;
                MessageBox.Show("Digite uma Senha", "Atenção !!", MessageBoxButtons.OK);
                txtSenha.Focus();
                return;
            }


            //pegando as informacoes do usuario
            string nome = txtNome.Text.Trim();
            string senha = txtSenha.Text.Trim();



            //autenticando
            operador = operadorBLL.AutenticaOperador(nome, senha);

            if (operador != null)
            {

                Session.NomeOp = operador.NomeOp.Trim();
                mdiAdmin obj = new mdiAdmin();
                obj.Show();
                this.Visible = false;

            }
            else
            {
                MessageBox.Show("Operador inválidos.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Text = txtSenha.Text = string.Empty;
            txtNome.Focus();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
