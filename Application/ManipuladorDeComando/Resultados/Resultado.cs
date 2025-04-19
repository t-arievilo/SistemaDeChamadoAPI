using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.ManipuladorDeComando.Resultados
{
    public class Resultado<T>
    {
        public bool FoiSucesso { get; set; }
        public T Dados { get; set; }
        public string? Erros { get; set; }

        private Resultado(bool sucesso, string erros, T? dados = default)
        {
            FoiSucesso = sucesso;
            Dados = dados;
            Erros = erros;

        }
        public static Resultado<T> Sucesso(T? dados = default)
        {
            return new Resultado<T> (true, null, default);
        }
        public static Resultado<T> Erro(string erros)
        {
            return new Resultado<T>(false, erros);
        }
    }
}
