using System;
using System.Collections.Generic;
 
namespace exercicio06 {

    class Program {
        static void Main(){

            RodaGigante rodaGigante = new RodaGigante();
            
            while (true){
                
                Console.WriteLine("Digite o nome da pessoa: ");
                string nome = Console.ReadLine();
                
                Console.WriteLine("Digite o peso da pessoa: ");
                double peso = double.Parse(Console.ReadLine());
                
                Pessoa pessoa = new Pessoa();
                pessoa.Nome = nome;
                pessoa.Peso = peso;
                rodaGigante.AdicionaPessoa(pessoa);

                if (rodaGigante.QuantiaDePessoasNaRodaGigante() < 25){

                    int restante_de_pessoas = 25 - rodaGigante.QuantiaDePessoasNaRodaGigante();

                    Console.WriteLine("Restam ao menos"+ restante_de_pessoas + " pessoas para entrar.");

                } else if (rodaGigante.QuantiaDePessoasNaRodaGigante() > 50){
                    
                    Console.WriteLine("Não tem mais espaço na roda gigante. Você deseja remover alguém? (S/N)");
                    
                    string resposta = Console.ReadLine();
                    
                    if (resposta.ToLower() == "s"){
                        rodaGigante.RemovePessoa();
                    } else{
                        break;
                    }
                } else{
                    Console.WriteLine("Já atingimos a quantia mínima de pessoas para o passeio, deseja adicionar mais alguém? (S/N)");
                    string respostaEncerrar = Console.ReadLine();
                    if (respostaEncerrar.ToLower() != "s"){
                        break;
                    }
                }
            }


            double pesoTotalRodaGigante = rodaGigante.CalcularPesoTotalNaRodaGigante();

            Console.WriteLine("Peso total na roda gigante: " + pesoTotalRodaGigante + " kg");


            Console.WriteLine("Quantidade de pessoas na roda gigante: " + rodaGigante.QuantiaDePessoasNaRodaGigante());
            
            rodaGigante.ExibirPessoasNaRodaGigante();

            rodaGigante.IniciarPasseioNaRodaGigante();

        }


    }

}