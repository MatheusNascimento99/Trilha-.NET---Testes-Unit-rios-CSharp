using ProjetoConsole.Models;

namespace ProjetoConsoleTestes;

public class ValidacoesStringTestes
{
    private ValidacoesString _validacoesString;

    public ValidacoesStringTestes()
    {
        _validacoesString = new ValidacoesString();

    }
    // given(contexto) - when(ação) - Then(resultado)

    [Fact]
    public void TextoDeEntrada_ContarCaracteres_RetornarTotalDeCaracteres()
    {
        //Arrenge
        string textoDeEntrada = "Donec porta lorem at augue consequat, eu porta lorem fermentum.";
        //Act
        int numerosCaracteres = _validacoesString.QuantidadeCaracteres(textoDeEntrada);
        //Assert
        Assert.Equal(textoDeEntrada.Length, numerosCaracteres);
    }

    [Fact]
    public void TextoDeEntrada_ProcurarCaracter_RetornarSeExisteCaracter()
    {
        string textoDeEntrada = "Curabitur ante massa, volutpat sit";
        string stringProcurada = "ante";

        bool IsTextoContemString = _validacoesString.ContemCaractere(textoDeEntrada, stringProcurada);

        Assert.True(IsTextoContemString);
    }

    [Fact]
    public void TextoDeEntrada_ProcurarFinalDoTexto_RetornarSeExisteFinalDoTextoDeEntrada()
    {
        string textoDeEntrada = "Curabitur ante massa, volutpat sit";
        string stringFinalDoTexto = "sit";

        bool IsTextoTerminaCom = _validacoesString.TextoTerminaCom(textoDeEntrada, stringFinalDoTexto);

        Assert.True(IsTextoTerminaCom);
    }
}