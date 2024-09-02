namespace ScreenSound.Modelos;

internal class Avaliacao
{
    public Avaliacao(int nota)
    {
        if (nota <= 0) nota = 0;
        if (nota >= 10) nota = 10;
        Nota = nota;
    }

    public int Nota { get; }

    //Neste tipo de cenário, podemos marcar este método como estático. Dessa forma, ele se tornará apenas uma função com elementos autocontidos.
    //Com o static, não precisamos declarar o new e podemos chamar o método diretamente pelo tipo.
    //O static informa que o conteúdo executado não utiliza nenhuma informação da instância desta classe — no caso, Avaliacao.
    public static Avaliacao Parse(string texto)
    {
        int nota = int.Parse(texto);
        return new Avaliacao(nota);

    }
}
