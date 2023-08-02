namespace EquiposBetPlayOOP.View;

public class MenuBusqueda
{
    public MenuBusqueda(){}
    public int menuBusqueda(){
        Console.Clear();
        Console.WriteLine("elija la opcion adecuada:");
        Console.WriteLine("1) lista jugador por equipo");
        Console.WriteLine("2) buscar los delanteros de cada equipo");
        Console.WriteLine("3) buscar cuerpo entrenadores por equipo");
        Console.WriteLine("4) regresar menu principal");
        return int.Parse(Console.ReadLine());
}
}
