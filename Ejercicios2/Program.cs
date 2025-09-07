// Solicita al usuario un número entero positivo y usa un bucle while para calcular la suma de todos los números desde 1 hasta ese número.

Console.WriteLine("Por favor, introduce un número entero positivo:");
string entrada = Console.ReadLine();
int numero;

while (!int.TryParse(entrada, out numero) || numero <= 0)
{
    Console.WriteLine("Entrada no válida. Por favor, introduce un número entero positivo:");
    entrada = Console.ReadLine();
}
int suma = 0;
int contador = 1;
while (contador <= numero)
{
    suma += contador; 
    contador++; 
}
Console.WriteLine($"La suma de todos los números desde 1 hasta {numero} es: {suma}");
 

