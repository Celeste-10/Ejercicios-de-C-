// Solicita al usuario cuántas calificaciones desea ingresar. Luego usa un bucle while para capturarlas y calcula el promedio final.

Console.WriteLine("¿Cuántas calificaciones deseas ingresar?");
int numeroDeCalificaciones = Convert.ToInt32(Console.ReadLine());

double sumaCalificaciones = 0;
int contador = 0;

while (contador < numeroDeCalificaciones)
{
    Console.WriteLine($"Ingresa la calificación número {contador + 1}:");
    double calificacion = Convert.ToDouble(Console.ReadLine());
    sumaCalificaciones += calificacion;
    contador++;
}
double promedio = sumaCalificaciones / numeroDeCalificaciones;


Console.WriteLine($"El promedio de las calificaciones es: {promedio:F2}");
 
