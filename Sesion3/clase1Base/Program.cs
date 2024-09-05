// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hola! Alumnos");
//Variables
int edad = 20;
long altura = 165;
double dinero = 1651.36;
float danio = 124.4f;
decimal montoEnBanco = 1245151.4m;
string nombre = "pedro";
char letra = 'A';
bool tieneGorro = false;
var kilometros = 351531.5454;
Console.WriteLine("Escribe tu nombre");
nombre=Console.ReadLine();
Console.WriteLine("Escribe tu edad");
edad =int.Parse( Console.ReadLine());
Console.WriteLine("Mi nombre es "+nombre +" mi edad es "+edad);
Console.WriteLine($"Mi altura es {altura}");

if (edad>=18)
{
    Console.WriteLine("Puedes ingresar eres mayor de edad");

}
else if (edad >= 15)
{
    Console.WriteLine("Casi llegas");
}
else
{
    Console.WriteLine("No puedes ingresar chiquillo ve a tu casa");
}
Console.WriteLine("Tienes gorro??");
string respuestaGorro = Console.ReadLine();
if (respuestaGorro == "si")
    tieneGorro = true;
else
    tieneGorro = false;
if (tieneGorro)
{
    Console.WriteLine("Tienes gorro bien por ti");
}
//ESTE ES EL COMENTARIO DE PRUEBA
/*
 * 
 * Comentario
 * 
 * 
 */
