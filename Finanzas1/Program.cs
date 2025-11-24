using System;

class Program
{
    static void Main(string[] args)

    {
        var sarah = new Cliente();
        sarah.Comprar();
        sarah.Mirar();
        var SoyUnProveedor = new Proveedor();
        SoyUnProveedor.Mirar();
        SoyUnProveedor.Sueldo();
    }

}