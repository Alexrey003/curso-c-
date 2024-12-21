namespace _02_TiposDatosYVariables;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Tipos de datos \n");
        int edad = 50;
        Console.Write(edad + "\n");
        string text = "Hola que tal me llamo Alexis";
        Console.Write(text);
    }
}

// Dentro del lenguaje de c# contamos con diferentes tipos de datos dividos en dos
// los primitivos y los estrucutrados, siendo los primitivos los mas comunes.

// Los primitivos son:

// - Int --> Numeros enteros
// - Long --> Numeros enteros muy grandes
// - Float --> Numeros decimales
// - Double --> Numeros decimales con parte decimal larga
// - Decimal --> Numeros decimales con parte decimal larga 

// - String --> Cadena de caracteres
// - Char --> Un unico caracter

// - Bool --> Booleano, solo puede ser verdadero o falso

// Gracias a los tipos de datos dentro de C# podemos definir diferentes variables con diferentes tipos de datos dentro
// de ellas, para declarar una variable primero debemos saber ciertas convenciones para mejorar la legibilidad e 
// interpretacion.

// - No comenzar el nombre de una variable con un guion bajo "_"
// - No crear mas de una variable con el mismo nombre "Edad, edad, EDAD"
// - Comenzar el nombre de una variable con minuscula para usar camelcase "edadAlumno, gradoAlumno"

// Ahora para inicializar una variable debemos primero especificar el tipo de dato que almacenara seguido de su nombre

// Ejemplos:

// int edad = 30;

// string nombre = "Juan";

// double promedio = 8.5;

// char letra = 'A';

// bool esMayorDeEdad = true;

// En estos ejemplos estamos tanto declarandolas e inicializandolas.