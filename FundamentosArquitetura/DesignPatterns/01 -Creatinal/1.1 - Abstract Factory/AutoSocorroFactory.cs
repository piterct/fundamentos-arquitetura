namespace DesignPatterns._01__Creatinal._1._1___Abstract_Factory
{
    // Abstract Factory
    public abstract class AutoSocorroFactory
    {
        public abstract Guincho CriarGuincho();
        public abstract Veiculo CriarVeiculo(string modelo, Porte porte);
    }
}
