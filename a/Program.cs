using System;
using System.Collections.Generic;

class Program{
    static Dictionary<int, UserInfo> usersDictionary = new Dictionary<int,UserInfo> ();

    static void Main(){
        int opcion;
        do{
            MostrarMenu();
            opcion = PedirOpcion();

            switch(opcion){
                case 1:
                    AddUser();
                    break;
                case 2:
                    ShowUserByID();
                    break;
                case 3:
                    ShowUsers();
                    break;
                
                case 4:
                    DeleteUser();
                    break;
                
                case 5:
                    Console.WriteLine("Adiosito");
                    break;

                default:

                    break;
            }
        } while (opcion != 5);
    }
    static void MostrarMenu(){
        Console.WriteLine("Menú de opciones:");
        Console.WriteLine("1. Añadir Usuario");
        Console.WriteLine("2. Mostrar usuario por ID");
        Console.WriteLine("3. Mostrar todos usuarios");
        Console.WriteLine("4. Eliminar usuario");
        Console.WriteLine("5. Salir");
    }

    static int PedirOpcion(){
        Console.WriteLine("Elige una opcion");
        return Convert.ToInt32(Console.ReadLine());
    }

    static void AddUser(){
        Console.Write("Numero de identificación: ");
        int id = Convert.ToInt32(Console.ReadLine());

        if (usersDictionary.ContainsKey(id)){
            Console.WriteLine("El número de identificacion ya existe. Inténtalo de nuevo");
            return;
        }

        Console.Write("Nombre de usuario: ");
        string name = Console.ReadLine();

        Console.Write("Edad: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Hobbies (separados por comas): ");
        string hobbiesInput = Console.ReadLine();
        string[] hobbiesArray = hobbiesInput.Split(",");

        List<string> hobbiesList = new List<string>(hobbiesArray);

        usersDictionary[id] = new UserInfo(name, age, hobbiesList);

        Console.WriteLine("Usuario agregado con éxito");
    }

    static void ShowUserByID(){
        Console.Write("Ingresa el numero de identificacion del usuario: ");
        int id = Convert.ToInt32(Console.ReadLine());

        if (usersDictionary.TryGetValue(id, out UserInfo user)){
            Console.WriteLine($"Información del usuario con ID {id}");
            Console.WriteLine($"Nombre: {user.Name}");
            Console.WriteLine($"Edad: {user.Age}");
            Console.WriteLine($"Hobbies: {string.Join(", ", user.Hobbies)}");
        } else {
            Console.WriteLine("No se encontró ningún usuario con ese ID.");
        }
    }

    static void ShowUsers(){}

    static void DeleteUser(){}


}



class UserInfo{
    public string Name{get;}
    public int Age{get;}
    public List<string> Hobbies{get;}

    public UserInfo (string name, int age, List<string> hobbies){
        Name = name;
        Age = age;
        Hobbies = hobbies;
    }
}