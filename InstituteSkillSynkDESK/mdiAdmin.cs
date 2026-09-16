using InstituteSkillSync.BLL;
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

namespace InstituteSkillSynkDESK
{
    public partial class mdiAdmin : Form
    {
        public mdiAdmin()
        {
            InitializeComponent();
        }

        private void sair_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja realmente sair da aplicação ?", "Atenção! PORRA !", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show($"{Session.NomeOp.ToUpper()} sua sessão será encerrada !", "Atenção PORRA !", MessageBoxButtons.OK);
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCreate relatorioUser = new frmCreate();
            relatorioUser.ShowDialog();
        }

        private void btnCreate2_Click(object sender, EventArgs e)
        {
            frmCurso relatorioUser = new frmCurso();
            relatorioUser.ShowDialog();
        }

        private void msWord_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void notepad_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
        }

        private void calculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorioUsuario relatorioUser = new frmRelatorioUsuario();
            relatorioUser.ShowDialog();
        }

        private void mSWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void relatorioUser_Click(object sender, EventArgs e)
        {
            frmRelatorioUsuario relatorioUser = new frmRelatorioUsuario();
            relatorioUser.ShowDialog();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorioCurso relatorioUser = new frmRelatorioCurso();
            relatorioUser.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmRelatorioCurso relatorioUser = new frmRelatorioCurso();
            relatorioUser.ShowDialog();
        }
    }
}
