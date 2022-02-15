namespace SOLID._01___SRP.SRP.Solucao
{
    public  class Email
    {
        public string Endereco { get; set; }

        public bool Validar()
        {
            return Endereco.Contains("@");
        }
    }
}
