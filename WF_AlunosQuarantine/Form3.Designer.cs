namespace WF_AlunosQuarantine
{
    partial class Form3
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtRM = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtGrito = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTurma = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.pnDelete = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tbRM = new System.Windows.Forms.TextBox();
            this.btnConfirmar2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lbPesquisar = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.RM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TURMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.pnDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnEnviar.Location = new System.Drawing.Point(35, 302);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(77, 37);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtRM
            // 
            this.txtRM.Location = new System.Drawing.Point(35, 96);
            this.txtRM.Name = "txtRM";
            this.txtRM.Size = new System.Drawing.Size(241, 20);
            this.txtRM.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(35, 143);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(241, 20);
            this.txtNome.TabIndex = 2;
            // 
            // txtGrito
            // 
            this.txtGrito.Location = new System.Drawing.Point(35, 243);
            this.txtGrito.Name = "txtGrito";
            this.txtGrito.Size = new System.Drawing.Size(243, 20);
            this.txtGrito.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "RM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome do Aluno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Grito de Guerra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Turma";
            // 
            // txtTurma
            // 
            this.txtTurma.Location = new System.Drawing.Point(35, 193);
            this.txtTurma.Name = "txtTurma";
            this.txtTurma.Size = new System.Drawing.Size(243, 20);
            this.txtTurma.TabIndex = 7;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Salmon;
            this.btnExcluir.Location = new System.Drawing.Point(118, 302);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(77, 37);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // pnDelete
            // 
            this.pnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.pnDelete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnDelete.Controls.Add(this.label5);
            this.pnDelete.Controls.Add(this.tbRM);
            this.pnDelete.Controls.Add(this.btnConfirmar2);
            this.pnDelete.Location = new System.Drawing.Point(200, 302);
            this.pnDelete.Name = "pnDelete";
            this.pnDelete.Size = new System.Drawing.Size(141, 81);
            this.pnDelete.TabIndex = 10;
            this.pnDelete.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Inserir RM do aluno:";
            // 
            // tbRM
            // 
            this.tbRM.Location = new System.Drawing.Point(4, 23);
            this.tbRM.Name = "tbRM";
            this.tbRM.Size = new System.Drawing.Size(132, 20);
            this.tbRM.TabIndex = 10;
            this.tbRM.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnConfirmar2
            // 
            this.btnConfirmar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConfirmar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar2.Location = new System.Drawing.Point(18, 49);
            this.btnConfirmar2.Name = "btnConfirmar2";
            this.btnConfirmar2.Size = new System.Drawing.Size(102, 23);
            this.btnConfirmar2.TabIndex = 11;
            this.btnConfirmar2.Text = "√";
            this.btnConfirmar2.UseVisualStyleBackColor = false;
            this.btnConfirmar2.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-29, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(373, 37);
            this.label6.TabIndex = 23;
            this.label6.Text = "Cadastro do Aluno";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(412, 96);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(222, 20);
            this.txtPesquisa.TabIndex = 24;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // lbPesquisar
            // 
            this.lbPesquisar.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPesquisar.Location = new System.Drawing.Point(412, 65);
            this.lbPesquisar.Name = "lbPesquisar";
            this.lbPesquisar.Size = new System.Drawing.Size(222, 24);
            this.lbPesquisar.TabIndex = 25;
            this.lbPesquisar.Text = "Pesquisar";
            this.lbPesquisar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbPesquisar.Click += new System.EventHandler(this.lbPesquisar_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AccessibleDescription = "";
            this.dataGridView.AccessibleName = "";
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RM,
            this.NOME,
            this.TURMA,
            this.COD});
            this.dataGridView.Location = new System.Drawing.Point(349, 132);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(353, 266);
            this.dataGridView.TabIndex = 26;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // RM
            // 
            this.RM.HeaderText = "RM";
            this.RM.Name = "RM";
            this.RM.Width = 80;
            // 
            // NOME
            // 
            this.NOME.HeaderText = "Nome";
            this.NOME.Name = "NOME";
            // 
            // TURMA
            // 
            this.TURMA.HeaderText = "Turma";
            this.TURMA.Name = "TURMA";
            this.TURMA.Width = 50;
            // 
            // COD
            // 
            this.COD.HeaderText = "Codigo";
            this.COD.Name = "COD";
            this.COD.Width = 80;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnNovo.Location = new System.Drawing.Point(35, 346);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(77, 37);
            this.btnNovo.TabIndex = 27;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnEditar.Location = new System.Drawing.Point(117, 346);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(77, 37);
            this.btnEditar.TabIndex = 28;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(712, 439);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lbPesquisar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTurma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGrito);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtRM);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.pnDelete);
            this.Name = "Form3";
            this.Text = "Cadastro/Aluno";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.pnDelete.ResumeLayout(false);
            this.pnDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtRM;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtGrito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTurma;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Panel pnDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConfirmar2;
        private System.Windows.Forms.TextBox tbRM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lbPesquisar;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RM;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn TURMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnEditar;
    }
}

