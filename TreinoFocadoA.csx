using System;
using System.Collections.Generic;


public class Retangulo
{
    public double Base {get;set;}
    public double Altura {get;set;}

}


public class Notas
{
       public double Nota1 {get;set;}
       public double Nota2 {get;set;}
       public double Nota3 {get;set;}
       
}




public class TreinoFocadoA
{
    public int SomarImpares (List<int> numeros)
    {
      int soma = 0;
       foreach( int item in numeros)
       {
           if(item % 2 == 1)
           {
               soma +=item;
           }
       }

       return soma;

    }

    public List<int> CalcularCubo (List<int> numeros)
    {
        List<int> calcCubo = new List<int>();

        foreach(int item in numeros)
        {
           calcCubo.Add(item * item * item);
        }

        return calcCubo;
    }


    public List<double> CalcularRaiz (List<int> numero)
    {
        List<double> raiz = new List<double>();
        foreach(int item in numero)
        {
            raiz.Add(Math.Sqrt(item));
        }

        return raiz;
    }


    public int MaiorNumero (List<int> numeros)
    {
        int anterior = 0;
        foreach (int item in numeros)
        {
            if(item > anterior)
            {
                anterior = item;
            }
        }

        return anterior;
        
    }

    public double Media (List<double> numeros)
    {
        double soma = 0;
        foreach(int item in numeros)
        {
           soma+= item;
        }

        double media = soma /  numeros.Count;

        return media;
    }

    public List<double> CalcularMedias (List<Notas> numeros)
    {
        List<double> mediass = new List<double>();
      double media = 0;
         foreach (Notas item in numeros)
         {
           Notas posi = item;
           media = Math.Round((posi.Nota1 + posi.Nota2 + posi.Nota3) / numeros.Count,2);
           mediass.Add(media);
         }

        return mediass;


    }


    private double AreaRetangulo (Retangulo re)
    {
        return re.Base * re.Altura;
    }


    public List<double> AreaRetangulos (List<Retangulo> ret)
    {
        List<double> areas = new List<double>();

        foreach (Retangulo item in ret)
        {
            double area = AreaRetangulo(item);
            areas.Add(area);
        }

        return areas;
    }


}



TreinoFocadoA trA = new TreinoFocadoA();

List<int> num = new List<int>() { 2, 5, 8, 3, 10};
int a = trA.SomarImpares(num);
Console.WriteLine("SomarImpares: " + string.Join("-",a));

List<int> numeros = new List<int> () {2,4,3,1};
List<int> b = trA.CalcularCubo(numeros);
Console.WriteLine("CalcularCubo: " +string.Join("-",b));

List<int> nm = new List<int>() {25,81,16};

List<double> c = trA.CalcularRaiz(nm);
Console.WriteLine("CalcularRaiz: " + string.Join("-",c));

int d = trA.MaiorNumero(nm);
Console.WriteLine("MaiorNumero: " + d);

List<double> numpmedia = new List<double>() {5,5,5};

double e = trA.Media(numpmedia);
Console.WriteLine("Media: " + e);


Notas n1 = new Notas();
n1.Nota1= 7;
n1.Nota2 = 8;
n1.Nota3= 7;


Notas n2 = new Notas();
n2.Nota1 = 3;
n2.Nota2 = 4;
n2.Nota3 = 5;


Notas n3 = new Notas();
n3.Nota1 = 5;
n3.Nota2 = 5;
n3.Nota3 = 5;


List<Notas> notas = new List<Notas>() {n1,n2,n3};

List<double> f = trA.CalcularMedias(notas);
Console.WriteLine("CalcularMedias: " + string.Join("/",f));

Retangulo ret1 = new Retangulo();
ret1.Base = 5;
ret1.Altura = 5;


Retangulo ret2 = new Retangulo();
ret2.Base = 2;
ret2.Altura = 2;


Retangulo ret3 = new Retangulo();
ret3.Base = 5;
ret3.Altura = 5;


List<Retangulo> retangs = new List<Retangulo>() {ret1, ret2, ret3};

List<double> g = trA.AreaRetangulos(retangs);
Console.WriteLine("AreaRetangulos: " + string.Join(",",g));
