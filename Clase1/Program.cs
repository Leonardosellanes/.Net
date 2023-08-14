// See https://aka.ms/new-console-template for more information
using Clases;

Console.WriteLine("Hello, World!");
do {
    try
    {
Class1 prueba = new Class1();
    Console.WriteLine("ingrese un nombre:");
    prueba.Nombre = Console.ReadLine();
    Console.WriteLine("ingrese un documento:");
    prueba.documento = Console.ReadLine();
    Console.WriteLine("==============================");
    Console.WriteLine("Nombre:" + prueba.Nombre);
    Console.WriteLine("Documento:" + prueba.documento);
    Console.ReadLine();
    } 
    
    catch (Exception ex) {


        Console.WriteLine(ex.Message);
    }
    finally
    {
        Console.WriteLine("Desea continuar?: S/N");
    }

} while (Console.ReadLine().ToUpper() == "S");

