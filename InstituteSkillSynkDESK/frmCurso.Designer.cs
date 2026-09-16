namespace InstituteSkillSynkDESK
{
    partial class frmCurso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTpCurso = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblTpCurso = new System.Windows.Forms.Label();
            this.txtCargaHr = new System.Windows.Forms.TextBox();
            this.lblCargaHr = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtDescricaoCurso = new System.Windows.Forms.TextBox();
            this.lblDescricaoCurso = new System.Windows.Forms.Label();
            this.txtNomeCurso = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDeletar
            // 
            this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletar.Location = new System.Drawing.Point(373, 501);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(102, 38);
            this.btnDeletar.TabIndex = 59;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BackgroundImage = global::InstituteSkillSynkDESK.Properties.Resources.fechar;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(576, 12);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(83, 80);
            this.btnFechar.TabIndex = 58;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(276, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(129, 50);
            this.lblTitulo.TabIndex = 57;
            this.lblTitulo.Text = "Curso";
            // 
            // txtTpCurso
            // 
            this.txtTpCurso.Location = new System.Drawing.Point(199, 274);
            this.txtTpCurso.Name = "txtTpCurso";
            this.txtTpCurso.Size = new System.Drawing.Size(275, 20);
            this.txtTpCurso.TabIndex = 56;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.Location = new System.Drawing.Point(199, 501);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(102, 38);
            this.btnPesquisar.TabIndex = 55;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Location = new System.Drawing.Point(372, 457);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(102, 38);
            this.btnSalvar.TabIndex = 54;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(199, 78);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(57, 20);
            this.txtId.TabIndex = 53;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.ForeColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(196, 62);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 52;
            this.lblId.Text = "Id:";
            // 
            // btnEditar
            // 
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Location = new System.Drawing.Point(199, 457);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(102, 38);
            this.btnEditar.TabIndex = 51;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblTpCurso
            // 
            this.lblTpCurso.AutoSize = true;
            this.lblTpCurso.BackColor = System.Drawing.Color.Transparent;
            this.lblTpCurso.ForeColor = System.Drawing.Color.White;
            this.lblTpCurso.Location = new System.Drawing.Point(196, 258);
            this.lblTpCurso.Name = "lblTpCurso";
            this.lblTpCurso.Size = new System.Drawing.Size(61, 13);
            this.lblTpCurso.TabIndex = 50;
            this.lblTpCurso.Text = "Tipo Curso:";
            // 
            // txtCargaHr
            // 
            this.txtCargaHr.Location = new System.Drawing.Point(199, 225);
            this.txtCargaHr.Name = "txtCargaHr";
            this.txtCargaHr.Size = new System.Drawing.Size(275, 20);
            this.txtCargaHr.TabIndex = 49;
            // 
            // lblCargaHr
            // 
            this.lblCargaHr.AutoSize = true;
            this.lblCargaHr.BackColor = System.Drawing.Color.Transparent;
            this.lblCargaHr.ForeColor = System.Drawing.Color.White;
            this.lblCargaHr.Location = new System.Drawing.Point(196, 209);
            this.lblCargaHr.Name = "lblCargaHr";
            this.lblCargaHr.Size = new System.Drawing.Size(75, 13);
            this.lblCargaHr.TabIndex = 48;
            this.lblCargaHr.Text = "Carga Horaria:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Location = new System.Drawing.Point(373, 413);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 38);
            this.btnCancelar.TabIndex = 47;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Location = new System.Drawing.Point(199, 413);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(102, 38);
            this.btnCadastrar.TabIndex = 46;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtDescricaoCurso
            // 
            this.txtDescricaoCurso.Location = new System.Drawing.Point(199, 176);
            this.txtDescricaoCurso.Name = "txtDescricaoCurso";
            this.txtDescricaoCurso.Size = new System.Drawing.Size(275, 20);
            this.txtDescricaoCurso.TabIndex = 45;
            // 
            // lblDescricaoCurso
            // 
            this.lblDescricaoCurso.AutoSize = true;
            this.lblDescricaoCurso.BackColor = System.Drawing.Color.Transparent;
            this.lblDescricaoCurso.ForeColor = System.Drawing.Color.White;
            this.lblDescricaoCurso.Location = new System.Drawing.Point(196, 160);
            this.lblDescricaoCurso.Name = "lblDescricaoCurso";
            this.lblDescricaoCurso.Size = new System.Drawing.Size(58, 13);
            this.lblDescricaoCurso.TabIndex = 44;
            this.lblDescricaoCurso.Text = "Descrição:";
            // 
            // txtNomeCurso
            // 
            this.txtNomeCurso.Location = new System.Drawing.Point(199, 126);
            this.txtNomeCurso.Name = "txtNomeCurso";
            this.txtNomeCurso.Size = new System.Drawing.Size(275, 20);
            this.txtNomeCurso.TabIndex = 43;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(196, 110);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(68, 13);
            this.lblNome.TabIndex = 42;
            this.lblNome.Text = "Nome Curso:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(199, 322);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(275, 20);
            this.txtValor.TabIndex = 61;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.BackColor = System.Drawing.Color.Transparent;
            this.lblValor.ForeColor = System.Drawing.Color.White;
            this.lblValor.Location = new System.Drawing.Point(196, 306);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(34, 13);
            this.lblValor.TabIndex = 60;
            this.lblValor.Text = "Valor:";
            // 
            // frmCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InstituteSkillSynkDESK.Properties.Resources.programming;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(687, 587);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtTpCurso);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblTpCurso);
            this.Controls.Add(this.txtCargaHr);
            this.Controls.Add(this.lblCargaHr);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtDescricaoCurso);
            this.Controls.Add(this.lblDescricaoCurso);
            this.Controls.Add(this.txtNomeCurso);
            this.Controls.Add(this.lblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCurso";
            this.Opacity = 0.8D;
            this.Text = "frmCurso";
            this.Load += new System.EventHandler(this.frmCurso_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTpCurso;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblTpCurso;
        private System.Windows.Forms.TextBox txtCargaHr;
        private System.Windows.Forms.Label lblCargaHr;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtDescricaoCurso;
        private System.Windows.Forms.Label lblDescricaoCurso;
        private System.Windows.Forms.TextBox txtNomeCurso;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
    }
}