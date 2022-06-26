using System;
using System.Collections.Generic;
 
namespace exercicio05 {

    class Program {
        static void Main(){

            Queue<int> Q1 = new Queue<int>();
            Queue<int> Q2 = new Queue<int>();

            Random random = new Random();

            for(int i = 0; i < random.Next(3, 10); i++){
                Q1.Enqueue(random.Next(0, 100));
            }

            for(int i = 0; i < random.Next(3, 10); i++){
                Q2.Enqueue(random.Next(0, 100));
            }

            Console.WriteLine("Fila 1:");
            ExibirElementosDaFila(Q1);
            
            Console.WriteLine("\n");

            Console.WriteLine("Fila 2:");
            ExibirElementosDaFila(Q2);
            
            Console.WriteLine("\n\n");

            bool as_filas_possuem_mesmo_tamanho = VerificarSeFilasPossuemMesmoTamanho(Q1, Q2);
            if (as_filas_possuem_mesmo_tamanho){
                Console.WriteLine("As filas possuem o mesmo tamanho");
                
            } else {
                Console.WriteLine("As filas não possuem o mesmo tamanho");
            }

            bool estaoNaMesmaOrdem = VerificarMesmaOrdemDosElementos(Q1, Q2);
            
            if (estaoNaMesmaOrdem){
                Console.WriteLine("As filas estão na mesma ordem de valores.");

            } else {
                Console.WriteLine("As filas não estão na mesma ordem de valores.");

                bool possuem_os_mesmos_elementos = VerificarSeFilasPossueMesmosElementosEmPosicoesDistintas(Q1, Q2);
                if (possuem_os_mesmos_elementos){
                    Console.WriteLine("As filas possuem os mesmos elementos em posições distintas.");

                } else {
                    Console.WriteLine("As filas não possuem os mesmos elementos em posições distintas.");
                }

            }
            



        }

        public static void ExibirElementosDaFila(Queue<int> fila){

            foreach(int elemento in fila){
                Console.WriteLine(elemento);
            }

        }

        public static bool VerificarMesmaOrdemDosElementos(Queue<int> fila1, Queue<int> fila2){
            
            bool estaoNaMesmaOrdem = true;
            int i = 0;
            
            while(fila1.Count > 0 && fila2.Count > 0){
                if(fila1.Peek() != fila2.Peek()){
                    estaoNaMesmaOrdem = false;
                    break;
                }
                fila1.Dequeue();
                fila2.Dequeue();
                i++;
            }
            
            if(i < fila1.Count || i < fila2.Count){
                estaoNaMesmaOrdem = false;
            }
            return estaoNaMesmaOrdem;
        
        }
    
        public static bool  VerificarSeFilasPossueMesmosElementosEmPosicoesDistintas(Queue<int> fila1, Queue<int> fila2){
             
            if (VerificarSeFilasPossuemMesmoTamanho(fila1, fila2) != true){
                return false;
            } 

            bool mesmos_elementos = true;

            foreach(int elemento in fila1){
                if(fila2.Contains(elemento) != true){
                    mesmos_elementos = false;
                }
            }

            return mesmos_elementos;
        }   


        public static bool VerificarSeFilasPossuemMesmoTamanho(Queue<int> fila1, Queue<int> fila2){
          
            bool temMesmoTamanho = false;

            if (fila1.Count == 0 && fila2.Count == 0){
                Console.WriteLine("As duas filas estão vazias.");    
            }      

            if(fila1.Count == fila2.Count){
                temMesmoTamanho = true;
            }
            return temMesmoTamanho;
        }

    }

}