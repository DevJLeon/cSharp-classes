using System;

class Program{

    static void Main(){
        decimal[] ammounts = {16305.32m, 18794.16m};
        Console.WriteLine("  Balance Inicial          Balance final");
        Console.WriteLine("    {0,-20:C2}{1,14:C2}", ammounts[0],ammounts[1]);
    }
}