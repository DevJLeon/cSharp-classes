namespace EquiposBetPlayOOP.Classes;

public class Liga
{
    public int Id;
    public string Nombre {get; set;}
    public List<Equipo> EquiposDeLiga {get; set;}
    
    public Liga (string nombre, int id){
        this.Nombre = nombre;
        this.Id = id;
    }
    public Liga (){}

    public void AgregaLiga (List<Liga> Ligas){
        Console.WriteLine("Agregar liga");
        Console.Write("Ingrese el nombre de la liga: ");
        string nombreLiga = Console.ReadLine();
        Console.Write("Id de la liga: ");
        int idLiga = int.Parse(Console.ReadLine());
        Liga liga = new Liga (nombreLiga, idLiga);
        Ligas.Add(liga);
    }

    public void MostrarLigas (List<Liga> Ligas){
        Console.Clear();
        Console.WriteLine("Id\tNombre");
        foreach (var liga in Ligas){
            Console.WriteLine($"{liga.Id}\t{liga.Nombre}");
        }
        Console.ReadKey();
    }

    public Liga AgregarLiga (){
        Liga liga = new Liga();

        Console.Write("Ingrese el Id de la Liga:");
        liga.Id = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el Nombre de la Liga:");
        liga.Nombre = Console.ReadLine();

        return liga;
    }
    public Liga BuscarLiga (List<Liga> Ligas){
        MostrarLigas(Ligas);

        Console.Write("Ingrese el ID de la liga: ");
        int option = int.Parse(Console.ReadLine());
        return Ligas.Find(e=> e.Id == option);
    }
}