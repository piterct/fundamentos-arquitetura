namespace SOLID._04___ISP.ISP.Solucao.Interfaces
{
    public interface ICadastroCliente: ICadastro
    {
        void ValidarDados();
        void EnviarEmail();
    }
}
