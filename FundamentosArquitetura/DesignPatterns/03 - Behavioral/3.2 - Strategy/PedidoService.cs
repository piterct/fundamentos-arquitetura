using DesignPatterns._02___Structural._2._2___Facade.Domain;

namespace DesignPatterns._03___Behavioral._3._2___Strategy
{
    public class PedidoService
    {
        private readonly IPagamento _pagamento;

        public PedidoService(IPagamento pagamento)
        {
            _pagamento = pagamento;
        }

        public Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento)
        {
            return _pagamento.RealizarPagamento(pedido, pagamento);
        }
    }
}
