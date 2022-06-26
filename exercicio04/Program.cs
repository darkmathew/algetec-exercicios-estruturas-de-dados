using System;
using System.Collections.Generic;
 
namespace exercicio04 {

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

            bool pilhas_iguais = VerificarSeAsPilhasSaoIguais(P1, P2);

            if (pilhas_iguais){
                Console.WriteLine("As pilhas são iguais.");
            } else {
                Console.WriteLine("As pilhas são diferentes.");
            }

        }

        public static bool VerificarSeAsPilhasSaoIguais(Stack<int> P1, Stack<int> P2){
            
            if (P1.Count != P2.Count){
                return false;

            } else if (P1.Count == 0 && P2.Count == 0){
                Console.WriteLine("As pilhas são nulas. Logo são iguais.");
                return true;

            } else{
                for(int i = 0; i < P1.Count; i++){
                    if (P1.Pop() != P2.Pop()){
                        return false;
                    }
                }
                return true;
            }
        }

    }

}