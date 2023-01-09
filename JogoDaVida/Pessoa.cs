using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVida
{
    public class Pessoa
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string PaisNascimento { get; set; }
        public string Sexo { get; set; }
        public string Etnia { get; set; }
        //Status da Vida
        public int VidaFelicidade { get; set; }

        public int VidaSaude { get; set; }

        public int VidaIntelecto { get; set; }

        public int VidaBeleza { get; set; }

        public int VidaReputacao { get; set; }
        public DateTime DataAtual { get; set; }

        public Pessoa()
        {
            var r = new Random();

            this.VidaFelicidade = r.Next(0, 100);
            this.VidaSaude = r.Next(0, 100);
            this.VidaIntelecto = r.Next(0, 100);
            this.VidaBeleza = r.Next(0, 100);
            this.VidaReputacao = r.Next(0, 10);

            this.Id = Guid.NewGuid().ToString();
            this.Nome = "João da Silva";
            this.DataNascimento = DateTime.Now;
            this.Sexo = "M";
            this.Etnia = "Branco";
            this.PaisNascimento = "Brasil";
            this.DataAtual = DateTime.Now;
        }
    }
}
