using System;
using System.Collections.Generic;


//treino for


public class Notas
{
    public double Nota1{get;set;}
    public double Nota2{get;set;}
    public double Nota3{get;set;}

}

public class Retangulo
{
    public double Altura{get;set;}

    public double Baase{get;set;}
}


public List<int> GerarSequencia (int fim)
{
    List<int> sequencia = new List<int>();
    for(int volta = 0; volta <= fim; volta++)
    {
      sequencia.Add(volta);
    }

    return sequencia;
}


List<int> a = GerarSequencia(5);
Console.WriteLine(string.Join(",",a));



public List<int> GerarSequencia (int inicio, int fim)
{
    List<int> sequencia = new List<int>();
    for (int i = inicio; inicio <= fim; inicio++)
    {
      sequencia.Add(inicio);
    }

    return sequencia;
}


List<int> b = GerarSequencia(5,10);
Console.WriteLine(string.Join(",",b));



public List<int> GerarSequenciaPares (int inicial, int fim)
{
    List<int> pares = new List<int>();
    for(int i = inicial; i <= fim; i++)
    {
        if(i % 2 == 0)
        {
            pares.Add(i);
        }
    }
    return pares;
}

List<int> c = GerarSequenciaPares(0,10);
Console.WriteLine("SequenciPares: " + string.Join(",",c));


public int SomarAte (int fim)
{
    int soma = 0;
    for(int i = 0; i<= fim; i++)
    {
        soma += i;
    }

    return soma;
}

int d = SomarAte(3);
Console.WriteLine(d);



public List<double> Calcularmedias (List<Notas> notas)
{
    List<double>medias = new List<double>();
    double media =0;
    for(int p = 0; p < notas.Count; p++)
    {
       Notas posi = notas[p];
        media = (posi.Nota1 + posi.Nota2 + posi.Nota3) / notas.Count;
        medias.Add(media);
    }

    return medias;
}



public double CalcularMedia (List<double> notas)
{
    double soma = 0;
    for(int n = 0; n < notas.Count; n ++)
    {
        double posi = notas[n];
        soma += posi;
    }

    double media = soma / notas.Count;

    return media;

}


List<double> notas = new List<double>(){5,5,5,5,5};
double media = CalcularMedia(notas);
Console.WriteLine("media: " + media);

 public List<double> CalcularQuadrado (List<double> numeros)
     {

       List<double> calc = new List<double>();

      double valor= 0;
      for(int i = 0; i < numeros.Count; i++)
      {
        valor = numeros[i];

        double calculo= Math.Pow(valor,2);

        calc.Add(calculo);

      }

     return calc;


     }

List<double> nums = new List<double>(){2,3};

     List<double> quadrado = CalcularQuadrado(nums);
     Console.WriteLine("Quadrado: " + string.Join(",",quadrado));


     private double Arearetangulo (Retangulo ret)
{
    return ret.Baase* ret.Altura;
}



public List<double> AreaRetangulos (List<Retangulo> rets)
{
    List<double> areas = new List<double>();
    for(int i = 0; i < rets.Count; i++)
    {
        Retangulo posi = rets[i];
        double area = Arearetangulo(posi);
        areas.Add(area);
    }

    return areas;

}
Retangulo r1 = new Retangulo();
r1.Altura = 5;
r1.Baase = 5;


Retangulo r2 = new Retangulo();
r2.Altura = 3;
r2.Baase = 3;

List<Retangulo> oi = new List<Retangulo>() {r1,r2};

List<double> Areas = AreaRetangulos(oi);
Console.WriteLine("Areas: " +  string.Join(",",Areas));






Notas n1 = new Notas();
n1.Nota1 = 5;
n1.Nota2 = 5;
n1.Nota3 = 5;


Notas n2 = new Notas();
n2.Nota1 = 6;
n2.Nota2 = 6;
n2.Nota3 = 6;


Notas n3 = new Notas();
n3.Nota1 = 5;
n3.Nota2 = 5;
n3.Nota3 = 5;





List<Notas> medias = new List<Notas>(){n1,n2,n3};

List<double> Medias = Calcularmedias(medias);
Console.WriteLine("Medias: " + string.Join(",",Medias));