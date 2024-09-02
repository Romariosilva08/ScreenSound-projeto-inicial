namespace ScreenSound.Modelos;

internal interface IAvaliavel
{
    //Entre as chaves da interface, temos um método chamado AdicionarNota() que recebe como argumento uma Avaliacao e o parâmetro nota.
    void AdicionarNota(Avaliacao avaliacao);
    double Media { get; }
}
