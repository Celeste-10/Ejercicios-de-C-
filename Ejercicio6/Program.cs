// Solicita un número al usuario e indica si es positivo, negativo o cero usando una estructura if.

Console.WriteLine("Ingrese un numero: ");
double numero=Convert.ToDouble(Console.ReadLine());

if (numero==0)
{
    Console.WriteLine("El numero ingresado es cero");
}
else if (numero>0)
{
    Console.WriteLine("El numero ingresado es positivo");
}
else
{
    Console.WriteLine("El numero ingresado es negativo");
}
