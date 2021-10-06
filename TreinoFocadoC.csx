using System;
using System.Collections.Generic;


public class Pessoa
{
    public DateTime Nascimento {get;set;}
    public string Nome {get;set;}

}


public class TreinoFocadoC
{
    public string SepararLetras (string frase)
    {
        string juntando = string.Empty;
        foreach(char letra in frase)
        {
            juntando += letra + "-";
        }
        return juntando;
    }

    public List<int> CodigoASCI (string frase)
    {
        List<int> codigos = new List<int>();
        foreach(char letra in frase)
        {
            if(letra == 'A')
            {
               codigos.Add(65);
            }

            else if(letra == 'B')
            {
                codigos.Add(66);
            }
              else if(letra == 'C')
            {
                codigos.Add(67);
            }
              else if(letra == 'D')
            {
                codigos.Add(68);
            }
              else if(letra == 'E')
            {
                codigos.Add(69);
            }
              else if(letra == 'F')
            {
                codigos.Add(70);
            }
              else if(letra == 'G')
            {
                codigos.Add(71);
            }
              else if(letra == 'H')
            {
                codigos.Add(72);
            }
              else if(letra == 'I')
            {
                codigos.Add(73);
            }
              else if(letra == 'J')
            {
                codigos.Add(74);
            }
              else if(letra == 'K')
            {
                codigos.Add(75);
            }
              else if(letra == 'L')
            {
                codigos.Add(76);
            }
               else if(letra == 'M')
            {
                codigos.Add(77);
            }
               else if(letra == 'N')
            {
                codigos.Add(78);
            }
               else if(letra == 'O')
            {
                codigos.Add(79);
            }
               else if(letra == 'P')
            {
                codigos.Add(80);
            }
               else if(letra == 'Q')
            {
                codigos.Add(81);
            }
               else if(letra == 'R')
            {
                codigos.Add(82);
            }
               else if(letra == 'S')
            {
                codigos.Add(83);
            }
               else if(letra == 'T')
            {
                codigos.Add(84);
            }
               else if(letra == 'U')
            {
                codigos.Add(85);
            }
               else if(letra == 'V')
            {
                codigos.Add(86);
            }
               else if(letra == 'W')
            {
                codigos.Add(87);
            }
               else if(letra == 'X')
            {
                codigos.Add(88);
            }
               else if(letra == 'Y')
            {
                codigos.Add(89);
            }
               else if(letra == 'Z')
            {
                codigos.Add(90);
            }

             else if(letra == 'a')
            {
               codigos.Add(97);
            }

            else if(letra == 'b')
            {
                codigos.Add(98);
            }
              else if(letra == 'c')
            {
                codigos.Add(99);
            }
              else if(letra == 'd')
            {
                codigos.Add(100);
            }
              else if(letra == 'e')
            {
                codigos.Add(101);
            }
              else if(letra == 'f')
            {
                codigos.Add(102);
            }
              else if(letra == 'g')
            {
                codigos.Add(103);
            }
              else if(letra == 'h')
            {
                codigos.Add(104);
            }
              else if(letra == 'i')
            {
                codigos.Add(105);
            }
              else if(letra == 'j')
            {
                codigos.Add(106);
            }
              else if(letra == 'k')
            {
                codigos.Add(107);
            }
              else if(letra == 'l')
            {
                codigos.Add(108);
            }
               else if(letra == 'm')
            {
                codigos.Add(109);
            }
               else if(letra == 'n')
            {
                codigos.Add(110);
            }
               else if(letra == 'o')
            {
                codigos.Add(111);
            }
               else if(letra == 'p')
            {
                codigos.Add(112);
            }
               else if(letra == 'q')
            {
                codigos.Add(113);
            }
               else if(letra == 'r')
            {
                codigos.Add(114);
            }
               else if(letra == 's')
            {
                codigos.Add(115);
            }
               else if(letra == 't')
            {
                codigos.Add(116);
            }
               else if(letra == 'u')
            {
                codigos.Add(117);
            }
               else if(letra == 'v')
            {
                codigos.Add(118);
            }
               else if(letra == 'w')
            {
                codigos.Add(119);
            }
               else if(letra == 'x')
            {
                codigos.Add(120);
            }
               else if(letra == 'y')
            {
                codigos.Add(121);
            }
               else if(letra == 'Z')
            {
                codigos.Add(122);
            }


        }

        return codigos;
    }

    public bool TodasVogais (string frase)
    {
        bool todasvogais = true;
        foreach(char letra in frase)
        {
            if(letra != 'a' && letra !='e' && letra != 'i' && letra !='o' && letra !='u'  &&   letra != 'A' && letra !='E' && letra != 'I' && letra !='O' && letra !='U'  )
            {
                 todasvogais = false;
            }
        }
        return todasvogais;
    }

    public string FormatarPalavras (string frase)
    {
        string formatando = string.Empty;

        char anterior = ' ';

        foreach(char item in frase)
        {
            if(anterior == ' ')
            {
                formatando += item.ToString().ToUpper();
            }

            else if(anterior == 'a' || anterior == 'b' || anterior == 'c' || anterior == 'd' || anterior == 'e' || anterior == 'f' || anterior == 'g' || anterior == 'h' || anterior == 'i' || anterior == 'j' || anterior == 'k' || anterior == 'l' || anterior == 'm' || anterior == 'n' || anterior == 'o' || anterior == 'p' || anterior == 'q' || anterior == 'r' || anterior == 's' || anterior == 't' || anterior == 'u' || anterior == 'v' || anterior == 'w' || anterior == 'x' || anterior == 'y' || anterior == 'z')
            {
              formatando += item.ToString().ToUpper();
            }

            else if(anterior == 'A' || anterior == 'B' || anterior == 'C' || anterior == 'D' || anterior == 'E' || anterior == 'F' && anterior == 'G' || anterior == 'H' || anterior == 'I' || anterior == 'J' || anterior == 'K' || anterior == 'L' || anterior == 'M' || anterior == 'N' || anterior == 'O' || anterior == 'P' || anterior == 'Q' || anterior == 'R' || anterior == 'S' || anterior == 'T' || anterior == 'U' || anterior == 'V' || anterior == 'W' || anterior == 'X' || anterior == 'Y' || anterior == 'Z')
            {
                formatando += item.ToString().ToLower();
            }

            else{
                formatando = "tchau";
            }

            anterior = item;
            
        }

        return formatando;
    }

    public string Invertido ( string frase)
    {
        string armazenar = string.Empty;
        foreach (char item in frase)
        {
            armazenar = item + armazenar;
        }

        return armazenar;
    }

      public bool Palindromo (string frase)
     {
         frase = frase.ToLower();
         bool epalindromo = frase == Invertido(frase);
         return epalindromo;

     }

}


TreinoFocadoC trC = new TreinoFocadoC();
string a = trC.SepararLetras("Olá, tudo bem?");
Console.WriteLine("Separado: " + a );

List<int> b = trC.CodigoASCI("Kaique");
Console.WriteLine("ASCII: " + string.Join(",",b));


bool c = trC.TodasVogais("aeiou");
Console.WriteLine("TodasSaoVoais: " + c);

string d = trC.FormatarPalavras("bruna");
Console.WriteLine("FormatarPalavras: " + d);

string e = trC.Invertido("Kaique");
Console.WriteLine("Invertido: " + e);

bool f = trC.Palindromo("ovo");
Console.WriteLine("Palindromo: " + f);