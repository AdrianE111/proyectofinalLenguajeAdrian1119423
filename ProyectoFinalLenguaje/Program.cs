using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = @"C:\Users\escal\Downloads\CadenasProyectoFinalLenguaje.txt";

        try
        {
            string[] cadenas = File.ReadAllLines(filePath);
            if (cadenas.Length < 10)
            {
                Console.WriteLine("El archivo debe contener al menos 10 cadenas.");
                return;
            }

            MaquinaTuring maquina = new MaquinaTuring();

            foreach (string cadena in cadenas)
            {
                string trimmedCadena = cadena.Trim();
                if (!string.IsNullOrEmpty(trimmedCadena)) // Asegúrate de que no esté vacía
                {
                    maquina.ProcesarCadena(trimmedCadena);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al leer el archivo: {ex.Message}");
        }
    }
}