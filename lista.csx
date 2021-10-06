using System;
using System.Collections.Generic;


public class Pessoa
{
	public string Nome{get;set;}
	public DateTime Nascimento{get;set;}

 public override string ToString()
{
	return Nome + ":" +  Nascimento;
}

}
public List<int> SomaImpares (List<int> num)
{
	int soma = 0;
	List<int> impares = new List<int>();
	foreach (int item in num)
	{
		if(item % 2 == 1)
		{
           soma += item;
		}
	}

    impares.Add(soma);
	return impares;
}


List<int> nums = new List<int>(){2,3,4,5};
 List<int> a = SomaImpares(nums);
 Console.WriteLine("SomaImpares: " + string.Join(",",a));



 public List<int> CalcularCubo (List<int> numeros)
 {
	 List<int> cubo = new List<int>();
	 foreach (int item in numeros)
	 {
		 double calculo = Math.Pow(item,3);
		 int final = Convert.ToInt32(calculo);
		 cubo.Add(final);
	 }

	 return cubo;

 }

	List<int> nuuums = new List<int>(){2,3,5};

	List<int> CUBO = CalcularCubo(nuuums);
	Console.WriteLine("CUBO: " + string.Join(",",CUBO));


	public List<double> CalcularRaiz (List<double> numi)
	{
		List<double> calculado = new List<double>();
		foreach (int item in numi)
		{
			double raiz= Math.Sqrt(item);
			calculado.Add(raiz);
		}

		return calculado;
	}


	List<double> ola = new List<double>(){25,81,49};

	List<double> raiz = CalcularRaiz(ola);
	Console.WriteLine("Raiz: " + string.Join(",",raiz));


	public string Invertido (string frase)
	{
		string juntando = string.Empty;
		foreach (char item in frase)
		{
			juntando += item + "-";
		}

		return juntando;
	}

	string inverter = Invertido("kaique");
	Console.WriteLine(inverter);



	public int MaiorNumero (List<int> numeros)
	{
		int anterior = 0;
		foreach(int item in numeros)
		{
			if(item > anterior)
			{
				anterior = item;
			}
		}
		return anterior;
	}

	List<int> numi = new List<int>(){1,7,5};

	int Maior = MaiorNumero(numi);
	Console.WriteLine("MaiorNumero: " + Maior);


	public List<DateTime> ultimodia (List<DateTime> ola)
	{
		List<DateTime> ult = new List<DateTime>();
		foreach(DateTime item in ola)
		{
			 int dia = item.Day;
			 DateTime processo = item.AddMonths(1);
			 DateTime final = processo.AddDays(-dia);
			 ult.Add(final);
		}

		return ult;
	}

	List<DateTime> dates = new List<DateTime>();
	dates.Add(new DateTime(2005,9,29));
	dates.Add(new DateTime(2000,9,29));


	List<DateTime> ultimo = ultimodia(dates);
	Console.WriteLine("UltimoDia: " + string.Join(",",ultimo));


	public List<Pessoa> Filtrarmaiores (List<Pessoa> pessu)
	{
		DateTime hj = DateTime.Now;
		List<Pessoa> maioresidade = new List<Pessoa>();
		foreach (Pessoa item in pessu)
		{
			if(item.Nascimento <= hj.AddYears(-18))
			{
				maioresidade.Add(item);
			}
			
		}

		return maioresidade;

	}

    Pessoa p1 = new Pessoa();
	p1.Nascimento = new DateTime(2000,9,29);
	p1.Nome = "João Kléber";

    Pessoa p2 = new Pessoa();
	p2.Nascimento = new DateTime(2005,9,29);
	p2.Nome = "Kaique";


List<Pessoa> pessu = new List<Pessoa>(){p1,p2};
		List<Pessoa> maiores = Filtrarmaiores(pessu);
	Console.WriteLine("Maiores: " + string.Join(",",maiores));



