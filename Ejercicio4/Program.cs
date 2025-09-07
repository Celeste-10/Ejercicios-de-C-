// Solicita un número al usuario y usa un bucle do while para mostrar su tabla de multiplicar del 1 al 10.


Console.WriteLine(" Ingrese un numero: ");
int numero = Convert.ToInt32(Console.ReadLine());
int i = 1;
do
{
    Console.WriteLine($" {numero} x {i} = {numero * i} ");
    i++;
} 
while (i <= 10);
