using System;
using System.Collections.Generic;
public class Retangulo
{
    public double Basee { get; set; }
    public double Altura { get; set; }
}

public class Notas
{
    public double Nota1 { get; set; }
    public double Nota2 { get; set; }
    public double Nota3 { get; set; }
}

public class TreinoFocadoA{
   public List<int> GerarSquencia(int fim)
   {
       List<int> x = new List<int>();
       for( int i = 0 ; i<= fim ; i++)
            x.Add(i); 

        return x;
   }

   public List<int> GerarSquencia(int inicio, int fim)
   {
       List<int> x = new List<int>();
       for(int i = inicio; i <= fim; i++)
           x.Add(i);
    
      return x;
   }

    public List<int> GerarSquenciaPares(int inicio, int fim)
    {
        List<int> x = new List<int>();
        for( int i = inicio; i <= fim; i++)
        {
            if(i % 2 == 0)
            x.Add(i);
        }
        return x;
    }

    public int SomarAte(int fim)
    {
        int soma = 0;
        for(int i = 0; i <= fim; i++)
        {
            soma += i;
        }
        return soma;
    }

    public double CalcularMedia(List<double> notas)
    {
        double soma = 0;
        for( int i = 0; i < notas.Count; i++)
        {
            double ler = notas[i];
            soma = soma + ler;
        }

        return soma / notas.Count;        
    }

    public List<double> CalcularMedias(List<Notas> notas)
    {
        List<double> x = new List<double>();
        for(int i = 0; i < notas.Count; i++)
        {
            Notas NotasAluno = notas[i];
            double media = (NotasAluno.Nota1 + NotasAluno.Nota2 + NotasAluno.Nota3) / 3;
            x.Add(media);
        }

        return x;
    }

    public List<double> CalcularQuadrados(List<double> numeros)
    {
        List<double> x = new List<double>();
        for( int i = 0; i < numeros.Count; i++)
        {
            double numero = numeros[i];
            double potencia = Math.Pow(numero, 2);
            x.Add(potencia); 
        }
        return x;
    }

    private double AreaRetangulo( Retangulo retangulo)
    {
        return retangulo.Basee * retangulo.Altura;
    }

    public List<double> AreaRetangulos (List<Retangulo> retangulo)
    {
        List<double> x = new List<double>();
        for(int i = 0; i < retangulo.Count; i++)
        {
            Retangulo Ler = retangulo[i];
            double CalcArea = AreaRetangulo(Ler);
            x.Add(CalcArea);
        }

        return x;
    }
}

 

TreinoFocadoA treino1 = new TreinoFocadoA();
List<int> x = treino1.GerarSquencia(5);
Console.WriteLine(string.Join("-", x));

List<int> x2 = treino1.GerarSquencia(2, 4);
Console.WriteLine(string.Join("-", x2));

List<int> x3 = treino1.GerarSquenciaPares(2, 7);
Console.WriteLine(string.Join("-", x3));

int x4 = treino1.SomarAte(5);
Console.WriteLine(x4);

List<double> notas = new List<double>() {6, 8};
double x5 = treino1.CalcularMedia(notas);
Console.WriteLine(x5);

Notas n1 = new Notas();
n1.Nota1 = 5;
n1.Nota2 = 5;
n1.Nota3 = 5;


Notas n2 = new Notas();
n2.Nota1 = 10;
n2.Nota2 = 8;
n2.Nota3 = 6;

Notas n3 = new Notas();
n3.Nota1 = 2;
n3.Nota2 = 4;
n3.Nota3 = 0;


List<Notas> ListaNotas = new List<Notas>();
ListaNotas.Add(n1);
ListaNotas.Add(n2);
ListaNotas.Add(n3);

List<double> x6 = treino1.CalcularMedias(ListaNotas);
Console.WriteLine(string.Join("-", x6)); 

List<double> numeros = new List<double>() { 2, 3, 4 };

List<double> x7 = treino1.CalcularQuadrados(numeros);
Console.WriteLine(string.Join("-", x7));


Retangulo ret1 = new Retangulo();
ret1.Altura  = 5;
ret1.Basee   = 10;

Retangulo ret2 = new Retangulo();
ret2.Altura  = 25;
ret2.Basee   = 2;

List<Retangulo> retangulos = new List<Retangulo>();
retangulos.Add(ret1);
retangulos.Add(ret2);

List<double> x8 = treino1.AreaRetangulos(retangulos);
Console.WriteLine(string.Join("-", x8));