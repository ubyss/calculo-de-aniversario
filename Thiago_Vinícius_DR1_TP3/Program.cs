
using System;
using Thiago_Vinícius_DR1_TP3.Data;
using Thiago_Vinícius_DR1_TP3.Pessoas;

class Program
{
    static void Main(string[] args)
    {
        // Inicialização do banco de dados
        BancoDeDados DadosDeUsuario = new();
        // -------------------------------------

        Console.WriteLine("Gerenciador de Aniversários \n" +
            "Selecione uma das opções abaixo: \n" +
            "1 - Pesquisar pessoas \n" +
            "2 - Adicionar nova pessoa \n" +
            "3 - Sair");

        int numero = Convert.ToInt32(Console.ReadLine());

        if(numero == 1)
        {
            Console.Clear();
            Console.WriteLine("Gerenciador de Aníversários \nDigite o nome, ou parte do nome, da pessoa que deseja encontrar:");
            string InputFiltro = Console.ReadLine();
            List<Pessoa> ListaFiltrada = DadosDeUsuario.GetDados().Where(x => x.Nome.Contains(InputFiltro)).ToList();
            if (ListaFiltrada.Count >= 1)
            {
                foreach (var item in ListaFiltrada)
                {
                    Console.WriteLine($"Dados da pessoa: \n" +
                        $"Nome Completo: {item.Nome} {item.Sobrenome} \n" +
                        $"Data do Aniversário: {item.DataDeAniversario} \n" +
                        $"Faltam {item.CalcularAniversario()} dias para esse aniversário.");
                    Console.ReadLine();
                }
            }
            else Console.WriteLine("Não foram encontradas pessoas");


        } else if (numero == 2)
        {
            Console.Clear();
            Console.WriteLine("Gerenciador de Aniversários \n" +
                "Digite o nome da pesoa que deseja adicionar:");
            string InputNome = Console.ReadLine();
            Console.WriteLine("Digite o sobrenome da pesoa que deseja adicionar:");
            string InputSobrenome = Console.ReadLine();
            Console.WriteLine("Digite a data do aniversário no formato dd/MM/yyyy:");
            string InputData = Console.ReadLine();
            Console.WriteLine($"Os dados abaixo estão corretos? \n" +
                $"Nome: {InputNome} \n" +
                $"Data do aniversário: {InputData} \n" +
                $"1 - Sim \n" +
                $"2-Não");
            string inputSeleção = Console.ReadLine();
            if (inputSeleção == "1")
            {
                DadosDeUsuario.AddPessoa(InputNome, InputSobrenome, InputData);
                Console.WriteLine("Dados adicionados com sucesso");
            }

        } else Console.WriteLine("Aplicação encerrada");
    }
}