// See https://aka.ms/new-console-template for more information


using System;
/*
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

*/
int opcion = 0;

while (opcion != 7)
{
    Console.WriteLine("Ingresa los numeros a Operar");
    double numero1 = double.Parse(Console.ReadLine());
    double numero2 = double.Parse(Console.ReadLine());
    double resultado = 0;
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

    switch (opcion)
    {
        case 1:
            resultado = numero1 + numero2;
            break;
        case 2:
            resultado = numero1 - numero2;
            break;
        case 3:
            resultado = numero1 * numero2;
            break;
        case 4:
            if (numero2 == 0)
            {
                Console.WriteLine("No se puede dividir entre 0");
                return;
            }
            resultado = numero1 / numero2;

            break;
        default:
            break;
    }
    Console.WriteLine($"Resultado es {Math.Round(resultado,2)}");
}
Console.WriteLine("Salida");