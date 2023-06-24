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
    }
}