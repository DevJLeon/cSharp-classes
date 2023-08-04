namespace EquiposBetPlayOOP.Classes;

public class Persona
{
    public string Nombre {get;set;}
    public int Id {get;set;}
    public int Edad {get;set;}
    public string CiudadOrigen{get;set;}

    public Persona(string nombre, int id, int edad, string ciudadOrigen){
        this.Nombre = nombre;
        this.Id = id;
        this.Edad = edad;
        this.CiudadOrigen = ciudadOrigen;
    }
}
