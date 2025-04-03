using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace ATV_CadastroAlunos
{
    public partial class Form1 : Form
    {
        private int id_aluno = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //CADASTRO
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text;
                string dataNascimento = txtData.Text;
                DateTime dataSql = Convert.ToDateTime(dataNascimento);
                string nascimento = dataSql.ToString("yyyy-MM-dd");

                string curso = txtCurso.Text;
                string telefone = txtTelefone.Text;

                if (nome != "" && nascimento != "" && curso != "" && telefone != "")
                {
                    string conexaoBanco = "Server=localhost; Database=cadastroAlunos; Uid=root; pwd=''";
                    MySqlConnection conexao = new MySqlConnection(conexaoBanco);

                    conexao.Open();

                    string cadastroUsuario = "insert into usuarios (nome, dataNascimento, curso, telefone) values (@nome, @nascimento, @curso, @telefone)";
                    MySqlCommand comandoSql = new MySqlCommand(cadastroUsuario, conexao);

                    comandoSql.Parameters.AddWithValue("@nome", nome);
                    comandoSql.Parameters.AddWithValue("@nascimento", nascimento);
                    comandoSql.Parameters.AddWithValue("@curso", curso);
                    comandoSql.Parameters.AddWithValue("@telefone", telefone);

                    int linhasAfetadas = comandoSql.ExecuteNonQuery();
                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show("Cadastro realizado com sucesso!");
                        txtNome.Clear();
                        txtData.Clear();
                        txtCurso.Clear();
                        txtTelefone.Clear();
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

        //LISTAR
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string conexaoBanco = "Server=localhost; Database=cadastroAlunos; Uid=root; pwd=''; Convert Zero Datetime=True";
                using (MySqlConnection conexao = new MySqlConnection(conexaoBanco))
                {
                    conexao.Open();
                    string listarDados = "SELECT id_alunos, nome, DATE_FORMAT(dataNascimento, '%d/%m/%Y') AS dataNascimento, curso, telefone FROM usuarios";


                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(listarDados, conexao))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        dataGridAlunos.DataSource = dataTable;
                        dataGridAlunos.AutoResizeColumns();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar alunos: " + ex.Message);
            }
        }

        //LIMPAR
        private void button5_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtData.Clear();
            txtCurso.Clear();
            txtTelefone.Clear();
        }

        //EDITAR
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {


                if (id_aluno > 0)
                {
                    string nome = txtNome.Text;
                    string dataNascimento = txtData.Text;
                    DateTime dataSql = Convert.ToDateTime(dataNascimento);
                    string nascimento = dataSql.ToString("yyyy-MM-dd");
                    string curso = txtCurso.Text;
                    string telefone = txtTelefone.Text;

                    string conexaoBanco = "Server=localhost; Database=cadastroAlunos; Uid=root; pwd=''";
                    using (MySqlConnection conexao = new MySqlConnection(conexaoBanco))
                    {
                        conexao.Open();

                        string atualizarDados = "UPDATE usuarios SET nome = @nome, dataNascimento = @nascimento, curso = @curso, telefone = @telefone WHERE id_alunos = @id_aluno";
                        using (MySqlCommand comandoSql = new MySqlCommand(atualizarDados, conexao))
                        {
                            comandoSql.Parameters.AddWithValue("@nome", nome);
                            comandoSql.Parameters.AddWithValue("@nascimento", nascimento);
                            comandoSql.Parameters.AddWithValue("@curso", curso);
                            comandoSql.Parameters.AddWithValue("@telefone", telefone);
                            comandoSql.Parameters.AddWithValue("@id_aluno", id_aluno);

                            int linhasAfetadas = comandoSql.ExecuteNonQuery();
                            if (linhasAfetadas > 0)
                            {
                                MessageBox.Show("Registro atualizado com sucesso!");
                            }
                            else
                            {
                                MessageBox.Show("Erro ao atualizar o registro!");
                            }
                        }
                    }
                }

                else
                {
                    MessageBox.Show("Seecione uma linha");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro!");
            }
        }

        //CLIQUE DUPLO
        private void dataGridAlunos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linhaSelecionada = dataGridAlunos.Rows[e.RowIndex];

                id_aluno = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

                txtNome.Text = linhaSelecionada.Cells["nome"].Value.ToString();
                txtData.Text = Convert.ToDateTime(linhaSelecionada.Cells["dataNascimento"].Value).ToString("dd-MM-yyyy");
                txtCurso.Text = linhaSelecionada.Cells["curso"].Value.ToString();
                txtTelefone.Text = linhaSelecionada.Cells["telefone"].Value.ToString();
            }
        }

        //EXCLUIR
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {


                if (id_aluno > 0)
                {
                    string nome = txtNome.Text;
                    string dataNascimento = txtData.Text;
                    DateTime dataSql = Convert.ToDateTime(dataNascimento);
                    string nascimento = dataSql.ToString("yyyy-MM-dd");
                    string curso = txtCurso.Text;
                    string telefone = txtTelefone.Text;

                    string conexaoBanco = "Server=localhost; Database=cadastroAlunos; Uid=root; pwd=''";
                    using (MySqlConnection conexao = new MySqlConnection(conexaoBanco))
                    {
                        conexao.Open();

                        string atualizarDados = "DELETE FROM usuarios WHERE id_alunos = @id_aluno";
                        using (MySqlCommand comandoSql = new MySqlCommand(atualizarDados, conexao))
                        {
                            comandoSql.Parameters.AddWithValue("@nome", nome);
                            comandoSql.Parameters.AddWithValue("@nascimento", nascimento);
                            comandoSql.Parameters.AddWithValue("@curso", curso);
                            comandoSql.Parameters.AddWithValue("@telefone", telefone);
                            comandoSql.Parameters.AddWithValue("@id_aluno", id_aluno);

                            int linhasAfetadas = comandoSql.ExecuteNonQuery();
                            if (linhasAfetadas > 0)
                            {
                                MessageBox.Show("Registro atualizado com sucesso!");
                            }
                            else
                            {
                                MessageBox.Show("Erro ao atualizar o registro!");
                            }
                        }
                    }
                }

                else
                {
                    MessageBox.Show("Seecione uma linha");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro!");
            }
        }
    }
}
