namespace WF_AlunosQuarantine
{
    partial class Form4
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
            this.btnExcluir2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtComponente = new System.Windows.Forms.TextBox();
            this.txtNomeProf = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.btnEnviar2 = new System.Windows.Forms.Button();
            this.pnDelete2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMatricula = new System.Windows.Forms.TextBox();
            this.btnconfirmar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lbPesquisar = new System.Windows.Forms.Label();
            this.txtPesquisa2 = new System.Windows.Forms.TextBox();
            this.btnEditar2 = new System.Windows.Forms.Button();
            this.btnNovo2 = new System.Windows.Forms.Button();
            this.matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.componente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnDelete2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluir2
            // 
            this.btnExcluir2.BackColor = System.Drawing.Color.Salmon;
            this.btnExcluir2.Location = new System.Drawing.Point(137, 299);
            this.btnExcluir2.Name = "btnExcluir2";
            this.btnExcluir2.Size = new System.Drawing.Size(77, 37);
            this.btnExcluir2.TabIndex = 20;
            this.btnExcluir2.Text = "Excluir";
            this.btnExcluir2.UseVisualStyleBackColor = false;
            this.btnExcluir2.Click += new System.EventHandler(this.btnExcluir2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Componente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nome do Professor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Matrícula";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtComponente
            // 
            this.txtComponente.Location = new System.Drawing.Point(54, 247);
            this.txtComponente.Name = "txtComponente";
            this.txtComponente.Size = new System.Drawing.Size(248, 20);
            this.txtComponente.TabIndex = 14;
            // 
            // txtNomeProf
            // 
            this.txtNomeProf.Location = new System.Drawing.Point(54, 190);
            this.txtNomeProf.Name = "txtNomeProf";
            this.txtNomeProf.Size = new System.Drawing.Size(248, 20);
            this.txtNomeProf.TabIndex = 13;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(54, 136);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(248, 20);
            this.txtMatricula.TabIndex = 12;
            this.txtMatricula.TextChanged += new System.EventHandler(this.txtRM_TextChanged);
            // 
            // btnEnviar2
            // 
            this.btnEnviar2.BackColor = System.Drawing.Color.YellowGreen;
            this.btnEnviar2.Location = new System.Drawing.Point(55, 299);
            this.btnEnviar2.Name = "btnEnviar2";
            this.btnEnviar2.Size = new System.Drawing.Size(77, 37);
            this.btnEnviar2.TabIndex = 11;
            this.btnEnviar2.Text = "Enviar";
            this.btnEnviar2.UseVisualStyleBackColor = false;
            this.btnEnviar2.Click += new System.EventHandler(this.btnEnviar2_Click);
            // 
            // pnDelete2
            // 
            this.pnDelete2.AutoSize = true;
            this.pnDelete2.BackColor = System.Drawing.SystemColors.Control;
            this.pnDelete2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnDelete2.Controls.Add(this.label5);
            this.pnDelete2.Controls.Add(this.tbMatricula);
            this.pnDelete2.Controls.Add(this.btnconfirmar);
            this.pnDelete2.Location = new System.Drawing.Point(220, 299);
            this.pnDelete2.Name = "pnDelete2";
            this.pnDelete2.Size = new System.Drawing.Size(150, 80);
            this.pnDelete2.TabIndex = 21;
            this.pnDelete2.Visible = false;
            this.pnDelete2.Paint += new System.Windows.Forms.PaintEventHandler(this.pnDelete2_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Inserir N° Matrícula:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tbMatricula
            // 
            this.tbMatricula.Location = new System.Drawing.Point(3, 24);
            this.tbMatricula.Name = "tbMatricula";
            this.tbMatricula.Size = new System.Drawing.Size(142, 20);
            this.tbMatricula.TabIndex = 10;
            // 
            // btnconfirmar
            // 
            this.btnconfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnconfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconfirmar.Location = new System.Drawing.Point(27, 49);
            this.btnconfirmar.Name = "btnconfirmar";
            this.btnconfirmar.Size = new System.Drawing.Size(96, 22);
            this.btnconfirmar.TabIndex = 11;
            this.btnconfirmar.Text = "√";
            this.btnconfirmar.UseVisualStyleBackColor = false;
            this.btnconfirmar.Click += new System.EventHandler(this.btnconfirmar_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 37);
            this.label4.TabIndex = 22;
            this.label4.Text = "Cadastro do Professor";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AccessibleDescription = "";
            this.dataGridView2.AccessibleName = "";
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matricula,
            this.nomep,
            this.componente});
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.Location = new System.Drawing.Point(384, 140);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(343, 266);
            this.dataGridView2.TabIndex = 29;
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // lbPesquisar
            // 
            this.lbPesquisar.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPesquisar.Location = new System.Drawing.Point(437, 65);
            this.lbPesquisar.Name = "lbPesquisar";
            this.lbPesquisar.Size = new System.Drawing.Size(222, 24);
            this.lbPesquisar.TabIndex = 28;
            this.lbPesquisar.Text = "Pesquisar";
            this.lbPesquisar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPesquisa2
            // 
            this.txtPesquisa2.Location = new System.Drawing.Point(437, 96);
            this.txtPesquisa2.Name = "txtPesquisa2";
            this.txtPesquisa2.Size = new System.Drawing.Size(222, 20);
            this.txtPesquisa2.TabIndex = 27;
            this.txtPesquisa2.TextChanged += new System.EventHandler(this.txtPesquisa2_TextChanged);
            // 
            // btnEditar2
            // 
            this.btnEditar2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnEditar2.Location = new System.Drawing.Point(138, 342);
            this.btnEditar2.Name = "btnEditar2";
            this.btnEditar2.Size = new System.Drawing.Size(77, 37);
            this.btnEditar2.TabIndex = 31;
            this.btnEditar2.Text = "Editar";
            this.btnEditar2.UseVisualStyleBackColor = false;
            this.btnEditar2.Click += new System.EventHandler(this.btnEditar2_Click);
            // 
            // btnNovo2
            // 
            this.btnNovo2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnNovo2.Location = new System.Drawing.Point(56, 342);
            this.btnNovo2.Name = "btnNovo2";
            this.btnNovo2.Size = new System.Drawing.Size(77, 37);
            this.btnNovo2.TabIndex = 30;
            this.btnNovo2.Text = "Novo";
            this.btnNovo2.UseVisualStyleBackColor = false;
            this.btnNovo2.Click += new System.EventHandler(this.btnNovo2_Click);
            // 
            // matricula
            // 
            this.matricula.HeaderText = "Matrícula";
            this.matricula.Name = "matricula";
            // 
            // nomep
            // 
            this.nomep.HeaderText = "Nome";
            this.nomep.Name = "nomep";
            // 
            // componente
            // 
            this.componente.HeaderText = "Componente";
            this.componente.Name = "componente";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 438);
            this.Controls.Add(this.btnEditar2);
            this.Controls.Add(this.btnNovo2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.lbPesquisar);
            this.Controls.Add(this.txtPesquisa2);
            this.Controls.Add(this.btnExcluir2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtComponente);
            this.Controls.Add(this.txtNomeProf);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.btnEnviar2);
            this.Controls.Add(this.pnDelete2);
            this.Name = "Form4";
            this.Text = "Cadastro/Professor";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.pnDelete2.ResumeLayout(false);
            this.pnDelete2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcluir2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtComponente;
        private System.Windows.Forms.TextBox txtNomeProf;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Button btnEnviar2;
        private System.Windows.Forms.Panel pnDelete2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMatricula;
        private System.Windows.Forms.Button btnconfirmar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lbPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa2;
        private System.Windows.Forms.Button btnEditar2;
        private System.Windows.Forms.Button btnNovo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomep;
        private System.Windows.Forms.DataGridViewTextBoxColumn componente;
    }
}