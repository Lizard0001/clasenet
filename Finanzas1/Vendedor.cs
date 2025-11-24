using System;
using System.Security.AccessControl;


class Vendedor: Empleado, IVenta, ICrear
{
    public override void Mirar()
    {
        Console.WriteLine(" yo no miro  mucholos productos");
    }

    public override void Sueldo()
    {
        Console.WriteLine(" yo gano segun ventas");
    }

    
    public void IVender()
    {
        Console.WriteLine(" yo vendo los productos");
    }

    public void Crea()
    {
        Console.WriteLine(" Yo Creo Los productos en el sistema");
    }
}