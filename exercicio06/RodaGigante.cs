using System;
using System.Collections.Generic;

public class RodaGigante{
    private const double capacidade_maxima_kg = 3500;
    private const int quantia_minima_de_pessoas = 25;
    private const int quantia_maxima_de_pessoas = 50;

    private double peso_atual = 0;
    
    private Queue<Pessoa> pessoas = new Queue<Pessoa>();


    public void AdicionaPessoa(Pessoa pessoa){
    
        if (this.peso_atual >= capacidade_maxima_kg){
            Console.WriteLine("Não é possível adicionar mais pessoas na roda gigante.");
        } else{
            this.pessoas.Enqueue(pessoa);
        }

    }

    public double CalcularPesoTotalNaRodaGigante(){
        foreach (Pessoa pessoa in this.pessoas){
            this.peso_atual += pessoa.Peso;
        }
        return this.peso_atual;
    }

    public void ExibirPessoasNaRodaGigante(){
        foreach (Pessoa pessoa in this.pessoas){
            Console.WriteLine("Pessoa a bordo: " + pessoa.Nome);
        }
    }

    public int QuantiaDePessoasNaRodaGigante(){
        return this.pessoas.Count;
    }

    public void IniciarPasseioNaRodaGigante(){

        if (this.pessoas.Count < quantia_minima_de_pessoas){

            int faltam_entrar = quantia_minima_de_pessoas - this.pessoas.Count;        
            
            Console.WriteLine("Não é possível iniciar o passeio na roda gigante. Ainda faltam"+ faltam_entrar + " pessoas para entrar.");

        } else if(this.pessoas.Count > quantia_maxima_de_pessoas){
            
            Console.WriteLine("Não é possível iniciar o passeio na roda gigante. A roda gigante já está lotada.");

        } else{
            Console.WriteLine("Passeio iniciado na roda gigante. Ebaaa :-)");

            Console.WriteLine("Passeio finalizado");
            this.peso_atual = 0;
        }
    }


    public void RemovePessoa(){
        if (this.pessoas.Count > 0){
            
            this.pessoas.Dequeue();

            Console.WriteLine("Pessoa removida da roda gigante.");

        } else{
            Console.WriteLine("Não há pessoas na roda gigante para remover.");
        }
    }

}