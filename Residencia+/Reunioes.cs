public class Reuniao
{
    public string Assunto { get; set; }
    public DateTime DataHora { get; set; }
    public string Local { get; set; }
    public int UnidadeCondominio { get; set; }

    public Reuniao(string assunto, DateTime dataHora, string local, int unidadeCondominio)
    {
        Assunto = assunto;
        DataHora = dataHora;
        Local = local;
        UnidadeCondominio = unidadeCondominio;
    }

    public static void Adicionar(Reuniao reuniao)
    {
        // Adiciona a reuni�o a uma lista
        Reuniao.ListaReuni�es.Add(reuniao);
    }

    private static List<Reuniao> ListaReuni�es = new List<Reuniao>();
}