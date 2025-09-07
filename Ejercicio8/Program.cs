// Crea un programa que pida al usuario una contraseña y repita la solicitud hasta que ingrese la correcta. Usa un bucle do while.

string contraseñacorrecta = "Programacion";
string contraseñaingresada;

do
{
    Console.WriteLine("Ingrese la contraseña: ");
    contraseñaingresada = Console.ReadLine();
    if (contraseñaingresada != contraseñacorrecta)
    {
        Console.WriteLine("Error, vuelva a ingresar la contraseña");
    }
}
while (contraseñaingresada != contraseñacorrecta);

Console.WriteLine("Contraseña correcta. Acceso concedido");