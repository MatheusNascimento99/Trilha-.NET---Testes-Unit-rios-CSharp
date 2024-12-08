using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ProjetoConsole.Models
{
    public class ValidacoesListas
    {
        public List<int> RemoverNumerosNegativos(List<int> listaNumeros)
        {
            List<int> listaNumerosPositivos = new List<int>();
            foreach (int numero in listaNumeros)
            {
                if (numero >= 0)
                {
                    listaNumerosPositivos.Add(numero);
                }
            }
            listaNumeros.Clear();
            listaNumeros.AddRange(listaNumerosPositivos);
            return listaNumerosPositivos;
        }

        public bool ListaContemDeterminadoNumero(List<int> listaNumeros, int numeroBuscado)
        {
            bool contemNumero = listaNumeros.Contains(numeroBuscado);
            return contemNumero;
        }

        public List<int> MultiplicarNumerosLista(List<int> listaNumeros, int multiplicador)
        {
            // listaNumeros.Select(numero => numero * multiplicador).ToList(); //código de baixo em 1 linha
            List<int> listaNumerosMultiplicados = new List<int>();
            foreach (int numero in listaNumeros)
            {
                int resultado = numero * multiplicador;
                listaNumerosMultiplicados.Add(resultado);
            }
            listaNumeros.Clear(); //esvazio a lista
            listaNumeros.AddRange(listaNumerosMultiplicados); // preencho ela com os números tratados
            return listaNumeros;
        }

        public int RetornarMaiorNumeroLista(List<int> listaNumeros)
        {
            int maiorNumero = int.MinValue;

            foreach (int numero in listaNumeros)
            {
                if (numero > maiorNumero)
                {
                    maiorNumero = numero;
                }
            }
            return maiorNumero;
        }

        public int RetornarMenorNumeroLista(List<int> listaNumeros)
        {
            int menorNumero = int.MaxValue;
            menorNumero = listaNumeros[0];

            foreach (int numero in listaNumeros)
            {
                if (numero < menorNumero)
                {
                    menorNumero = numero;
                }
            }
            return menorNumero;
        }
    }
}