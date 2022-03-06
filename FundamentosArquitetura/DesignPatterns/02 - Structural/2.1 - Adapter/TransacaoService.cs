namespace DesignPatterns._02___Structural._2._1___Adapter
{
    // Client
    public class TransacaoService
    {
        private readonly ILogger _logger;

        public TransacaoService(ILogger logger)
        {
            _logger = logger;
        }

        public void RealizarTransacao()
        {
            // Transação
            _logger.Log("Transação realizada");
        }
    }
}
