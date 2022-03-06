using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._02___Structural._2._2___Facade.Domain
{
    public interface IPagamento
    {
        Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento);
    }
}
