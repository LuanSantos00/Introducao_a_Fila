using System;
using System.Collections.Generic;

namespace Introducao_a_Fila
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Criando a Fila
            Queue<string> minhaFila = new Queue<string>();

            //Adicionando na Fila
            minhaFila.Enqueue("Primeiro Cliente");
            minhaFila.Enqueue("Segundo Cliente");
            minhaFila.Enqueue("Terceiro Cliente");
            minhaFila.Enqueue("Quarto Cliente");
            minhaFila.Enqueue("Quinto Cliente");

            minhaFila.Dequeue();

            foreach (string elemento in minhaFila)
            {
                Console.WriteLine(elemento);
                minhaFila.Dequeue();
            }

            Console.ReadLine();

        }
    }
}
