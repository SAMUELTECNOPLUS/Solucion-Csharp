using System;
using System.Collections.Generic;
using System.Text;

namespace algunos20.unidos;

public class unidosMain
{
    
    static public void Main(string[] agrs)
    {
        Console.WriteLine("Ingrese el limite de numeros del primer arreglo");
         int l = int.Parse(Console.ReadLine());
       
        Console.WriteLine("Ingrese el limite de numeros del primer arreglo");
         int x = int.Parse(Console.ReadLine());
        Arreglo1 j = new Arreglo1(l,x);
        j.recibir();
        j.mostrar();

    }

       




}

