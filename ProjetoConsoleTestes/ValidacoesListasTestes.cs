using ProjetoConsole.Models;

namespace ProjetoConsoleTestes;

public class ValidacoesListasTestes
{
    private ValidacoesListas _validacoesListas;

    public ValidacoesListasTestes()
    {
        _validacoesListas = new ValidacoesListas();
    }

    [Fact]
    public void ListaDeNumeros_RemoverNumerosNegativos_RetornarApenasNumerosPositivos()
    {
        // Arrenge
        List<int> listaNumeros = [-3, -2, -1, 0, 1, 2, 3];
        // Act
        List<int> resultado = _validacoesListas.RemoverNumerosNegativos(listaNumeros);
        // Assert
        foreach (int numero in resultado)
        {
            Assert.True(numero >= 0);
        }
    }

    [Fact]
    public void ListaDeNumeros_BucarNumeroProcurado_RetornarBoolSeContemNumeroProcurado()
    {
        // Arrenge
        List<int> listaNumeros = [-3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        int numeroProcurado = 6;
        // Act
        bool resultado = _validacoesListas.ListaContemDeterminadoNumero(listaNumeros, numeroProcurado);
        // Assert
        Assert.True(resultado);
    }


    [Fact]
    public void ListaDeNumeros_MultiplicaNumerosPorNumeroEscolhido_RetornarListaDeNumerosMultiplicados()
    {
        // Arrenge
        List<int> listaNumeros = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        int numeroProcurado = 2;
        List<int> listaEsperada = listaNumeros.Select(x => x * numeroProcurado).ToList(); //crio a lista que eu espero

        // Act
        List<int> resultado = _validacoesListas.MultiplicarNumerosLista(listaNumeros, numeroProcurado);

        // Assert
        for (int i = 0; i < listaNumeros.Count; i++)
        {
            Assert.Equal(listaEsperada[i], resultado[i]);
        }
    }

    [Fact]
    public void ListaDeNumeros_CapturarMaiorNumeroDaLista_RetornarMaiorNumeroLista()
    {
        // Arrenge
        List<int> listaNumeros = new List<int> { 1, 2, 3, 98, 4, 5, 6, 7, 8, 9, 10 };

        // Act
        int resultado = _validacoesListas.RetornarMaiorNumeroLista(listaNumeros);

        // Assert
        int maiorNumero = int.MinValue;
        foreach (int numero in listaNumeros)
        {
            if (numero > maiorNumero)
            {
                maiorNumero = numero;
            }
        }

        Assert.Equal(resultado, maiorNumero);
    }

    [Fact]
    public void ListaDeNumeros_CapturarMenorNumeroDaLista_RetornarMenorNumeroLista()
    {
        // Arrenge
        List<int> listaNumeros = new List<int> { 1, 2, 3, 98, 4, 5, 6, -17, -2, 7, 8, 9, 10 };

        // Act
        int resultado = _validacoesListas.RetornarMenorNumeroLista(listaNumeros);

        // Assert
        int menorNumero = int.MaxValue;
        foreach (int numero in listaNumeros)
        {
            if (numero < menorNumero)
            {
                menorNumero = numero;
            }
        }

        Assert.Equal(resultado, menorNumero);
    }


}