using System.Security.Cryptography;

namespace JogoDaVida.APPWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        Pessoa pessoa = new Pessoa();

        private void Form1_Load(object sender, EventArgs e)
        {

            labelNome.Text = pessoa.Nome;
            labelId.Text = pessoa.Id;
            labelDataNascimento.Text = $"{pessoa.DataNascimento.ToShortDateString()} (0)" ;
            labelPaisNascimento.Text = pessoa.PaisNascimento;
            labelSexo.Text = pessoa.Sexo;
            labelEtnia.Text = pessoa.Etnia;
            LoadVida();
            LoadData();
        }
        private void LoadData()
        {
            labelAnoAtual.Text = pessoa.DataAtual.ToShortDateString();
        }
        private void LoadVida()
        {
            //Vida
            progressBarFelicidade.Value = pessoa.VidaFelicidade;
            progressBarSaude.Value = pessoa.VidaSaude;
            progressBarBeleza.Value = pessoa.VidaBeleza;
            progressBarIntelecto.Value = pessoa.VidaIntelecto;
            progressBarReputacao.Value = pessoa.VidaReputacao;

            labelDadosFelicidade.Text = progressBarFelicidade.Value.ToString();
            labelDadosSaude.Text = progressBarSaude.Value.ToString();
            labelDadosBeleza.Text = progressBarBeleza.Value.ToString();
            labelDadosIntelecto.Text = progressBarIntelecto.Value.ToString();
            labelDadosReputacao.Text = progressBarReputacao.Value.ToString();
        }

        private void calculaAno()
        {
            var idadeBase = int.Parse(pessoa.DataAtual.Subtract(pessoa.DataNascimento).TotalDays.ToString("0"));
            var idade = 0;
            if(idadeBase > 0)
            {
                idade = (idadeBase / 12)/30;
            }
            
            labelDataNascimento.Text = $"{pessoa.DataNascimento.ToShortDateString()} ({idade})";
        }
        private void buttonPassarAno_Click(object sender, EventArgs e)
        {
            pessoa.DataAtual = pessoa.DataAtual.AddYears(1);
            var r = new Random();

            calculaAno();
            try
            {
                var valorFelicidade = RandomStats(0, 5);
                if ((pessoa.VidaFelicidade + valorFelicidade) > 5 && (pessoa.VidaFelicidade + valorFelicidade) < 95)
                    pessoa.VidaFelicidade += valorFelicidade;
            }
            catch (Exception ex) { }

            try
            {
                var valorSaude = RandomStats(0, 10);
                if ((pessoa.VidaSaude + valorSaude) > 10 && (pessoa.VidaSaude + valorSaude) < 90)
                    pessoa.VidaSaude += valorSaude;
            }
            catch (Exception ex) { }
            try
            {
                var valorBeleza = RandomStats(0, 5);
                if ((pessoa.VidaBeleza + valorBeleza) > 5 && (pessoa.VidaBeleza + valorBeleza) < 95)
                    pessoa.VidaBeleza += valorBeleza;
            }
            catch (Exception ex) { }

            try
            {
                var valorIntelecto = RandomStats(0, 5);
                if ((pessoa.VidaIntelecto + valorIntelecto) > 5 && (pessoa.VidaIntelecto + valorIntelecto) < 95)
                    pessoa.VidaIntelecto += valorIntelecto;
            }
            catch (Exception ex) { }

            try
            {
                var valorReputacao = RandomStats(0, 5);
                if ((pessoa.VidaReputacao + valorReputacao) > 5 && (pessoa.VidaReputacao + valorReputacao) < 95)
                    pessoa.VidaReputacao += valorReputacao;
            }
            catch (Exception ex) { }


            LoadVida();
            LoadData();
        }
        private int RandomStats(int start = 0, int end = 100)
        {
            var r = new Random();

            var retorno = 0;
            var randomToBool = ((r.Next(0, 100)) % 2);
            if (randomToBool == 1)
            {
                //Soma
                retorno = r.Next(start, end);
            }
            else
            {
                //Subtrai
                retorno = (r.Next(start, end)) * -1;
            }
            return retorno;


        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}