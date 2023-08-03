namespace EquiposBetPlayOOP.Classes;

public class Equipo
{
    public string Name {get; set;}
    public List<string> Propietarios {get; set;}
    public List<Jugador> Jugadores {get; set;}
    public List <Masajista> Masajistas {get; set;}
    public List <Entrenador> Entrenadores {get; set;}
    
}
