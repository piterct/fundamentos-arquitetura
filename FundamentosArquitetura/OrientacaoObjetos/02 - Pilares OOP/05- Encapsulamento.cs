namespace OrientacaoObjetos._02___Pilares_OOP
{
    public class AutomacaoCafe
    {
        public void ServirCafe()
        {
            var espresso = new CafeteiraExpressa();
            espresso.Ligar();
            espresso.PrepararCafe();
            espresso.Desligar();
        }
    }
}
