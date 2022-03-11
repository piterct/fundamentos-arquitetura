using DesignPatterns._02___Structural._2._2___Facade.Domain;
using System;
using System.Linq;

namespace DesignPatterns._03___Behavioral._3._2___Strategy
{
    public class PagamentoBoletoService : IPagamento
    {
        private readonly IPagamentoBoletoFacade _pagamentoBoletoFacade;

        public PagamentoBoletoService(IPagamentoBoletoFacade pagamentoBoletoFacade)
        {
            _pagamentoBoletoFacade = pagamentoBoletoFacade;
        }

        public Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento)
        {
            pagamento.Valor = pedido.Produtos.Sum(p => p.Valor);
            Console.WriteLine("Iniciando Pagamento via Boleto - Valor R$ " + pagamento.Valor);


            pagamento.LinhaDigitavelBoleto = _pagamentoBoletoFacade.GerarBoleto();
            pagamento.Status = "Aguardando Pagamento";
            return pagamento;
        }
    }
}
