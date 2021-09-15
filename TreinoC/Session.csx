using System;
using System.Collections.Generic;

public class Pessoa{
    public string Nome { get; set; }
    public DateTime Nascimento { get; set; }
    public string Cidade { get; set; }
}


public class TreinoFocadoC{

    public string SepararLetras( string frase )
    {
        string x = string.Empty;
        for(int i = 0; i < frase.Length; i++)
        {
            char Ler = frase[i];
            x = x + Ler + "-";
        }
        return x;
    }

    public string Inverter( string frase )
    {
        string x = string.Empty;
        for(int i = 0; i < frase.Length; i++)
        {
            char Ler = frase[i];
            x = Ler + x ;
        }
        return x;
    }

    public bool TodasVogais( string frase)
    {
        bool x = true;
        for( int i = 0; i < frase.Length; i++)
        {
            char Ler = frase[i];  
            if( Ler != 'a' && Ler != 'e' && Ler != 'i' && 
                Ler != 'o' && Ler != 'u' && Ler != 'A' && 
                Ler != 'E' && Ler != 'I' && Ler != 'O' && 
                Ler != 'U')
            {
                x = false;
            }
        }
        return x;
    }

    private string UltimoNome( string nomeCompleto )
    {
        return nomeCompleto.Substring(nomeCompleto.LastIndexOf(" ")).Trim();
    }

    public List<string> UltimosNomes( List<string> nomeCompleto )
    {
        List<string> x = new List<string>();
        for( int i = 0; i < nomeCompleto.Count; i++)
        {
            string Ler = nomeCompleto[i];
            string Nome = UltimoNome(Ler);
            x.Add(Nome);
        }
        return x;
    }

    public bool ApenasCoresPrimarias( List<string> Cores )
    {
        bool cores = true;
        List<string> x = new List<string>();
        for( int i = 0; i < Cores.Count; i++)
        {
            string Ler = Cores[i];
            if( Ler != $"Vermelho" && Ler != $"Amarelo" && Ler != $"Azul")
            {
                cores = false;
            }
        }
        return cores;
    }

    public bool SenhaForte(string senha)
    {
        bool senhaforte = true;
        for(int i = 0; i < senha.Length; i++)
        {
            char Ler = senha[i];
            bool v1 = Char.IsSymbol(Ler);
            bool v2 = Char.IsNumber(Ler); 
            bool v3 = senha.Length >= 8;           
            if(v1 == true && v2 == true && v3 == true)
            {
                senhaforte = true;
            }
        }
        return senhaforte;
    }
}


TreinoFocadoC Treino03 = new TreinoFocadoC();

string x = Treino03.SepararLetras($"Bruno");
Console.WriteLine(x);

string x2 = Treino03.Inverter($"Bruno");
Console.WriteLine(x2);

bool x3 = Treino03.TodasVogais($"eAe");
Console.WriteLine(x3);

List<string> nomeCompleto = new List<string>();
nomeCompleto.Add($"Kaio Silva");
nomeCompleto.Add($"Luigi Silva");
nomeCompleto.Add($"Bruno Oliveira");

List<string> x4 = Treino03.UltimosNomes(nomeCompleto);
Console.WriteLine(string.Join($" - ", x4));


List<string> Cores = new List<string>();

Cores.Add($"Amarelo");
Cores.Add($"Vermelho");
Cores.Add($"Azul");

bool x5 = Treino03.ApenasCoresPrimarias(Cores);
Console.WriteLine(x5);