using System;
using System.Collections.Generic;


public class Pessoa{
    private string nome;
    private double peso;

    public string Nome{
        get{ return this.nome;}
        set{ this.nome = value;}
    }

    public double Peso{
        get{ return this.peso;}
        set{ this.peso = value;}
    }
    
}