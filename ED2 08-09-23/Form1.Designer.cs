namespace ED2_08_09_23
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nomeTextfield = new System.Windows.Forms.TextBox();
            this.emailTextfield = new System.Windows.Forms.TextBox();
            this.DiaTextfield = new System.Windows.Forms.TextBox();
            this.anoTextfield = new System.Windows.Forms.TextBox();
            this.MesTextfield = new System.Windows.Forms.TextBox();
            this.contatosGridView = new System.Windows.Forms.DataGridView();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtNasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.tipo = new System.Windows.Forms.Label();
            this.tipoTextfield = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numTexfield = new System.Windows.Forms.TextBox();
            this.principalCheckbox = new System.Windows.Forms.CheckBox();
            this.button6 = new System.Windows.Forms.Button();
            this.telefoneGrid = new System.Windows.Forms.DataGridView();
            this.tipo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.principal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contatoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contatoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contatoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.contatosGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefoneGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatoBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Novo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(235, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(400, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Pesquisar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(565, 43);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Remover";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "E-mail";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data de nascimento";
            // 
            // nomeTextfield
            // 
            this.nomeTextfield.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeTextfield.Location = new System.Drawing.Point(83, 171);
            this.nomeTextfield.Name = "nomeTextfield";
            this.nomeTextfield.Size = new System.Drawing.Size(227, 22);
            this.nomeTextfield.TabIndex = 7;
            // 
            // emailTextfield
            // 
            this.emailTextfield.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextfield.Location = new System.Drawing.Point(84, 117);
            this.emailTextfield.Name = "emailTextfield";
            this.emailTextfield.Size = new System.Drawing.Size(227, 22);
            this.emailTextfield.TabIndex = 8;
            this.emailTextfield.TextChanged += new System.EventHandler(this.emailTextfield_TextChanged);
            // 
            // DiaTextfield
            // 
            this.DiaTextfield.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DiaTextfield.Location = new System.Drawing.Point(36, 307);
            this.DiaTextfield.Name = "DiaTextfield";
            this.DiaTextfield.Size = new System.Drawing.Size(35, 22);
            this.DiaTextfield.TabIndex = 11;
            // 
            // anoTextfield
            // 
            this.anoTextfield.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.anoTextfield.Location = new System.Drawing.Point(134, 307);
            this.anoTextfield.Name = "anoTextfield";
            this.anoTextfield.Size = new System.Drawing.Size(45, 22);
            this.anoTextfield.TabIndex = 12;
            // 
            // MesTextfield
            // 
            this.MesTextfield.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MesTextfield.Location = new System.Drawing.Point(84, 307);
            this.MesTextfield.Name = "MesTextfield";
            this.MesTextfield.Size = new System.Drawing.Size(35, 22);
            this.MesTextfield.TabIndex = 13;
            // 
            // contatosGridView
            // 
            this.contatosGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contatosGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.email,
            this.nome,
            this.dtNasc,
            this.idade,
            this.telefone});
            this.contatosGridView.Location = new System.Drawing.Point(36, 362);
            this.contatosGridView.Name = "contatosGridView";
            this.contatosGridView.RowHeadersWidth = 51;
            this.contatosGridView.RowTemplate.Height = 24;
            this.contatosGridView.Size = new System.Drawing.Size(856, 158);
            this.contatosGridView.TabIndex = 14;
            this.contatosGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // email
            // 
            this.email.HeaderText = "E-mail";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Width = 125;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.MinimumWidth = 6;
            this.nome.Name = "nome";
            this.nome.Width = 125;
            // 
            // dtNasc
            // 
            this.dtNasc.HeaderText = "DtNasc";
            this.dtNasc.MinimumWidth = 6;
            this.dtNasc.Name = "dtNasc";
            this.dtNasc.Width = 125;
            // 
            // idade
            // 
            this.idade.HeaderText = "Idade";
            this.idade.MinimumWidth = 6;
            this.idade.Name = "idade";
            this.idade.Width = 125;
            // 
            // telefone
            // 
            this.telefone.HeaderText = "Telefone";
            this.telefone.MinimumWidth = 6;
            this.telefone.Name = "telefone";
            this.telefone.Width = 125;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(356, 526);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(181, 23);
            this.button5.TabIndex = 15;
            this.button5.Text = "Listar contatos";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tipo
            // 
            this.tipo.AutoSize = true;
            this.tipo.Location = new System.Drawing.Point(315, 307);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(35, 16);
            this.tipo.TabIndex = 16;
            this.tipo.Text = "Tipo";
            this.tipo.Click += new System.EventHandler(this.label4_Click);
            // 
            // tipoTextfield
            // 
            this.tipoTextfield.FormattingEnabled = true;
            this.tipoTextfield.Items.AddRange(new object[] {
            "Móvel",
            "Residencial",
            "Comercial"});
            this.tipoTextfield.Location = new System.Drawing.Point(356, 304);
            this.tipoTextfield.Name = "tipoTextfield";
            this.tipoTextfield.Size = new System.Drawing.Size(35, 24);
            this.tipoTextfield.TabIndex = 17;
            this.tipoTextfield.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Número";
            // 
            // numTexfield
            // 
            this.numTexfield.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numTexfield.Location = new System.Drawing.Point(458, 307);
            this.numTexfield.Name = "numTexfield";
            this.numTexfield.Size = new System.Drawing.Size(111, 22);
            this.numTexfield.TabIndex = 19;
            this.numTexfield.TextChanged += new System.EventHandler(this.numTexfield_TextChanged);
            // 
            // principalCheckbox
            // 
            this.principalCheckbox.AutoSize = true;
            this.principalCheckbox.Location = new System.Drawing.Point(572, 307);
            this.principalCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.principalCheckbox.Name = "principalCheckbox";
            this.principalCheckbox.Size = new System.Drawing.Size(81, 20);
            this.principalCheckbox.TabIndex = 20;
            this.principalCheckbox.Text = "Principal";
            this.principalCheckbox.UseVisualStyleBackColor = true;
            this.principalCheckbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button6
            // 
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button6.Location = new System.Drawing.Point(668, 307);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(73, 23);
            this.button6.TabIndex = 21;
            this.button6.Text = "Adicionar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // telefoneGrid
            // 
            this.telefoneGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.telefoneGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipo1,
            this.num,
            this.principal});
            this.telefoneGrid.Location = new System.Drawing.Point(333, 117);
            this.telefoneGrid.Name = "telefoneGrid";
            this.telefoneGrid.RowHeadersWidth = 51;
            this.telefoneGrid.RowTemplate.Height = 24;
            this.telefoneGrid.Size = new System.Drawing.Size(542, 149);
            this.telefoneGrid.TabIndex = 22;
            this.telefoneGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // tipo1
            // 
            this.tipo1.HeaderText = "Tipo";
            this.tipo1.MinimumWidth = 6;
            this.tipo1.Name = "tipo1";
            this.tipo1.Width = 125;
            // 
            // num
            // 
            this.num.HeaderText = "Número";
            this.num.MinimumWidth = 6;
            this.num.Name = "num";
            this.num.Width = 125;
            // 
            // principal
            // 
            this.principal.HeaderText = "Principal";
            this.principal.MinimumWidth = 6;
            this.principal.Name = "principal";
            this.principal.Width = 125;
            // 
            // contatoBindingSource
            // 
            this.contatoBindingSource.DataSource = typeof(ED2_08_09_23.Contato);
            // 
            // contatoBindingSource1
            // 
            this.contatoBindingSource1.DataSource = typeof(ED2_08_09_23.Contato);
            // 
            // contatoBindingSource2
            // 
            this.contatoBindingSource2.DataSource = typeof(ED2_08_09_23.Contato);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 550);
            this.Controls.Add(this.telefoneGrid);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.principalCheckbox);
            this.Controls.Add(this.numTexfield);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tipoTextfield);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.contatosGridView);
            this.Controls.Add(this.MesTextfield);
            this.Controls.Add(this.anoTextfield);
            this.Controls.Add(this.DiaTextfield);
            this.Controls.Add(this.emailTextfield);
            this.Controls.Add(this.nomeTextfield);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.contatosGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefoneGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatoBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nomeTextfield;
        private System.Windows.Forms.TextBox emailTextfield;
        private System.Windows.Forms.TextBox DiaTextfield;
        private System.Windows.Forms.TextBox anoTextfield;
        private System.Windows.Forms.TextBox MesTextfield;
        private System.Windows.Forms.DataGridView contatosGridView;
        private System.Windows.Forms.BindingSource contatoBindingSource;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource contatoBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtNasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn idade;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.BindingSource contatoBindingSource2;
        private System.Windows.Forms.Label tipo;
        private System.Windows.Forms.ComboBox tipoTextfield;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numTexfield;
        public System.Windows.Forms.CheckBox principalCheckbox;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView telefoneGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn principal;
    }
}

