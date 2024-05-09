using System;

namespace WorkShopBanco
{
    class Program
    {
        public Cliente cliente;

        static void Main(string[] args)
        {
            // Obtém a hora atual
            DateTime agora = DateTime.Now;

            // Verifica a hora e exibe a saudação apropriada
            if (agora.Hour < 12)
                Console.WriteLine("Bom dia!");
            else if (agora.Hour < 18)
                Console.WriteLine("Boa tarde!");
            else
                Console.WriteLine("Boa noite!");           

            while (true)
            {
                Console.WriteLine("Já é cliente?\n\nSe sim apente   [S]\nSe não precione [N]\n");
                // Lê a tecla pressionada
                ConsoleKeyInfo tecla = Console.ReadKey(true);

                // Verifica se a tecla 'Q' foi pressionada para sair do loop
                if (tecla.Key == ConsoleKey.S)
                    ContemConta();
                else if (tecla.Key == ConsoleKey.N)
                    NaoContemConta();
                else
                {
                    Console.WriteLine("Tecla invalida tente novamente OK");
                    System.Threading.Thread.Sleep(3000);
                }                    
                Console.Clear();
            }
        }

        public static void ContemConta()
        {
            Console.WriteLine("Perfeito então 1º vamos nos identificar?");
            Console.WriteLine("por gentileza qual sua Agencia? ");
            int agencia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("OK!\ne qual a sua Conta?");
            int conta = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Otimo!");
            Console.WriteLine("Agora sim o que deseja?");
            Console.WriteLine("Saber o Saldo     digite [1]");
            Console.WriteLine("Fazer um deposito digite [2]");
            Console.WriteLine("Sacar             digite [3]");
            Convert.ToInt32(Console.ReadLine());
        }

        public static void NaoContemConta()
        {

        }
    }
}
