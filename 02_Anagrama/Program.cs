/*
 * Escribe una función que reciba dos palabras (String) y retorne
 * verdadero o falso (Bool) según sean o no anagramas.
 * - Un Anagrama consiste en formar una palabra reordenando TODAS
 *   las letras de otra palabra inicial.
 * - NO hace falta comprobar que ambas palabras existan.
 * - Dos palabras exactamente iguales no son anagrama.
 */

WriteLine("###  ¿ES UN ANAGRAMA?    ###");

WriteLine("Ingresa la 1ª palabra: ");
string? primeraPalabra = ReadLine();

WriteLine("Ingresa la 2ª palabra: ");
string? segundaPalabra = ReadLine();

string mensaje = "";

mensaje = ComprobarAnagrama(primeraPalabra, segundaPalabra) ? "Es un anagrama" : "Es una palabra";

WriteLine(mensaje);
bool ComprobarAnagrama(string p1, string p2)
{
    bool decision = true;
    char[] pArray1= p1.ToCharArray();
    char[] pArray2= p2.ToCharArray();

    Array.Sort(pArray1);
    Array.Sort(pArray2);

    for ( int i = 0; i < pArray1.Length; i++)
    {
        if (pArray1[i] !=  pArray2[i])
            decision = false;
    }
    return decision;
}
