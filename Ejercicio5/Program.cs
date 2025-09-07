// Pide al usuario que ingrese 10 números. Usa un bucle for y estructuras if para contar cuántos son pares y cuántos impares.

int numero;

Console.WriteLine("Por favor, introduce 10 números:");

for (int i = 1; i <= 10; i++)
{
    Console.Write($"\nNúmero #{i}: ");

    
    if (int.TryParse(Console.ReadLine(), out numero))
    {
        if (numero % 2 == 0)
        {
            Console.WriteLine("Es un número par.");
        }
        else
        {
            Console.WriteLine("Es un número impar.");
        }
    }
    else
    {
        Console.WriteLine("Entrada no válida. Por favor, ingresa un número entero.");
        i--; 
    }
}     