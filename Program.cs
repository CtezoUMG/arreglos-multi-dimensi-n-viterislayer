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

// --- INICIO DE LÓGICA DEL ALUMNO ——-
int mayor = numeros[0]; |/ Suponemos que el
primer número es el mayor
int indice = 1; |/ Empezamos a comparar desde
el segundo
while (indice ‹ numeros. Length) // Mientras no Ileguemos al final
if (numeros[indice] > mayor) |/ Si
encontramos uno más grande
mayor = numeros[indice]; |/ Lo
guardamos
｝
indicett; |/ Pasamos al siguiente
}
Console WriteLine(mayor); // Mostramos el resultado
11 --- FIN DE LÓGICA DEL ALUMNO —
