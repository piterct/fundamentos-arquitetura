using DesignPatterns._01__Creatinal._1._1___Abstract_Factory;
using DesignPatterns._01__Creatinal._1._2___Factory_Method;
using DesignPatterns._01__Creatinal._1._3_Singleton;
using DesignPatterns._02___Structural._2._1___Adapter;
using DesignPatterns._02___Structural._2._2___Facade;
using DesignPatterns._02___Structural._2._3___Composite;
using DesignPatterns._03___Behavioral._3._1___Command;
using DesignPatterns._03___Behavioral._3._2___Strategy;
using DesignPatterns._03___Behavioral._3._3___Observable;
using System;

namespace DesignPatterns
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Escolha a operação:");
            Console.WriteLine("------------------------");
            Console.WriteLine("Creational Patterns");
            Console.WriteLine("------------------------");
            Console.WriteLine("1 - Abstract Factory");
            Console.WriteLine("2 - Method Factory");
            Console.WriteLine("3 - Singleton");
            Console.WriteLine("------------------------");
            Console.WriteLine("Structural Patterns");
            Console.WriteLine("------------------------");
            Console.WriteLine("4 - Adapter");
            Console.WriteLine("5 - Facade");
            Console.WriteLine("6 - Composite");
            Console.WriteLine("------------------------");
            Console.WriteLine("Behavioral Patterns");
            Console.WriteLine("------------------------");
            Console.WriteLine("7 - Command");
            Console.WriteLine("8 - Strategy");
            Console.WriteLine("9 - Observer");
            Console.WriteLine("------------------------");

            var opcao = Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("------------------------");
            Console.WriteLine("");

            switch (opcao.KeyChar)
            {
                case '1':
                    ExecucaoAbstractFactory.Executar();
                    break;
                case '2':
                    ExecucaoFactoryMethod.Executar();
                    break;
                case '3':
                    ExecucaoSingleton.Executar();
                    break;
                case '4':
                    ExecucaoAdapter.Executar();
                    break;
                case '5':
                    ExecucaoFacade.Executar();
                    break;
                case '6':
                    ExecucaoComposite.Executar();
                    break;
                case '7':
                    ExecucaoCommand.Executar();
                    break;
                case '8':
                    ExecucaoStrategy.Executar();
                    break;
                case '9':
                    ExecucaoObserver.Executar();
                    break;
            }

            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
