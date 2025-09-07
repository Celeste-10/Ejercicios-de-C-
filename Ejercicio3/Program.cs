//Crea un menú simple con opciones como:
//Saludar
//Mostrar la fecha actual
//Salir
//Usa switch para ejecutar la opción seleccionada por el usuario.

int Opcion;
Console.WriteLine("--Menu--");
Console.WriteLine("1- Saludar");
Console.WriteLine("2- Mostrar la fecha");
Console.WriteLine("3- Salir");
Console.WriteLine("Porfavor ingrese una opcion:");
Opcion=(Convert.ToInt32(Console.ReadLine()));

switch (Opcion)
{
    case 1:
        Console.WriteLine("Hola, bienvenido");
        break;
    case 2:
        DateTime fechaActual = DateTime.Now;
        Console.WriteLine($"La fecha actual es: {fechaActual.ToShortDateString()}");
        break;
    case 3:
        Console.WriteLine("Saliendo del programa, hasta luego");
        break;
}
