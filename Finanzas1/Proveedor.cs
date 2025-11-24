using System;


class Proveedor: Empleado 
{
    public override void Mirar()
    {
        Console.WriteLine("yo miro que lo que proveoo llegue en muy buen estado ");
    }
    public override void Sueldo()
    {
        Console.WriteLine("yo gano 2M ");
    }
}