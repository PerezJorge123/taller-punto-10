// 10.	Construir un programa que pida por pantalla 3 números y luego diga cuál es el mayor,
// el del medio y el menor de los números ingresados.

public class TallerPunto10
{
    static void Main(string[] args)
    {
        double num1, num2, num3; // Definir variables

        Console.Write("Ingrese el primer número: "); // Pedir valores
        num1 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        num2 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el tercer número: ");
        num3 = double.Parse(Console.ReadLine());

        if ( num1 > num2 && num2 > num3)
        {
            Console.Write($"El número {num1} es mayor, el número {num2} es el de enmedio y el número {num3} es el menor");
        }
        else if (num1 > num3 && num3 > num2)
        {
            Console.Write($"El número {num1} es mayor, el número {num3} es el de enmedio y el número {num2} es el menor");
        }
        else if (num2 > num1 && num1 > num3)
        {
            Console.Write($"El número {num2} es mayor, el número {num1} es el de enmedio y el número {num3} es el menor");
        }
        else if (num2 > num3 && num3 > num1)
        {
            Console.Write($"El número {num2} es mayor, el número {num3} es el de enmedio y el número {num1} es el menor");
        }
        else if (num3 > num1 && num1 > num2)
        {
            Console.Write($"El número {num3} es mayor, el número {num1} es el de enmedio y el número {num2} es el menor");
        }
        else if (num3 > num2 && num2 > num1)
        {
            Console.Write($"El número {num3} es mayor, el número {num2} es el de enmedio y el número {num1} es el menor");
        }
    }
}