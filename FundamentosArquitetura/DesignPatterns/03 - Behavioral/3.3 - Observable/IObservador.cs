namespace DesignPatterns._03___Behavioral._3._3___Observable
{
    // Observer
    public interface IObservador
    {
        string Nome { get; }
        void Notificar(Investimento investimento);
    }
}
