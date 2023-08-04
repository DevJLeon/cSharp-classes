namespace EquiposBetPlayOOP.Classes;
public class Jugador : Persona {
    public string Dorsal { get; set; }
    public string Posicion { get; set; }
    public int NivelHabilidad { get; set; }

    public Jugador (string nombre, int id, int edad, string ciudadOrigen, string dorsal,string posicion, int nivelHabilidad): base (nombre,id,edad,ciudadOrigen){
        this.Dorsal = dorsal;
        this.Posicion = posicion;
        this.NivelHabilidad = nivelHabilidad;
    }
}