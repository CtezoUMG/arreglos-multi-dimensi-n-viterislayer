using System;

// 1. Lectura de datos: Configurada para los Test Cases de GitHub
string? linea1 = Console.ReadLine();
if (string.IsNullOrEmpty(linea1)) return;

int n = int.Parse(linea1);
// Leemos la segunda línea y dividimos por espacios, eliminando vacíos
string[] entrada = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries) ?? Array.Empty<string>();

int[] numeros = new int[n];
for (int i = 0; i < n; i++)
{
    numeros[i] = int.Parse(entrada[i]);
}

// --- INICIO DE LÓGICA DEL ALUMNO 
int maximo = numeros [0]; // Epezamos con el primer numero 
for (int i = 1; i < n; i++) // Recorremos desde el segundo 
{
    if (numeros[i] > maximo) // Si encontramos uno mayor 
    {
        maximo = numeros [i]; // Lo Guardamos 
    }
}
Console.WriteLine(maximo); // Imprimimos el resultado 
// --- Fin de logica del alumno ---
  }
}

