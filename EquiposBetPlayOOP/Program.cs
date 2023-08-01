using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int option;
        do {
            ShowMenu();
            option = RequestOption();

            switch(option){
                case 1:
                    
                    break;
                case 2:

                    break;
                case 3:

                    break;                    
            }

        } while(option!=3);
    }

    static void ShowMenu(){
        Console.WriteLine("Menú de opciones:");
        Console.WriteLine("1. Registro Pantel");
        Console.WriteLine("2. Consulta de datos");
        Console.WriteLine("3. Salir");
    }
        static void MenuRegister(){
        Console.WriteLine("Menú de opciones:");
        Console.WriteLine("1. Registro Pantel");
        Console.WriteLine("2. Consulta de datos");
        Console.WriteLine("3. Salir");
    }

    static int RequestOption() {
        Console.Write("Elige una opcion");
        return Convert.ToInt32(Console.ReadLine());
    }

    
}

