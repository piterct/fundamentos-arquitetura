using System;

namespace DesignPatterns._02___Structural._2._3___Composite
{
    public class DomainMessage : IMessage
    {
        public string Nome { get; set; }

        public DomainMessage(string name)
        {
            Nome = name;
        }

        public void ExibirMensagens(int sub)
        {
            Console.WriteLine(new string('-', sub) + Nome);
        }
    }
}
