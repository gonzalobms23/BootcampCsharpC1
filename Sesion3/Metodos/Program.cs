


double numero1 = 5;
double numero2 = 10;

double resultado = 0;

void Sumar(double n1,double n2)
{
    double resultado = n1 + n2;
    Console.WriteLine(resultado);   
}
void Sumar2()
{
    resultado = numero1 + numero2;
    Console.WriteLine(resultado);
}
double Sumar3(double n1,double n2)
{
    double resultado = n1 + n2;
    return resultado;
}
Func<double, double, double> SumaLamda = (n1, n2) => (n1 + n2);

Console.WriteLine("Sumando 1 void, parametros");
Sumar(5,10);
Console.WriteLine("Sumando 2 void Global");
Sumar2();
Console.WriteLine("Sumando 3 devolucion, parametros");
double result = Sumar3(5,10);
Console.WriteLine(result);
Console.WriteLine("Sumando 4 Lambda");
double result2 = SumaLamda(5, 10);
Console.WriteLine(result2);
