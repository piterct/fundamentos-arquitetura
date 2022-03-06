using System;
using System.Collections.Generic;

namespace DesignPatterns._02___Structural._2._2___Facade.Domain
{
    public class Pedido
    {
        public Guid Id { get; set; }
        public decimal Valor { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}
