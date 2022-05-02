namespace ColecaoCds
{
    partial class FormCadastroCD
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
            this.gbColecao = new System.Windows.Forms.GroupBox();
            this.tbAno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbArtista = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAlbum = new System.Windows.Forms.TextBox();
            this.album = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.dgCadastro = new System.Windows.Forms.DataGridView();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.tbAlterar = new System.Windows.Forms.Button();
            this.gbColecao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // gbColecao
            // 
            this.gbColecao.Controls.Add(this.tbAno);
            this.gbColecao.Controls.Add(this.label4);
            this.gbColecao.Controls.Add(this.tbArtista);
            this.gbColecao.Controls.Add(this.label3);
            this.gbColecao.Controls.Add(this.tbAlbum);
            this.gbColecao.Controls.Add(this.album);
            this.gbColecao.Controls.Add(this.tbId);
            this.gbColecao.Controls.Add(this.label2);
            this.gbColecao.Location = new System.Drawing.Point(14, 38);
            this.gbColecao.Name = "gbColecao";
            this.gbColecao.Size = new System.Drawing.Size(454, 129);
            this.gbColecao.TabIndex = 1;
            this.gbColecao.TabStop = false;
            // 
            // tbAno
            // 
            this.tbAno.Location = new System.Drawing.Point(47, 91);
            this.tbAno.Name = "tbAno";
            this.tbAno.Size = new System.Drawing.Size(106, 20);
            this.tbAno.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ano:";
            // 
            // tbArtista
            // 
            this.tbArtista.Location = new System.Drawing.Point(47, 65);
            this.tbArtista.Name = "tbArtista";
            this.tbArtista.Size = new System.Drawing.Size(343, 20);
            this.tbArtista.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Artista:";
            // 
            // tbAlbum
            // 
            this.tbAlbum.Location = new System.Drawing.Point(47, 39);
            this.tbAlbum.Name = "tbAlbum";
            this.tbAlbum.Size = new System.Drawing.Size(343, 20);
            this.tbAlbum.TabIndex = 3;
            // 
            // album
            // 
            this.album.AutoSize = true;
            this.album.Location = new System.Drawing.Point(2, 42);
            this.album.Name = "album";
            this.album.Size = new System.Drawing.Size(39, 13);
            this.album.TabIndex = 2;
            this.album.Text = "Álbum:";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(47, 9);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(106, 20);
            this.tbId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de CD\'s";
            // 
            // btSalvar
            // 
            this.btSalvar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSalvar.Location = new System.Drawing.Point(12, 173);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 34);
            this.btSalvar.TabIndex = 2;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(393, 173);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 34);
            this.btSair.TabIndex = 6;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(312, 173);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 34);
            this.btLimpar.TabIndex = 5;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // dgCadastro
            // 
            this.dgCadastro.AllowUserToAddRows = false;
            this.dgCadastro.AllowUserToDeleteRows = false;
            this.dgCadastro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgCadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCadastro.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgCadastro.Location = new System.Drawing.Point(12, 251);
            this.dgCadastro.Name = "dgCadastro";
            this.dgCadastro.ReadOnly = true;
            this.dgCadastro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCadastro.Size = new System.Drawing.Size(456, 186);
            this.dgCadastro.TabIndex = 8;
            this.dgCadastro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCadastro_CellClick);
            // 
            // btExcluir
            // 
            this.btExcluir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btExcluir.Location = new System.Drawing.Point(93, 173);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 34);
            this.btExcluir.TabIndex = 3;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btBuscar.Location = new System.Drawing.Point(392, 7);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 34);
            this.btBuscar.TabIndex = 7;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // tbAlterar
            // 
            this.tbAlterar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tbAlterar.Location = new System.Drawing.Point(174, 173);
            this.tbAlterar.Name = "tbAlterar";
            this.tbAlterar.Size = new System.Drawing.Size(75, 34);
            this.tbAlterar.TabIndex = 4;
            this.tbAlterar.Text = "Alterar";
            this.tbAlterar.UseVisualStyleBackColor = true;
            this.tbAlterar.Click += new System.EventHandler(this.tbAlterar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 449);
            this.Controls.Add(this.tbAlterar);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.dgCadastro);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbColecao);
            this.Name = "Form1";
            this.Text = "Coleção de CD\'s";
            this.gbColecao.ResumeLayout(false);
            this.gbColecao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCadastro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbColecao;
        private System.Windows.Forms.TextBox tbAno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbArtista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAlbum;
        private System.Windows.Forms.Label album;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.DataGridView dgCadastro;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button tbAlterar;
    }
}

