using System;
using System.Collections.Generic;

public class Condominios
{
    public string Nome { get; set; }
    public string Morada { get; set; }

    private static List<Condominios> ListaCondominios = new List<Condominios>();

    public Condominios(string nome, string morada)
    {
        Nome = nome;
        Morada = morada;

        ListaCondominios.Add(this);
    }

    public static List<Condominios> ObterTodos()
    {
        return ListaCondominios;
    }
    public static void InicializarDados()
    {
        Condominios condo1 = new Condominios("Condom�nio 1", "Rua das Flores 127");
        Condominios condo2 = new Condominios("Condom�nio 2", "Avenida do Sol 453");
    }
}