namespace EquiposBetPlayOOP.View;
public class MenuPlantel
{
    public MenuPlantel(){}
    public int menuPlantel(){
        Console.Clear();
        Console.WriteLine("Menú de opciones plantel:");
        Console.WriteLine("1. Registro equipo");
        Console.WriteLine("2. Registro jugador");
        Console.WriteLine("3. Registro entrenador");
        Console.WriteLine("4. Registro masajista");
        Console.WriteLine("5. Venta jugador");
        Console.WriteLine("6. Regresar al menu principal");
        return int.Parse(Console.ReadLine());
    }        
}
