using System;
using System.Threading;

namespace Nova_atividade
{
    public class Celular
    {
        public string modelo;
        public string cor;
        public string tamanho;
        public bool ligado;

        public bool Ligar()
        {
            int mili = 4000;
            Console.WriteLine("\nIniciando sistema. Aguarde...");
            Thread.Sleep(mili);

            return false;
        }

        public bool Desligar()
        {
            Console.WriteLine("Encerrando sistema...");
            int mili = 4000;
            Thread.Sleep(mili);
            Console.WriteLine("\nAté breve!");
            Console.WriteLine("Sistema finalizado.\n\n");
            return true;
        }

        public void FazerLigacao()
        {
            string numTel;
            string chamada;
            bool encerrar = false;

            Console.Write("Digite o numero do telefone: ");
            numTel = Console.ReadLine();

            Console.Write($"Realizando chamada para {numTel}");

            do
            {
                Console.WriteLine("\n\nAperte X para desligar");
                chamada = Console.ReadLine().ToLower();


                if (chamada == "x")
                {
                    Console.WriteLine("Chamada encerrada com sucesso.");
                    encerrar = true;
                }
            } while (encerrar == false);

        }


        public void EnviarMensagem()
        {
            string numTel;

            Console.Write("Digite o numero do telefone: ");
            numTel = Console.ReadLine();

            Console.WriteLine($"Digite o texto a ser enviado para {numTel}: \n");
            string msg = Console.ReadLine();

            Console.WriteLine("\nEnviar mensagem? (S)im / (N)ão");

            string enviar = Console.ReadLine().ToLower();

            if (enviar == "s")
            {
                Console.WriteLine("\nMensagem enviada com sucesso!\n");
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }


        }


    }
}