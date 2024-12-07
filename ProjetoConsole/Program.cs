using System.Data;
using ProjetoConsole.Models;

ValidacoesString validacaoString = new();
ValidacoesListas validacaoLista = new();

//Console.WriteLine(validacaoString.QuantidadeCaracteres("Tati"));

//Console.WriteLine(validacaoString.ContemCaractere("banana", "?"));

//Console.WriteLine(validacaoString.TextoTerminaCom("Amanha nao verei novamente", "?"));

/*
List<int> listaNumeros = [-1, 1, -2, 2, -3, 3];
validacaoLista.RemoverNumerosNegativos(listaNumeros);
foreach (var num in listaNumeros)
{
    Console.WriteLine(num);
}
*/

/*
List<int> listaNumeros = [-1, 1, -2, 2, -3, 3];
Console.WriteLine(validacaoLista.ListaContemDeterminadoNumero(listaNumeros, 1));
*/

/*
List<int> listaNumeros = [1, 2, 3, 4, 5, 6, 7, 8, 9];
Console.WriteLine(string.Join(", ", validacaoLista.MultiplicarNumerosLista(listaNumeros, 10).ToList()));
*/

List<int> listaNumeros = [1, 2, 3, 4, -65, 5, 32, 6, 7, 8, 9];
Console.WriteLine(validacaoLista.RetornarMenorNumeroLista(listaNumeros));