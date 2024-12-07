using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoConsole.Models
{
    public class ValidacoesString
    {
        public int QuantidadeCaracteres(string texto)
        {
            int QuantidadeCaracteres = texto.Length;
            return QuantidadeCaracteres;
        }

        public bool ContemCaractere(string texto, string textoProcurado)
        {
            bool ContemCaractere = texto.Contains(textoProcurado); ;
            return ContemCaractere;
        }

        public bool TextoTerminaCom(string texto, string terminaCom)
        {
            bool TextoTerminaCom = texto.EndsWith(terminaCom);
            return TextoTerminaCom;
        }
    }
}