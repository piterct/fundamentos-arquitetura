namespace SOLID._05___DIP.DIP.Solucao.Interfaces
{
    public interface IEmailServices
    {
        void Enviar(string de, string para, string assunto, string mensagem);
    }
}
