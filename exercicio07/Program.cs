using System;
using System.Collections.Generic;
 
namespace exercicio07 {

    class Program {
        
        public enum Mala {
            Frente = 50,
            Lateral = 25,
            Profundidade = 30
        }
        
        
        static void Main(){

            int frente, lateral, profundidade;

            Console.WriteLine("Digite o tamanho da frente da mala em cm: ");
            frente = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o tamanho da lateral da mala em cm: ");
            lateral = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o tamanho da profundidade da mala em cm: ");
            profundidade = int.Parse(Console.ReadLine());


            bool profundidadeValida, lateralValida, frenteValida;
            
            switch(profundidade){
                case (int) Mala.Profundidade:
                    profundidadeValida = true;
                    break;
                default:
                    profundidadeValida = false;
                    break;
            }

            switch(lateral){
                case (int) Mala.Lateral:
                    lateralValida = true;
                    break;
                default:
                    lateralValida = false;
                    break;
            }

            switch(frente){
                case (int) Mala.Frente:
                    frenteValida = true;
                    break;
                default:
                    frenteValida = false;
                    break;
            }

            if(profundidadeValida && lateralValida && frenteValida){
                Console.WriteLine("Mala válida, segundo a ANAC!");
            } else {
                Console.WriteLine("Mala inválida, segundo a ANAC!");
            }


        }


    }

}