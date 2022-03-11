using DesignPatterns._02___Structural._2._2___Facade.Domain;
using System;
using System.Linq;

namespace DesignPatterns._03___Behavioral._3._2___Strategy
{
    public class PagamentoTransferenciaService : IPagamento
    {
        private readonly IPagamentoTransferenciaFacade _pagamentoTransferenciaFacade;

        public PagamentoTransferenciaService(IPagamentoTransferenciaFacade pagamentoTransferenciaFacade)
        {
            _pagamentoTransferenciaFacade = pagamentoTransferenciaFacade;
        }

        public Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento)
        {
            pagamento.Valor = pedido.Produtos.Sum(p => p.Valor);
            Console.WriteLine("Iniciando Pagamento via Transferência - Valor R$ " + pagamento.Valor);

            pagamento.ConfirmacaoTransferencia = _pagamentoTransferenciaFacade.RealizarTransferencia();
            pagamento.Status = "Pago via Transferência";
            return pagamento;
        }
    }
}
