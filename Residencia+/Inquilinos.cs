using System;
using System.Collections.Generic;

public class Inquilinos
{
    public string Nome { get; set; }
    public string Morada { get; set; }
    public string Contacto { get; set; }
    public int UnidadeCondominio { get; set; }
    public int NumeroIdentificacao { get; set; }

    public Inquilinos(string nome, string morada, string contacto, int unidadeCondominio, int numeroIdentificacao)
    {
        Nome = nome;
        Morada = morada;
        Contacto = contacto;
        UnidadeCondominio = unidadeCondominio;
        NumeroIdentificacao = numeroIdentificacao;
    }

    private static List<Inquilinos> ListaInquilinos = new List<Inquilinos>();

    public static void Adicionar(Inquilinos inquilino)
    {
        ListaInquilinos.Add(inquilino);
    }

    public static List<Inquilinos> ObterTodos()
    {
        return ListaInquilinos;
    }

    public static void InicializarDados()
    {
        Inquilinos inquilino1 = new Inquilinos("Jo�o Cruz", "Condom�nio 1 4�B", "123456789", 1, 197);
        Inquilinos inquilino2 = new Inquilinos("Maria Jordona", "Condom�nio 2 1�D", "987654321", 2, 214);
        Inquilinos inquilino3 = new Inquilinos("Carlos Maia", "Condom�nio 2 2�A", "555666777", 1, 320);
    }
}