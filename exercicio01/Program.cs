using System;
using System.Collections.Generic;
 
namespace exercicio01 {

    class Program {
        static void Main(){

            Stack<int> P = new Stack<int>();
            Stack<int> N = new Stack<int>();

            while (true){
                
                Console.WriteLine("Digite um número: ");
                
                int numero = Convert.ToInt32(Console.ReadLine());
                
                if (numero > 0){
                    P.Push(numero);
                } else if ( numero < 0){
                    N.Push(numero);
                }
                        
                Console.WriteLine("Deseja continuar? (S/N)");
                
                string resposta = Console.ReadLine() ?? "";
                if (resposta.ToLower() == "n"){
                    break;
                }
            }

            MostrarValoresDaPilha(P, "P");
            MostrarValoresDaPilha(N, "N");

            SomaDosValoresDaPilha(P, "P");
            SomaDosValoresDaPilha(N, "N");
            
        }

        public static void MostrarValoresDaPilha(Stack<int> pilha, string nomeDaPilha){
            
            Console.WriteLine("Pilha " + nomeDaPilha + " : ");

            foreach (int numero in pilha){
                Console.WriteLine(numero);
            }

        }

        public static void SomaDosValoresDaPilha(Stack<int> pilha, string nomeDaPilha){
            
            int soma = 0;
            foreach (int numero in pilha){
                soma += numero;
            }
            Console.WriteLine("Soma dos valores da pilha " + nomeDaPilha + " : " + soma);
        }

    }

}