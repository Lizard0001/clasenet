using System;


class Cliente : Persona
{
    public override void Mirar()
    {
        Console.WriteLine("El cliente Mira en un restaurante");
    }
     public void Comprar()
    {
        Console.WriteLine("El compra en el restaurante");
    }
}