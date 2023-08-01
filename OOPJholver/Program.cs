using OOPJholver

internal class Program
{
    private static void Main(string[] args)
    {
        Persona estudiante = new Persona("pepito");
        Console.WriteLine($"Id estudiante: {estudiante.IdAlumno}");
        Console.WriteLine($"Id nombre: {estudiante.NombreAlumno}");
    }
}