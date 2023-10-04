using System;
					
public class Program
{
	public static void Main()
	{
		int[] numeros = new int[10];
        int i = 0;

        Console.WriteLine("Digite 10 números:");

        while (i <= 9) {
            numeros[i] = Convert.ToInt32(Console.ReadLine());
            i++;
        }

        Array.Reverse(numeros);

        Console.WriteLine("======================================");
        Console.WriteLine("Os números que você digitou foram:");

        foreach(int item in numeros) {
            Console.WriteLine(item);
        }

	}
}
