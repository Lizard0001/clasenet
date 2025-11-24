using System;
using System.Diagnostics.Contracts;

namespace ProgramaDeCalculadora
{
     class Program
{
    public static void Main(string[] args)
    {
      
        var calculo = new Calculadora();
        Console.WriteLine("esta es la calculadora Super Normal");
        Calculadora.suma(2,4);
        string nombre= "flavio";
        Console.WriteLine(nombre);
        Calculadora.restar(5,2);


        var Calcula = new CalculadoraPoderosa();
        Console.WriteLine("esta es la super calculadora");
        CalculadoraPoderosa.suma(8,9);
        CalculadoraPoderosa.restar(55,5);
        CalculadoraPoderosa.divicion(80,8);

    }

    
}


}
   