using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace ATV_CadastroAlunos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text;
                DateTime dataSql = Convert.ToDateTime(txtData.Text);
                string dataNascimento = Convert.ToString("yyyy-MM-dd");
                string curso = txtCurso.Text;
                string telefone = txtTelefone.Text;

                if (nome != "" && dataNascimento != "" && curso != "" && telefone != "")
                {
                    string conexaoBanco = "Server=localhost; Database=cadastroAlunos; Uid=root; pwd=''";
                    MySqlConnection conexao = new MySqlConnection(conexaoBanco);

                    conexao.Open();

                    string cadastroUsuario = "insert into usuarios (nome, nascimento, curso, telefone) values (@nome, @nascimento, @curso, @telefone)";
                    MySqlCommand comandoSql = new MySqlCommand(cadastroUsuario, conexao);

                    comandoSql.Parameters.AddWithValue("@nome", nome);
                    comandoSql.Parameters.AddWithValue("@dataNascimento", dataNascimento);
                    comandoSql.Parameters.AddWithValue("@curso", curso);
                    comandoSql.Parameters.AddWithValue("@telefone", telefone);

                    int linhasAfetadas = comandoSql.ExecuteNonQuery();
                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show("Cadastro realizado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Erro no cadastro!");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar cadastro" + ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string conexaoBanco = "Server=localhost; Database=cadastroAlunos; Uid=root; pwd=''";
            MySqlConnection conexao = new MySqlConnection(conexaoBanco);

            conexao.Open();
            string listarDados = "select * from usuarios";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(listarDados, conexaoBanco);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridAlunos.DataSource = dataTable;
            dataGridAlunos.AutoResizeColumns();


        }
    }
}
