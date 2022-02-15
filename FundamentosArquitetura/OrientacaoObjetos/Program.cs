using OrientacaoObjetos._02___Pilares_OOP;
using OrientacaoObjetos._04___HerancaVsComposicao;
using OrientacaoObjetos.InterfaceVsImplementacao;
using System;

namespace OrientacaoObjetos
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Escolha a operação:");
            Console.WriteLine("");
            Console.WriteLine("1 - Encapsulamento");
            Console.WriteLine("2 - Heranca Composicao 1");
            Console.WriteLine("3 - Heranca Composicao 2");
            Console.WriteLine("4 - Interface Implementacao");

            var opcao = Console.ReadKey();

            switch (opcao.KeyChar)
            {
                case '1':
                    new AutomacaoCafe().ServirCafe();
                    break;
                case '2':
                    new TestesHerancaComposicao();
                    break;
                case '3':
                    new TestesHerancaComposicao2();
                    break;
                case '4':
                    new TesteInterfaceImplementacao();
                    break;
            }

            Main();
        }
    }
}
