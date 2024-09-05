// See https://aka.ms/new-console-template for more information

DateTime fechaNacimiento = new DateTime(1985, 6, 8);
var fechaActual = DateTime.Now;
Console.WriteLine($"Naci la fecha: {fechaNacimiento.Date.ToString("dd,MM,yy")}");
Console.WriteLine($"la fecha actual es: {fechaActual.Date.ToString("dd/MM/yy")}");

var restaFechas = fechaActual - fechaNacimiento;
Console.WriteLine($"tu edad es: {restaFechas.Days/365}");