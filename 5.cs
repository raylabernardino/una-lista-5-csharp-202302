using System;

public class Program
{
    public static void Main()
    {
		int[] numeros = new int[20];
        int[] par = new int[20];
        int[] impar = new int[20];

        int i = 0;
        int v1 = 0;
        int v2 = 0;

        Console.WriteLine("Digite 20 números:");

        while (i <= 19) {
            numeros[i] = Convert.ToInt32(Console.ReadLine());

            if (numeros[i] % 2 == 0) {
                par[v1] = numeros[i];
                v1++;
            } else {
                impar[v2] = numeros[i];
                v2++;
            }

            i++;
        }

        Console.WriteLine(" ");
        Console.WriteLine("Pares: ");
        ImprimirVetor(par);
        Console.WriteLine("Ímpares: ");
        ImprimirVetor(impar);
        Console.WriteLine("Todos os números inseridos: ");
        ImprimirVetor(numeros);
    }

    static void ImprimirVetor(int[] vetor)
    {
        foreach (int numero in vetor)
        {
            if (numero != 0)
            {
                Console.Write(numero + " ");
            }
        }
        Console.WriteLine();
    }
}
