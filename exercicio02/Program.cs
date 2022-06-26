using System;
using System.Collections.Generic;
 
namespace exercicio02 {

    class Program {
        static void Main(){

            Stack<int> P = new Stack<int>();

            Random random = new Random();

            for (int i = 0; i < 10; i++){
                int numero = random.Next(1, 50);
                if (numero > 0){
                    P.Push(numero);
                }
            }
            MostrarValoresDaPilha(P);

            Console.WriteLine("\nInvertendo a pilha...\n");

            InverterPosicaoDaPilha(P);

        }

        public static void MostrarValoresDaPilha(Stack<int> pilha){
            Console.WriteLine("Pilha: ");
            foreach (int numero in pilha){
                Console.WriteLine(numero);
            }

        }

        public static void InverterPosicaoDaPilha(Stack<int> pilha){
            
            Stack<int> pilhaInvertida = new Stack<int>();

            foreach (int numero in pilha){
                pilhaInvertida.Push(numero);
            }
            
            MostrarValoresDaPilha(pilhaInvertida);
        }

    }

}