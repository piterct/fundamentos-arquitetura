using System;
using System.Linq;

namespace DesignPatterns._03___Behavioral._3._2___Strategy
{
    public class PagamentoBoletoFacade : IPagamentoBoletoFacade
    {
        public string GerarBoleto()
        {
            // GerarBoleto
            return new string(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 10)
                .Select(s => s[new Random().Next(s.Length)]).ToArray());
        }
    }
}
