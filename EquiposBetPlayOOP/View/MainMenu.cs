using System;

namespace EquiposBetPlayOOP.View;

public class MainMenu
{
    public MainMenu(){}
    public int menu(){
        Console.Clear();
        Console.WriteLine("Menú de opciones:");
        Console.WriteLine("1. Registro Pantel");
        Console.WriteLine("2. Consulta de datos");
        Console.WriteLine("3. Salir");
        return int.Parse(Console.ReadLine());
    }
}
