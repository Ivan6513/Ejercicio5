/* 
1) Borrar la pantalla.
2) Pedir el nombre de una persona.
3) Saludarlo con un texto que diga "¡Hola [NombreIngresado]!"
4) Preguntar si se quiere continuar.
5) Si la respuesta es "S" repetir desde el punto 1.
6) Si la respuesta es "N" finalizar el programa mostrando un mensaje que diga "Programa finalizado correctamente".
7) Si la respuesta no es ni "S" ni "N" que tambien finalice el programa, pero mostrando un mensaje que diga "Opcion no valida".
 */


string opcion;

do
{
    Console.Clear();

    Console.WriteLine("Ingrese su nombre: ");
    string nombrePersona = Console.ReadLine();

    Console.WriteLine($"Hola {nombrePersona}");

    Console.WriteLine("¿Desea continuar? S para si, N para no");
    opcion = Console.ReadLine();

} while (opcion.ToUpper() == "S");

if (opcion == "N")
{
    Console.Write("Programa finalizado correctamente");
}
else
{
    Console.WriteLine("Opcion no valida");
}


