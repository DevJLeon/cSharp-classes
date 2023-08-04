namespace EquiposBetPlayOOP.Classes;

public class Equipo
{
    public string Nombre {get; set;}
    public List<string> Propietarios {get; set;}
    public List<Jugador> Jugadores {get; set;}
    public List <Masajista> Masajistas {get; set;}
    public List <Entrenador> Entrenadores {get; set;}
    
    //Constructor de la clase equipo
    public Equipo(string nombre){
        this.Nombre = nombre;
        this.Propietarios = new List<string>();
        this.Jugadores = new List<Jugador>();
        this.Masajistas = new List<Masajista>();
        this.Entrenadores = new List<Entrenador>();
    }

    public Equipo(){
        this.Propietarios = new List<string>();
        this.Jugadores = new List<Jugador>();
        this.Masajistas = new List<Masajista>();
        this.Entrenadores = new List<Entrenador>();
    }

    public Equipo AgregarEquipo(){
        Equipo equipo = new Equipo();
        Console.WriteLine("Ingrese el nombre del nuevo equipo");
        equipo.Nombre = Console.ReadLine();

        return equipo;
    }
}
