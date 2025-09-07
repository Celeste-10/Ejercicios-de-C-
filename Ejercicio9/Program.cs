// Solicita tres números diferentes al usuario y usa estructuras if para determinar cuál es el mayor.

Console.WriteLine("Ingrese el primer numero");
int Num1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero");
int Num2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el tercer numero");
int Num3=Convert.ToInt32(Console.ReadLine());

if (Num1 > Num2 && Num1 > Num3)
{
    Console.WriteLine($"El {Num1} es el mayor de los tres numeros");
}
else if (Num2>Num1 && Num2>Num3)
{
    Console.WriteLine($"El {Num2} es el mayor de los tres numeros"); 
}
else
{
    Console.WriteLine($"El numero {Num3} es el mayor de los tres numeros");
}