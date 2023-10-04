using System;

class Program
{
    public static void Main()
    {
        char[] caracteres = new char[10];
        int numeroConsoantes = 0;
        
        Console.WriteLine("Digite 10 caracteres:");
        
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Caractere {i + 1}: ");
            caracteres[i] = Console.ReadKey().KeyChar;
            Console.WriteLine();
        }

        Console.WriteLine("\nConsoantes lidas:");
        
        foreach (char c in caracteres)
        {
            if (ehConsoante(c))
            {
                Console.Write(c + " ");
                numeroConsoantes++;
            }
        }

        Console.WriteLine($"\nTotal de consoantes lidas: {numeroConsoantes}");
    }

    static bool ehConsoante(char c)
    {
        char[] consoantes = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
        return Array.Exists(consoantes, consoante => consoante == char.ToLower(c));
    }
}
