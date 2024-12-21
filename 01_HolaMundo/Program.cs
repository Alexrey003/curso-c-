namespace _01_HolaMundo;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hola Mundo de C#");
        Console.WriteLine("Presiona cualquier tecla para cerrar.");
        Console.ReadKey();
    }
}

// Al momento de crear un programa usando el framework de .NET de C# Nos creara una carpeta con el mismo
// nombre que pasamos para crear el programa con el comando:

// dotnet new console -o "01_HolaMundo" --framewort net8.0 --use-program-main

// Esto lanzara nuestro primer programa con la estrucutra que vemos.

// Usando Console.WriteLine(""); indicamos que la consola debe de imprimir la la cadena que le pasemos dentro.

// Y usando Console.ReadKey(); le indicamos que la consola al momento de detectar que el usuario presiona cualquier
// tecla esta termine el programa.

// Para ejecutar este programa dentro de la misma carpeta que sea crea al usar .NET podemos pasar el comando

// dotnet run

// Esto hara que el programa corra en nuestra consola.