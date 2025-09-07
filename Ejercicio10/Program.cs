// Pide al usuario un número de días e indica cuántas semanas completas y cuántos días sobran. Usa operaciones básicas y estructuras if.

Console.WriteLine("Por favor, ingresa el número total de días:");
int totalDias = Convert.ToInt32(Console.ReadLine());

int semanasCompletas = totalDias / 7; 
int diasSobrantes = totalDias % 7;   

if (semanasCompletas == 1)
{
    Console.Write($"Hay 1 semana completa");
}
else
{
    Console.Write($"Hay {semanasCompletas} semanas completas");
}

if (diasSobrantes == 1)
{
    Console.WriteLine($" y 1 día sobrante.");
}
else
{
    Console.WriteLine($" y {diasSobrantes} días sobrantes.");
}

