using InstituteSkillSync.BLL;
using InstituteSkillSync.DTO;
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

namespace InstituteSkillSynkDESK
{
    public partial class frmCurso : Form
    {
        CursoDTO curso = new CursoDTO();
        CursoBLL CursoBLL = new CursoBLL();

        public frmCurso()
        {
            InitializeComponent();
        }


        private void frmCurso_Load_1(object sender, EventArgs e)
        {
            txtNomeCurso.Enabled = false;
            txtDescricaoCurso.Enabled = false;
            txtCargaHr.Enabled = false;
            txtTpCurso.Enabled = false;
            txtValor.Enabled = false;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;


        }



        private bool ValidaForm()
        {
            bool valida;
            if (string.IsNullOrEmpty(txtNomeCurso.Text))
            {
                txtNomeCurso.BackColor = Color.Red;
                MessageBox.Show("Digite o nome para o Curso!!!", "Preste Atenção", MessageBoxButtons.OK);
                txtNomeCurso.BackColor = DefaultBackColor;
                txtNomeCurso.Focus();
                valida = false;
            }
            else if (string.IsNullOrEmpty(txtDescricaoCurso.Text))
            {
                txtDescricaoCurso.BackColor = Color.Red;
                MessageBox.Show("Digite uma Descrição para Curso !!!", "Preste Atenção", MessageBoxButtons.OK);
                txtDescricaoCurso.BackColor = DefaultBackColor;
                txtDescricaoCurso.Focus();
                valida = false;
            }
            else if (string.IsNullOrEmpty(txtCargaHr.Text))
            {
                txtCargaHr.BackColor = Color.Red;
                MessageBox.Show("Digite a carga horaria do curso !!!", "Preste Atenção", MessageBoxButtons.OK);
                txtCargaHr.BackColor = DefaultBackColor;
                txtCargaHr.Focus();
                valida = false;
            }
            else if (string.IsNullOrEmpty(txtTpCurso.Text))
            {
                txtTpCurso.BackColor = Color.Red;
                MessageBox.Show("Digite o tipo do curso !!!", "Preste Atenção", MessageBoxButtons.OK);
                txtTpCurso.BackColor = DefaultBackColor;
                txtTpCurso.Focus();
                valida = false;
            }
            else if (string.IsNullOrEmpty(txtValor.Text))
            {
                txtValor.BackColor = Color.Red;
                MessageBox.Show("Digite o Valor !!!", "Preste Atenção", MessageBoxButtons.OK);
                txtValor.BackColor = DefaultBackColor;
                txtValor.Focus();
                valida = false;
            }
            else
            {
                valida = true;
            }
            return valida;

        }


        //cadastra Curso
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
            txtNomeCurso.Enabled = true;
            txtDescricaoCurso.Enabled = true;
            txtCargaHr.Enabled = true;
            txtTpCurso.Enabled = true;
            txtValor.Enabled = true;
            txtId.Enabled = false;
            btnCadastrar.Enabled = false;
            btnEditar.Enabled = false;
            btnPesquisar.Enabled = false;
            btnDeletar.Enabled = false;
        }

       //Fechar
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Clear.ClearControl(this);
            txtNomeCurso.Focus();
            txtId.Enabled = true;
            btnCadastrar.Enabled = true;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            txtNomeCurso.Enabled = false;
            txtDescricaoCurso.Enabled = false;
            txtCargaHr.Enabled = false;
            txtTpCurso.Enabled = false;
            txtValor.Enabled = false;
            txtId.Focus();
        }

        // Editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnCadastrar.Enabled = false;
            txtId.Enabled = false;
            btnSalvar.Enabled = true;
            txtNomeCurso.Enabled = true;
            txtDescricaoCurso.Enabled = true;
            txtCargaHr.Enabled = true;
            txtTpCurso.Enabled = true;
            txtValor.Enabled = true;
        }

        //Salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                if (ValidaForm())
                {
                    curso.NomeCurso = txtNomeCurso.Text.Trim();
                    curso.DescricaoCurso = txtDescricaoCurso.Text.Trim();
                    curso.CargaHrCurso = txtCargaHr.Text.Trim();
                    curso.TpCurso = txtTpCurso.Text.Trim();
                    curso.ValorCurso = txtValor.Text.Trim();

                    CursoBLL.CreateCurso(curso);
                    MessageBox.Show($"Curso {curso.NomeCurso.ToUpper()} cadastrado com sucesso!!");
                    Clear.ClearControl(this);
                } 
            }
            else
            {
                if (ValidaForm())
                {
                    curso.NomeCurso = txtNomeCurso.Text.Trim();
                    curso.DescricaoCurso = txtDescricaoCurso.Text.Trim();
                    curso.CargaHrCurso = txtCargaHr.Text.Trim();
                    curso.TpCurso = txtTpCurso.Text.Trim();
                    curso.ValorCurso = txtValor.Text.Trim();

                    curso.IdCurso = Convert.ToInt32(txtId.Text);
                    CursoBLL.UpdateCurso(curso);
                    MessageBox.Show($"Curso {curso.NomeCurso.ToUpper()} editado com sucesso!!");
                    Clear.ClearControl(this);
                    txtNomeCurso.Focus();
                }
            }

            txtNomeCurso.Enabled = false;
            txtDescricaoCurso.Enabled = false;
            txtCargaHr.Enabled = false;
            txtTpCurso.Enabled = false;
            txtValor.Enabled = false;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnCadastrar.Enabled = true;
            btnPesquisar.Enabled = true;
            btnDeletar.Enabled = true;
            txtId.Enabled = true;
            txtId.Focus();

        }

        // Pesquisar
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            btnCadastrar.Enabled = false;
            txtId.Enabled = false;
            btnEditar.Enabled = false;

            if (string.IsNullOrEmpty(txtId.Text))
            {
                txtId.Enabled = true;
                MessageBox.Show("Digite um Id", "Atenção !!", MessageBoxButtons.OK);
                txtId.Focus();
                return;
            }
            btnEditar.Enabled = true;

            int codigo = Convert.ToInt32(txtId.Text.Trim());
            curso = CursoBLL.PesquisarCurso(codigo);
            if (curso != null)
            {
                btnEditar.Visible = true;


                txtId.Text = curso.IdCurso.ToString();
                txtNomeCurso.Text = curso.NomeCurso.ToString();
                txtDescricaoCurso.Text = curso.DescricaoCurso.ToString();
                txtCargaHr.Text = curso.CargaHrCurso.ToString();
                txtTpCurso.Text = curso.TpCurso.ToString();
                txtValor.Text = curso.ValorCurso.ToString();
            }
            else
            {
                MessageBox.Show("Curso inexistente !!");
                return;
            }
        }

        //Delete
        private void btnDeletar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtId.Text))
            {
                txtId.Enabled = true;
                MessageBox.Show("Digite um Id", "Atenção !!", MessageBoxButtons.OK);
                txtId.Focus();
                return;
            }

            DialogResult msg = MessageBox.Show("Deseja realmente excluir este registro ??", "ATENÇÃO !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (msg == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtId.Text.Trim());
                CursoBLL.DeleteCurso(id);
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

        private void cboxAula_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
