using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thiago_Vinícius_DR1_TP3.Pessoas;

namespace Thiago_Vinícius_DR1_TP3.Data
{
    public class BancoDeDados
    {
        public List<Pessoa> lista = new List<Pessoa>
        {
            new Pessoa("Thiago", "Vinícius", "17/04/2002"),
            new Pessoa("Mateus", "Ferrera", "21/07/1999"),
            new Pessoa("Maria", "Lurdes", "30/12/1968"),
        };

        public List<Pessoa> GetDados()
        {
            return (lista);
        }

        public void AddPessoa(string nome, string sobrenome, string dataAniversario)
        {
            lista.Add(new(nome, sobrenome, dataAniversario));
        }
    }
}
