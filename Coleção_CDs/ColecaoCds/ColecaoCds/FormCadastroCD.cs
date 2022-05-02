using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;


namespace ColecaoCds
{
    public partial class FormCadastroCD : Form
    {
        //Conexão com banco Oracle
        string connStr = "Provider=msdaora;Data Source=LOCAL;User Id=curso;Password=123456;";
        OleDbDataAdapter daCd;
        DataSet dsCd;
       
        public FormCadastroCD()
        {
            InitializeComponent();

            //Preencher DataSet
            string sqlQ = "select * from CDS";
            daCd = new OleDbDataAdapter(sqlQ, connStr);
            dsCd = new DataSet("CDS");
            daCd.FillSchema(dsCd, SchemaType.Source);
            daCd.Fill(dsCd);

            //Preencher DataGrid
            dgCadastro.DataSource = dsCd.Tables[0];

            // Nome Colunas DataGridView
            dgCadastro.Columns["id"].HeaderText = "Id";
            dgCadastro.Columns["album"].HeaderText = "Album";
            dgCadastro.Columns["artista"].HeaderText = "Artista";
            dgCadastro.Columns["ano"].HeaderText = "Ano";

            //Insert
            OleDbCommand comInsert;
            string sqlIns = "insert into CDS(id,album,artista,ano) values (?,?,?,?)";
            comInsert = new OleDbCommand(sqlIns);
            comInsert.Parameters.Add(":ID", OleDbType.Numeric, 4, "ID");
            comInsert.Parameters.Add(":ALBUM", OleDbType.VarChar, 25, "ALBUM");
            comInsert.Parameters.Add(":ARTISTA", OleDbType.VarChar, 25, "ARTISTA");
            comInsert.Parameters.Add(":ANO", OleDbType.Numeric, 4, "ANO");
            comInsert.Connection = new OleDbConnection(connStr);
            daCd.InsertCommand = comInsert;

            //Update
            OleDbCommand comUpdate;
            string sqlUp = "update cds set album = ?, artista = ?, ano = ? where id = ?";
            comUpdate = new OleDbCommand(sqlUp);
            comUpdate.Parameters.Add(":ALBUM", OleDbType.VarChar, 25, "ALBUM");
            comUpdate.Parameters.Add(":ARTISTA", OleDbType.VarChar, 25, "ARTISTA");
            comUpdate.Parameters.Add(":ANO", OleDbType.Numeric, 4, "ANO");
            comUpdate.Parameters.Add(":ID", OleDbType.Numeric, 4, "ID");
            comUpdate.Connection = new OleDbConnection(connStr);
            daCd.UpdateCommand = comUpdate;

            //Delete 
            OleDbCommand comDelete;
            string sqlDel = "delete from CDS where id=?";
            comDelete = new OleDbCommand(sqlDel);
            comDelete.Parameters.Add(":ID", OleDbType.Numeric, 4, "ID");
            comDelete.Connection = new OleDbConnection(connStr);
            daCd.DeleteCommand = comDelete;
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?" + "\n" + "Todas as informações não salvas serão perdidas!", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            tbId.Clear();
            tbAlbum.Clear();
            tbArtista.Clear();
            tbAno.Clear();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            //Criar uma linha na tabela CDs no projeto DataSet
            DataRow insert = dsCd.Tables[0].NewRow();

            //Adicionar os respectivos valores do textboxes na linha
            insert["ID"] = tbId.Text;
            insert["ALBUM"] = tbAlbum.Text;
            insert["ARTISTA"] = tbArtista.Text;
            insert["ANO"] = tbAno.Text;

            //Solicitar ao DataAdapter que insira dados na base de dados
            dsCd.Tables[0].Rows.Add(insert);
            daCd.Update(dsCd);

            Clear(); // Limpa Campos
            MessageBox.Show("Cadastro realizado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);          
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            //Devemos procurar no DataSet pela linha equivalente a chave primária e realizar a exclusão
            int id = int.Parse(tbId.Text);

            DataRow reg = dsCd.Tables[0].Rows.Find(id);
            reg.Delete();
            daCd.Update(dsCd);

            Clear(); // Limpa Campos
            MessageBox.Show("Cadastro excluido com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            //Devemos manipular o comando Select do DataAdapter, limpar o DateSet e preenche-lo novamente.
            //Buscando pelo Álbum.
            string sqlQ = "select * from cds where id = '" + tbId.Text + "'";
            daCd.SelectCommand = new OleDbCommand(sqlQ);
            daCd.SelectCommand.Connection = new OleDbConnection(connStr);
            dsCd.Clear();
            daCd.Fill(dsCd);
            if (dsCd.Tables[0].Rows.Count > 0)
            {
                DataRow reg = dsCd.Tables[0].Rows[0];
                tbId.Text = reg["ID"].ToString();
                tbAlbum.Text = reg["ALBUM"].ToString();
                tbArtista.Text = reg["ARTISTA"].ToString();
                tbAno.Text = reg["ANO"].ToString();
            }
            else
            {
                MessageBox.Show("Cadastro não encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tbAlterar_Click(object sender, EventArgs e)
        {
            //Devemos procurar no DataSet pela linha equivalente a chave primária e realizar a alteração
            int id = int.Parse(tbId.Text);
            DataRow reg = dsCd.Tables[0].Rows.Find(id);
            
            reg["ALBUM"] = tbAlbum.Text;
            reg["ARTISTA"] = tbArtista.Text;
            reg["ANO"] = tbAno.Text;
            daCd.Update(dsCd);

            Clear(); // Limpa Campos
            MessageBox.Show("Cadastro atualizado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

      

        private void dgCadastro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Retorna dados do DataGrid para os campos ao clicar na linha
            int linha = dgCadastro.CurrentRow.Index;

            tbId.Text = dgCadastro["id", linha].Value.ToString();
            tbAlbum.Text = dgCadastro["album", linha].Value.ToString();
            tbArtista.Text = dgCadastro["artista", linha].Value.ToString();
            tbAno.Text = dgCadastro["ano", linha].Value.ToString();
        }
    }
}
