using System;
using System.Linq;

namespace DesignPatterns._03___Behavioral._3._2___Strategy
{
    public class PagamentoTransferenciaFacade : IPagamentoTransferenciaFacade
    {
        public string RealizarTransferencia()
        {
            // RealizarTransferencia
            return new string(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 10)
                .Select(s => s[new Random().Next(s.Length)]).ToArray());
        }
    }
}
