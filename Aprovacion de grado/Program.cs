using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese su número de control (matrícula): ");
        string matricula = Console.ReadLine();

        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();

        double suma = 0;
        double nota;

        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Estimado/a, ingrese la calificación {i}: ");
            nota = Convert.ToDouble(Console.ReadLine());
            suma += nota;
        }

        double promedio = suma / 5;
        Console.WriteLine($"\nEl promedio de notas es: {promedio:F2}");

        if (promedio <= 70)
        {
            Console.WriteLine("Reprobado");
        }
        else
        {
            Console.WriteLine("Aprobado");
        }
    }
}

