﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingresa los numeros a sumar");
int numero1 =int.Parse( Console.ReadLine());
int numero2 =int.Parse( Console.ReadLine());
int resultado = numero1 + numero2;
Console.WriteLine($"Resultado es {resultado}" );

Console.WriteLine("Ingresa el numero limite WHILE");
int numeroLimite = int.Parse(Console.ReadLine());
int contador = 0;
while (contador<numeroLimite)
{
    contador = contador + 1;

    Console.WriteLine(contador);
}
Console.WriteLine("DO - WHILE");
contador = 0;
do
{
    contador++;
    Console.WriteLine(contador);
} while (contador<numeroLimite);


int opcion = 0;

while (opcion != 7)
{
    Console.WriteLine("Calculadora------->");
    Console.WriteLine("1.-Sumar");
    Console.WriteLine("2.-Restar");
    Console.WriteLine("3.-Multiplicar");
    Console.WriteLine("4.-Dividir");
    Console.WriteLine("5.-Potencia");
    Console.WriteLine("6.-Raiz");
    Console.WriteLine("7.-Salir");
    Console.WriteLine("Ingresa la opcion");
    opcion = int.Parse(Console.ReadLine());
    if (opcion == 1)
    {
        Console.WriteLine("Sumando");        
    }
    if (opcion == 2)
        Console.WriteLine("Resta");
    
}
Console.WriteLine("Salida");