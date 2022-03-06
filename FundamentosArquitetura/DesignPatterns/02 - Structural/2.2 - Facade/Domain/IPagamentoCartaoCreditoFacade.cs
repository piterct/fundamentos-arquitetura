namespace DesignPatterns._02___Structural._2._2___Facade.Domain
{
    public interface IPagamentoCartaoCreditoFacade
    {
        bool RealizarPagamento(Pedido pedido, Pagamento pagamento);
    }
}
