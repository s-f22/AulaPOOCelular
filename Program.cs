using System;
using System.Threading;

namespace Nova_atividade
{
    class Program
    {
        static bool desligado = true;
        static void Main(string[] args)
        {
            Celular model_1 = new Celular();

            model_1.modelo = "Lg X Power";
            model_1.cor = "Azul";
            model_1.tamanho = "6 pol";

            string p;
            string opcao;

            do
            {
                Console.WriteLine("\nAperte a tecla POWER (P) para ligar.");
                p = Console.ReadLine().ToLower();

                if (p == "p")
                {
                    desligado = model_1.Ligar();
                }
                else
                {
                    Console.WriteLine("Tecla invalida. Tente novamente.");
                }
            } while (desligado == true);

            int mili_a = 2000;
            Console.WriteLine($"\nModelo: {model_1.modelo}");
            Thread.Sleep(mili_a);

            Console.WriteLine($"Cor: {model_1.cor}");
            Thread.Sleep(mili_a);

            int mili_b = 1000;
            Console.WriteLine($"Tamanho: {model_1.tamanho}");
            Thread.Sleep(mili_b);

            Console.WriteLine("\nSistema iniciado com sucesso.");
            Console.WriteLine("\nBem vindo!");

            do
            {
                Console.WriteLine(@"  
|---------------------------------------| 
|            MENU DE FUNÇÕES:           |
|---------------------------------------|
|--------- 1 - FAZER LIGAÇÃO; ----------|
|--------- 2 - ENVIAR MENSAGEM; --------|
|--------- 3 - DESLIGAR; ---------------|
|---------------------------------------|
                ");

                opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    model_1.FazerLigacao();
                }

                if (opcao == "2")
                {
                    model_1.EnviarMensagem();
                }

                if (opcao == "3")
                {
                    desligado = model_1.Desligar();
                }
               

            } while (desligado == false);


        }
    }
}
