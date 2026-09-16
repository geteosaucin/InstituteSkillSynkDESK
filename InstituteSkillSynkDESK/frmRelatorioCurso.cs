using DGVPrinterHelper;
using InstituteSkillSync.BLL;
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
    public partial class frmRelatorioCurso : Form
    {
        public frmRelatorioCurso()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
                Close();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            CursoBLL obj = new CursoBLL();
            dgv1.DataSource = obj.ListCurso();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = lblTitulo.Text;
            printer.PageNumbers = true;
            printer.PorportionalColumns = true;
            printer.Footer = DateTime.Now.ToString();
            printer.PrintDataGridView(dgv1);
        }
    }
}
