using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Ingrese una palabra: ");
        string palabra = Console.ReadLine();

        if (EsPalindromo(palabra))
        {
            Console.WriteLine("La palabra es un palíndromo.");
        }
        else
        {
            Console.WriteLine("La palabra no es un palíndromo.");
        }


        int numero = 0;
        bool valido = false;
        Console.Write("Ingrese un número mayor a 0: ");
        var valor = Console.ReadLine();
        valido = int.TryParse(valor, out numero);

        if(valido)
        {
            if (EsPrimo(numero))
            {
                Console.WriteLine("El número es primo");
            }
            else
            {
                Console.WriteLine("El número no es primo");
            }
        }
        else
        {
            Console.WriteLine("´No ingresó un número válido");
        }



        Console.Write("Ingrese un número determinar si es capicúa: ");
        valor = Console.ReadLine();
        valido = int.TryParse(valor, out numero);

        if (valido)
        {
            if (EsCapicua(numero))
            {
                Console.WriteLine("El número es capicúa");
            }
            else
            {
                Console.WriteLine("El número no es capicúa");
            }
        }
        else
        {
            Console.WriteLine("´No ingresó un número válido");
        }

        Console.Write("Ingrese un número a convertir en binario: ");
        valor = Console.ReadLine();
        valido = int.TryParse(valor, out numero);

        if (valido)
        {
            
            Console.WriteLine(DecimalABinario(numero));
       
        }
        else
        {
            Console.WriteLine("´No ingresó un número válido");
        }

    }


    public static string DecimalABinario(int numero)
    {
        string binario = "";

        while (numero > 0)
        {
            int residuo = numero % 2;
            binario = residuo + binario;
            numero /= 2;
        }

        return binario;
    }

    public static bool EsCapicua(int numero)
    {
        int numeroReverso = 0;
        int numeroOriginal = numero;

        while (numero != 0)
        {
            int digito = numero % 10;
            numeroReverso = (numeroReverso * 10) + digito;
            numero /= 10;
        }

        return numeroOriginal == numeroReverso;
    }


    public static bool EsPrimo(int numero)
    {
        if (numero < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    public static bool EsPalindromo(string palabra)
    {
        int i = 0;
        int j = palabra.Length - 1;

        while (i < j)
        {
            if (palabra[i] != palabra[j])
            {
                return false;
            }

            i++;
            j--;
        }

        return true;
    }
}