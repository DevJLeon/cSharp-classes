// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Variables & constants:

string name = "Joshua";
int age = 21;
double salary = 500_000;
bool status = true;

const double gastos = 300_000;

Console.WriteLine(salary);
Console.WriteLine(status ? "tamo activo" : "no tamo activo");

/* decimal[] ammounts = {16305.32m, 18794.16m};
Console.WriteLine("  Balance Inicial          Balance final");
Console.WriteLine("    {0,-20:C2}{1,14:C2}", ammounts[0],ammounts[1]); */

/*
﻿using System;

class Program {
    static void Main() {
        Console.Write("Ingresa el límite de la suma: ");
        int limite = Convert.ToInt32(Console.ReadLine());

        int suma = 0;
        int numero = 1;

        Console.WriteLine("Ingresa números para sumar (ingresa 0 para terminar):");

        while (numero!=0 && suma<limite) {
            numero = Convert.ToInt32(Console.ReadLine());

            suma += numero;
        }

        Console.WriteLine($"La suma total es: {suma}");
    }
}
*/


//24 Julio 2023 __---___--- 
// ARRAY doesnt allow to modify its elements. They are fixed
// ArrayList is like arrays on other languages. This allow modifications and changes