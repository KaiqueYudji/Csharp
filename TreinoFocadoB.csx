using System;
using System.Collections.Generic;



public class Pessoa
{
    public string Nome {get;set;}
    public DateTime Nascimento {get;set;}

   public override string ToString()
{
	return Nome + ":" +  Nascimento;
}
    
}


public class TreinoFocadoB
{
    public List<DateTime> UltimoDia (List<DateTime> datas)
    {
        DateTime hj = DateTime.Now;
        List<DateTime> ultdia = new List<DateTime>();
        foreach (DateTime item in datas)
        {
            int dia = item.Day;
            DateTime ultimo = item.AddMonths(1);
            DateTime final = ultimo.AddDays(-dia);
            ultdia.Add(final);
        }
        
        return ultdia;
    }

    public DateTime MaiorData (List<DateTime> data)
    {
        DateTime anterior = DateTime.MinValue;
        foreach(DateTime item in data)
        {
            if(item > anterior)
            {
                anterior = item;
            }
        }
        return anterior;
    }

    public List<Pessoa> FiltrarMaiores18 (List<Pessoa> pessu)
    {
        List<Pessoa> maiores18 = new List<Pessoa>();
        foreach (Pessoa item in pessu)
        {
            DateTime hj = DateTime.Now;
            if(item.Nascimento <= hj.AddYears(-18))
            {
               maiores18.Add(item);
            }
        }

        return maiores18;
    }

    public bool Todosmaiores (List<Pessoa> pessus)
    {
        bool todosMaiores = true;
        foreach (Pessoa item in pessus)
        {
            DateTime hj = DateTime.Now;
           if(item.Nascimento > hj.AddYears(-18))
           {
               todosMaiores = false;
           }
        }
        
        return todosMaiores;
    }
   
}   


TreinoFocadoB trB = new TreinoFocadoB();

List<DateTime> dts = new List<DateTime>();
dts.Add( DateTime.Now);
dts.Add(new DateTime(2021,8,13));


List<DateTime> a = trB.UltimoDia(dts);
Console.WriteLine("UltimoDia: " + string.Join(",",a));

DateTime b = trB.MaiorData(dts);
Console.WriteLine("MaiorData: " + string.Join(",",b));

Pessoa pessu1 = new Pessoa();
pessu1.Nascimento = new DateTime(2000,9,29);
pessu1.Nome = "Kaique Yudji";


Pessoa pessu2 = new Pessoa();
pessu2.Nascimento = new DateTime(2009,4,22);
pessu2.Nome = "Bruna Sayuri";


Pessoa pessu3 = new Pessoa();
pessu3.Nascimento = new DateTime(1975,7,14);
pessu3.Nome = "Sueli Sayuri";


Pessoa pessu4 = new Pessoa();
pessu4.Nascimento = new DateTime(1972,10,27);
pessu4.Nome = "Ubiracy Junior";

List<Pessoa> pessoas = new List<Pessoa>() {pessu1,pessu2,pessu3,pessu4};

List<Pessoa> c = trB.FiltrarMaiores18(pessoas);
Console.WriteLine("FiltrarMaiores18: " + string.Join(",",c));

bool d = trB.Todosmaiores(pessoas);
Console.WriteLine("Todos são maiores: " + string.Join(",",d));