using System;
using System.Collections.Generic;
 
namespace exercicio03 {

    class Program {
        static void Main(){

            Stack<int> P1 = new Stack<int>();
            Stack<int> P2 = new Stack<int>();

            Random random = new Random();

            for (int i = 0; i < random.Next(1, 30); i++){
                int numero = random.Next(1, 50);
                P1.Push(numero);
            }

            for (int i = 0; i < random.Next(1, 30); i++){
                int numero = random.Next(1, 50);
                P2.Push(numero);
            }

            bool pilha1_eh_maior_que_pilha2 = VerificarSePilha1EhMaiorQuePilha2(P1, P2);

            if (pilha1_eh_maior_que_pilha2){
                Console.WriteLine("A Pilha 1 possui mais elementos que a Pilha 2.");
            } else {
                Console.WriteLine("A Pilha 2 possui mais elementos que a Pilha 1.");
            }

        }

        public static bool VerificarSePilha1EhMaiorQuePilha2(Stack<int> P1, Stack<int> P2){
            
            Console.WriteLine("Pilha 1: "+ P1.Count + " elementos");
            Console.WriteLine("Pilha 2: "+ P2.Count + " elementos");
            
            if (P1.Count > P2.Count){
                return true;
            }
            return false;
        }

    }

}