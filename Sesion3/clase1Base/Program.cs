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
Console.WriteLine("Mi nombre es "+nombre +" mi edad es "+edad);
Console.WriteLine($"Mi altura es {altura}");
Console.WriteLine("Escribe tu Dinero");
dinero =double.Parse(Console.ReadLine());
Console.WriteLine($"tu dinero es {dinero}");