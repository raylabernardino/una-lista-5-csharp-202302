using System;
					
public class Program
{
	public static void Main()
	{
		float[] notas = new float[4];
        int i = 0;

        Console.WriteLine("Digite suas 4 notas:");

        while (i <= 3) {
            notas[i] = Convert.ToSingle(Console.ReadLine());
            i++;
        }

        float media = (notas[0] + notas[1] + notas[2] + notas[3]) / 4;

        Console.WriteLine("=========================================");
        Console.WriteLine("Nota 1: " + notas[0]);
        Console.WriteLine("Nota 2: " + notas[1]);
        Console.WriteLine("Nota 3: " + notas[2]);
        Console.WriteLine("Nota 4: " + notas[3]);
        Console.WriteLine("Média: " + media);

	}
}
