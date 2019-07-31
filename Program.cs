using System;

namespace ExemploSemaphore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa Iniciado");
            ExemploSemaforo.ThreadOrdenada();
            ExemploSemaforo.ThreadAleatoria();
            Console.WriteLine("Aguarde as threads serem executadas");
            Console.ReadKey();
        }
    }
}
