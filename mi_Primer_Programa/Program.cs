using System;


class Program
{
    static void Main(string[] args)
    {
        var Gatorro =  new Oscar();
        Gatorro.Clase();
        Gatorro.Comer();
        Gatorro.Dormir();
        Gatorro.HacerSonido();
         
        var Perro = new Filemona();
        Perro.Comer();
        Perro.Raza();
        Perro.Dormir();
        



    }
}
