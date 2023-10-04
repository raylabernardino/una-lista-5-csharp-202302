using System;
					
public class Program
{
	public static void Main()
	{
		int[] numeros = new int[5];
        int i = 0;

        Console.WriteLine("Digite cinco números:");

        while (i <= 4) {
            numeros[i] = Convert.ToInt32(Console.ReadLine());
            i++;
        }

        Console.WriteLine("======================================");
        Console.WriteLine("Os números que você digitou foram:");

        foreach(int item in numeros) {
            Console.WriteLine(item);
        }

	}
}
