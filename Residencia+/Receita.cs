using System;
using System.Collections.Generic;
using System.IO;

public class Receita
{
    public string Descricao { get; set; }
    public decimal Valor { get; set; }
    public DateTime Data { get; set; }
    public int UnidadeCondominio { get; set; }

    private static List<Receita> ListaReceita = new List<Receita>();
    public static string caminhoFicheiro = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "receitas.txt");

    public Receita(string descricao, decimal valor, DateTime data, int unidadeCondominio)
    {
        Descricao = descricao;
        Valor = valor;
        Data = data;
        UnidadeCondominio = unidadeCondominio;
    }

    public static void AdicionarReceita()
    {
        Console.Write("Descri��o da Receita: ");
        string descricao = Console.ReadLine();

        Console.Write("Valor da Receita: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal valor))
        {
            Console.Write("Data da Receita (yyyy-MM-dd): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime data))
            {
                Console.Write("Unidade do Condom�nio: ");
                if (int.TryParse(Console.ReadLine(), out int unidadeCondominio))
                {
                    Receita receita = new Receita(descricao, valor, data, unidadeCondominio);
                    ListaReceita.Add(receita);
                    Console.WriteLine("Receita adicionada com sucesso!");
                    GuardarDadosNoFicheiro(caminhoFicheiro);
                }
                else
                {
                    Console.WriteLine("Unidade do Condom�nio inv�lida.");
                }
            }
            else
            {
                Console.WriteLine("Data inv�lida.");
            }
        }
        else
        {
            Console.WriteLine("Valor da Receita inv�lido.");
        }
    }

    public static List<Receita> ObterTodos()
    {
        CarregarDadosDoFicheiro(caminhoFicheiro);
        return ListaReceita;
    }

    public static void CarregarDadosDoFicheiro(string caminhoFicheiro)
    {
        ListaReceita.Clear();

        if (File.Exists(caminhoFicheiro))
        {
            string[] linhas = File.ReadAllLines(caminhoFicheiro);

            foreach (string linha in linhas)
            {
                string[] dados = linha.Split(',');
                if (dados.Length == 4)
                {
                    Receita receita = new Receita(
                        dados[0].Trim(),
                        decimal.Parse(dados[1].Trim()),
                        DateTime.Parse(dados[2].Trim()),
                        int.Parse(dados[3].Trim())
                    );

                    ListaReceita.Add(receita);
                }
            }
        }
    }

    public static void GuardarDadosNoFicheiro(string caminhoFicheiro)
    {
        using (StreamWriter writer = new StreamWriter(caminhoFicheiro))
        {
            foreach (Receita receita in ListaReceita)
            {
                writer.WriteLine($"{receita.Descricao},{receita.Valor},{receita.Data},{receita.UnidadeCondominio}");
            }
        }
    }
}