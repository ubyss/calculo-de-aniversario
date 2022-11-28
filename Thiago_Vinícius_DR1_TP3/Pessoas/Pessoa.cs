using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thiago_Vinícius_DR1_TP3.Pessoas
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string DataDeAniversario { get; set; }

        public int CalcularAniversario()
        {
            int anoAtual = Convert.ToInt32(DateTime.Now.Year);
            string data = DataDeAniversario.Substring(0, 5) + $"/{anoAtual}";
            string dataAtual = String.Format("{0:d}", DateTime.Now);

            int totalDias = (DateTime.Parse(data).Subtract(DateTime.Parse(dataAtual))).Days;

            if(totalDias < 0)
            {
                data = DataDeAniversario.Substring(0, 5) + $"/{anoAtual + 1}";
                totalDias = (DateTime.Parse(data).Subtract(DateTime.Parse(dataAtual))).Days;
                return totalDias;
            }

            return totalDias;
        }

        public Pessoa(string nome, string sobrenome, string data)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            DataDeAniversario = data;
        }
    }
}
