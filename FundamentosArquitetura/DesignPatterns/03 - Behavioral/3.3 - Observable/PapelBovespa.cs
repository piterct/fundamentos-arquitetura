namespace DesignPatterns._03___Behavioral._3._3___Observable
{
    // Concrete Subject
    public class PapelBovespa : Investimento
    {
        public PapelBovespa(string simbolo, decimal preco)
            : base(simbolo, preco)
        {
        }
    }
}
