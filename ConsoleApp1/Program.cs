// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*
using System.Numerics;
using System.Xml;
var vender= new Vender(55, "anderson" );
var message= vender.Getinfo();

Console.WriteLine( message );

class Vender
{
    public int Total{ get; set; }
    public String Nombre{ get; set; }
    public Vender(int total, String nombre){
        Total= total;
        Nombre= nombre;
    }
    
    public String Getinfo()
    {
        
        return "el total es: "+ Total+" del cliente:  "+ Nombre;

    }
    

}
*/
class Calculadora
    {
            public  static void suma(int a , int b)
        {
            int resultado=a+b;
            Console.WriteLine("la suma de los elemnetos es: "+ resultado);
        }
         public static void restar(int a , int b)
        {
            int resultado1 = a-b;
            Console.WriteLine("La resta es: "+ resultado1);
        }
        private void multiplicacion(int a , int b)
        {
            int resultado2=a*b;
            Console.WriteLine("la multiplicacion es: "+ resultado2);
        }
       
    }


class CalculadoraPoderosa : Calculadora

{
    public static void divicion(int a , int b)
    {
        double resul = a/b;
        Console.WriteLine("la divicion es: "+ resul);
    }
}