/*
 * Escribe un programa que muestre por consola (con un print) los
 * números de 1 a 100 (ambos incluidos y con un salto de línea entre
 * cada impresión), sustituyendo los siguientes:
 * - Múltiplos de 3 por la palabra "fizz".
 * - Múltiplos de 5 por la palabra "buzz".
 * - Múltiplos de 3 y de 5 a la vez por la palabra "fizzbuzz".
 */

WriteLine("###  FIZZBUZZ    ###");
WriteLine("Conteo de números del 1 al 100");

for (int i = 1; i < 101; i++)
{
    if (i % 5 == 0 & i % 3 == 0)
    {
        WriteLine(i + " - FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        WriteLine(i + " - Fizz");
    }
    else if (i % 5 == 0)
    {
        WriteLine(i + " - Buzz");
    }
    else
    {
        WriteLine(i);
    }
}
