using CadastroPessoa.Repositorio;

namespace CadastroPessoa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtID_Click(object sender, EventArgs e)
        {

        }

        private void textNOME_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var pessoa = new Pessoa(0, txtNome.Text, txtCpf.Text, txtEmail.Text);
            var pessoaRepositorio = new PessoaRepositorio();
            pessoaRepositorio.Inserir(pessoa);
            LimparCampos();
            BuscarTodasAsPessoas(pessoaRepositorio);
        }

        private void LimparCampos()
        {
            txtId.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtCpf.Text = string.Empty;
        }

        private void BuscarTodasAsPessoas(PessoaRepositorio pessoaRepositorio)//lista as pessoas e insere na grid 
        {
            var pessoas = pessoaRepositorio.BuscarPessoas();
            dgPessoa.DataSource = pessoas.ToList();
        }

        private void Form1_Load(object sender, EventArgs e) //garante q a grid vem com as informações 
        {
            var pessoaRepositorio = new PessoaRepositorio();
            BuscarTodasAsPessoas(pessoaRepositorio);
        }



        private void dgPessoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;

            txtId.Text = dgv.CurrentRow.Cells["Id"]?.Value?.ToString();
            txtNome.Text = dgv.CurrentRow.Cells["Nome"]?.Value?.ToString();
            txtCpf.Text = dgv.CurrentRow.Cells["CPF"]?.Value?.ToString();
            txtEmail.Text = dgv.CurrentRow.Cells["Email"]?.Value?.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var pessoa = new Pessoa(Convert.ToInt32(txtId.Text), txtNome.Text, txtCpf.Text, txtEmail.Text);
            var pRepositorio = new PessoaRepositorio();
            pRepositorio.Atualizar(pessoa);
            LimparCampos();
            BuscarTodasAsPessoas(pRepositorio);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            var pRepositorio = new PessoaRepositorio();
            pRepositorio.Deletar(Convert.ToInt32(txtId.Text));
            LimparCampos();
            BuscarTodasAsPessoas(pRepositorio);
        }
    }
}