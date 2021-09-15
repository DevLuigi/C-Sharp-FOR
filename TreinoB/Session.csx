using System;
using System.Collections.Generic;


public class Pessoa
{
    public string Nome { get; set; }
    public DateTime Nascimento { get; set; }
    public override string ToString()
    {
        return $"( {Nome}, {Nascimento} )";
    }
}

public class TreinoFocadoB
{
    public List<DateTime> GerarSequencia(int qtd)
    {
        List<DateTime> x = new List<DateTime>();
        for(int i = 0; i < qtd; i++)
        {
            DateTime dt = DateTime.Now.AddDays(i);
            x.Add(dt);
        }

        return x;
    }

    public List<DateTime> GerarSequencia(int qtd, DateTime data)
    {
        List<DateTime> x = new List<DateTime>();
        for(int i = 0; i < qtd; i++)
        {
            DateTime dt = data.AddDays(i);
            x.Add(dt);
        }
        return x;
    }

    public List<DateTime> GerarSequenciaDiasPares(int qtd)
    {
        List<DateTime> x = new List<DateTime>();
        for(int i = 0; i <= qtd; i++)
        {
            DateTime dt = DateTime.Now.AddDays(i);
            if(dt.Day % 2 == 0)
            {
                x.Add(dt);
            }
        }
        return x;
    }

    private string Signo(DateTime nascimento)
    {
        string Resultado = string.Empty;

        if (nascimento.Month == 3 && nascimento.Day >= 21 ||
            nascimento.Month == 4 && nascimento.Day <= 20)
        {
            Resultado = $"Seu signo é Áries";
        }

        else if (nascimento.Month == 4 && nascimento.Day >= 21 ||
            nascimento.Month == 5 && nascimento.Day <= 20)
        {
            Resultado = $"Seu signo é Touro";
        }

        else if (nascimento.Month == 5 && nascimento.Day >= 21 ||
            nascimento.Month == 6 && nascimento.Day <= 20)
        {
            Resultado = $"Seu signo é Gêmeos";
        }

         else if (nascimento.Month == 6 && nascimento.Day >= 21 ||
            nascimento.Month == 7 && nascimento.Day <= 22)
        {
            Resultado = $"Seu signo é Câncer";
        }

         else if (nascimento.Month == 7 && nascimento.Day >= 23 ||
            nascimento.Month == 8 && nascimento.Day <= 22)
        {
            Resultado = $"Seu signo é Leão";
        }

         else if (nascimento.Month == 8 && nascimento.Day >= 23 ||
            nascimento.Month == 9 && nascimento.Day <= 22)
        {
            Resultado = $"Seu signo é Virgem";
        }

        else if (nascimento.Month == 9 && nascimento.Day >= 23 ||
            nascimento.Month == 10 && nascimento.Day <= 22)
        {
            Resultado = $"Seu signo é Libra";
        }

        else if (nascimento.Month == 10 && nascimento.Day >= 23 ||
            nascimento.Month == 11 && nascimento.Day <= 21)
        {
            Resultado = $"Seu signo é Escorpião";
        }

        else if (nascimento.Month == 11 && nascimento.Day >= 22 ||
            nascimento.Month == 12 && nascimento.Day <= 21)
        {
            Resultado = $"Seu signo é Sagitário";
        }

        else if (nascimento.Month == 12 && nascimento.Day >= 22 ||
            nascimento.Month == 1 && nascimento.Day <= 20)
        {
            Resultado = $"Seu signo é Capricórnio";
        }

        else if (nascimento.Month == 1 && nascimento.Day >= 21 ||
            nascimento.Month == 2 && nascimento.Day <= 18)
        {
            Resultado = $"Seu signo é Aquário";
        }

        else if (nascimento.Month == 2 && nascimento.Day >= 19 ||
            nascimento.Month == 3 && nascimento.Day <= 20)
        {
            Resultado = $"Seu signo é Peixes";
        }

        return Resultado;
    }

    public List<String> Signos(List<DateTime> nascimentos)
    {
        List<String> x = new List<string>();
        for(int i = 0; i < nascimentos.Count; i++)
        {
            DateTime Ler = nascimentos[i];
            string signo = Signo(Ler);
            x.Add(signo);
        }
        return x;
    }

    public List<Pessoa> FiltrarMaiores18(List<Pessoa> pessoas)
    {
        List<Pessoa> x = new List<Pessoa>();
        for(int i = 0; i < pessoas.Count; i++)
        {
            Pessoa Ler = pessoas[i];
            TimeSpan Maior = DateTime.Now - Ler.Nascimento;
            double idade = Maior.TotalDays / 365;

            if(idade >= 18)
               x.Add(Ler);            
        }
        return x;
    }

    public bool TodosMaiores18(List<Pessoa> pessoas)
    {
        List<Pessoa> x = new List<Pessoa>();
        for(int i = 0; i < pessoas.Count; i++)
        {
            Pessoa Ler = pessoas[i];
            TimeSpan Maior = DateTime.Now - Ler.Nascimento;
            double idade = Maior.TotalDays / 365;

            if(idade >= 18)
            {
                x.Add(Ler);
            }
        }

        bool Maiores = x.Count == pessoas.Count;
        return Maiores;
    }
}

TreinoFocadoB treino02 = new TreinoFocadoB();


List<DateTime> x = treino02.GerarSequencia(2);
Console.WriteLine(String.Join(" --- ", x));



List<DateTime> x2 = treino02.GerarSequencia(2, new DateTime(2021, 06, 20));
Console.WriteLine(String.Join(" --- ", x2));



List<DateTime> x3 = treino02.GerarSequenciaDiasPares(4);
Console.WriteLine(String.Join(" --- ", x3));



List<DateTime> nascimentos = new List<DateTime>();
nascimentos.Add(new DateTime(2004, 04, 26));
nascimentos.Add(new DateTime(2005, 10, 07));

List<String> x4 = treino02.Signos(nascimentos);
Console.WriteLine(String.Join(" --- ", x4));



Pessoa p1 = new Pessoa();
p1.Nome = $"Luigi";
p1.Nascimento = new DateTime(2000, 01, 01);

Pessoa p2 = new Pessoa();
p2.Nome = $"Kaio";
p2.Nascimento = new DateTime(2000, 10, 07);

List<Pessoa> pessoas = new List<Pessoa>();
pessoas.Add(p1);
pessoas.Add(p2);

List<Pessoa> x5 = treino02.FiltrarMaiores18(pessoas);
Console.WriteLine(String.Join(" --- ", x5));


bool x6 = treino02.TodosMaiores18(pessoas);
Console.WriteLine(x6);