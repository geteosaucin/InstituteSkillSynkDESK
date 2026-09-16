using InstituteSkillSync.BLL;
using InstituteSkillSync.DTO;
using InstituteSkillSynkDESK.utilities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstituteSkillSynkDESK.UI
{
    public partial class frmCreate : Form
    {

        UsuarioDTO usuario = new UsuarioDTO();
        UsuarioBLL UsuarioBLL = new UsuarioBLL();

        public frmCreate()
        {
            InitializeComponent();
        }


        //load
        private void frmCreate_Load(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtNome.Enabled = false;
            txtSenha.Enabled = false;
            txtEmail.Enabled = false;
            mkdTelefone.Enabled = false; 
            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
        }

        //validacao
        private bool ValidaForm()
        {
            bool valida;
            if (string.IsNullOrEmpty(txtNome.Text) )
            {
                txtNome.BackColor = Color.Red;
                MessageBox.Show("Digite o nome !!!", "Preste Atenção", MessageBoxButtons.OK);
                txtNome.BackColor=DefaultBackColor;
                txtNome.Focus();
                valida = false;
            }
            else if(string.IsNullOrEmpty(txtSenha.Text))
            {
                txtSenha.BackColor = Color.Red;
                MessageBox.Show("Digite a Senha !!!", "Preste Atenção", MessageBoxButtons.OK);
                txtSenha.BackColor = DefaultBackColor;
                txtSenha.Focus();
                valida = false;
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                txtEmail.BackColor = Color.Red;
                MessageBox.Show("Digite o Email !!!", "Preste Atenção", MessageBoxButtons.OK);
                txtEmail.BackColor = DefaultBackColor;
                txtEmail.Focus();
                valida = false;
            }
            else if (string.IsNullOrEmpty(mkdTelefone.Text))
            {
                mkdTelefone.BackColor = Color.Red;
                MessageBox.Show("Digite o Telefone !!!", "Preste Atenção", MessageBoxButtons.OK);
                mkdTelefone.BackColor = DefaultBackColor;
                mkdTelefone.Focus();
                valida = false;
            }
            else
            {
                valida = true;
            }
            return valida;

        }

        //btnClose
        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        //Cadastrar
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
            txtNome.Enabled = true;
            txtSenha.Enabled = true;
            txtEmail.Enabled = true;
            mkdTelefone.Enabled = true;
            txtId.Enabled = false;
            btnCadastrar.Enabled = false;
        }

        //Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Clear.ClearControl(this);
            txtNome.Focus();
            txtId.Enabled = true;
            btnCadastrar.Enabled = true;  
            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            txtNome.Enabled = false;
            txtSenha.Enabled = false;
            txtEmail.Enabled = false;
            mkdTelefone.Enabled = false;
            txtId.Focus();
        }

        //Editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
           btnCadastrar.Enabled = false;
            txtId.Enabled = false;
            btnSalvar.Enabled = true;
            txtNome.Enabled = true;
            txtSenha.Enabled = true;
            txtEmail.Enabled = true;
            mkdTelefone.Enabled = true;
        }






        //Salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtId.Text))
            {
                if (ValidaForm())
                {
                    usuario.NomeUsuario = txtNome.Text.Trim();
                    usuario.SenhaUsuario = txtSenha.Text.Trim();
                    usuario.EmailUsuario = txtEmail.Text.Trim();
                    usuario.TelefoneUsuario = mkdTelefone.Text.Trim();


                    UsuarioBLL.CreateUser(usuario);
                    MessageBox.Show($"usuário {usuario.NomeUsuario.ToUpper()} cadastrado com sucesso!!");
                    Clear.ClearControl(this);
                    txtNome.Focus();
                }
            }
            else
            {
                if (ValidaForm())
                {
                    usuario.NomeUsuario = txtNome.Text.Trim();
                    usuario.SenhaUsuario = txtSenha.Text.Trim();
                    usuario.EmailUsuario = txtEmail.Text.Trim();
                    usuario.TelefoneUsuario = mkdTelefone.Text.Trim();

                    usuario.IdUsuario = Convert.ToInt32(txtId.Text);
                    UsuarioBLL.UpdateUser(usuario);
                    MessageBox.Show($"usuário {usuario.NomeUsuario.ToUpper()} editado com sucesso!!");
                    Clear.ClearControl(this);
                    txtNome.Focus();
                }

                
            }

            btnCadastrar.Enabled = true;
            txtId.Enabled = true;
            txtNome.Enabled = false;
            txtSenha.Enabled = false;
            txtEmail.Enabled = false;
            mkdTelefone.Enabled = false;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            txtId.Focus();

        }

        //Pesquisar
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            btnCadastrar.Enabled=false;
            txtId.Enabled=false;

            if (string.IsNullOrEmpty(txtId.Text))
            {
                txtId.Enabled=true;
                MessageBox.Show("Digite um Id", "Atenção !!", MessageBoxButtons.OK);
                txtId.Focus();
                return;
            }
            btnEditar.Enabled=true;

            int codigo = Convert.ToInt32(txtId.Text.Trim());
            usuario = UsuarioBLL.PesquisarUser(codigo);
            if (usuario != null)
            {
                btnEditar.Visible = true;


                txtId.Text = usuario.IdUsuario.ToString();
                txtNome.Text = usuario.NomeUsuario.ToString();
                txtSenha.Text = usuario.SenhaUsuario.ToString();
                txtEmail.Text = usuario.EmailUsuario.ToString();
                mkdTelefone.Text = usuario.TelefoneUsuario.ToString();
            }
            else
            {
                MessageBox.Show("Usuário inexistente !!");
                return;
            }
        }

        // Deletar
        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtId.Text))
            {
                txtId.Enabled = true;
                MessageBox.Show("Digite um Id", "Atenção !!", MessageBoxButtons.OK);
                txtId.Focus();
                return;
            }

            DialogResult msg = MessageBox.Show("Deseja realmente excluir este registro ??", "ATENÇÃO PORRA!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (msg == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtId.Text.Trim());
                UsuarioBLL.DeleteUser(id);
                Clear.ClearControl(this);
                txtId.Focus();
                MessageBox.Show("Registro eliminado com sucesso !!", "SUCESSO !", MessageBoxButtons.OK);
            }
            else if (msg == DialogResult.No)
            {
                Clear.ClearControl(this);
                txtId.Focus();
            }
        }
    }
}
