namespace teste_de_crud
{
    public partial class Form1 : Form
    {
        Pokedex pokedex = new Pokedex(10);

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int num = int.Parse(numeroP.Text);
            string nome = nomeP.Text;
            string tipo = tipoP.Text;

            Pokemon pokemon = new Pokemon(num, nome, tipo);
            bool cadastrou = pokedex.Cadastrar(pokemon);
            if (cadastrou == true) { MessageBox.Show("pokemon cadastrado com sucesso!"); }
            else { MessageBox.Show("pokemon não cadastrado! sua pokedex está cheia ou o numero foi repetido"); }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = pokedex.Listar();
        }

        private void btnRenomear_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(numeroP.Text);
            string novoNome = nomeP.Text;

            bool renomeou = pokedex.Renomear(numero, novoNome);

            if (renomeou)
            {
                MessageBox.Show("Pokémon renomeado!");
            }
            else
            {
                MessageBox.Show("Pokémon não encontrado.");
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = pokedex.Listar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(numeroP.Text);

            bool excluiu = pokedex.Excluir(numero);

            if (excluiu)
            {
                MessageBox.Show("Pokémon excluído!");
            }
            else
            {
                MessageBox.Show("Pokémon não encontrado.");
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = pokedex.Listar();
        }

        private void numeroP_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
