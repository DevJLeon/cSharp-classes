using System;
using System.Collections.Generic;

class Program {
    // Create a dictionary to store user information with ID as the key
    static Dictionary<int, UserInfo> usersDictionary = new Dictionary<int, UserInfo>();

    static void Main() {
        int opcion;

        do {
            MostrarMenu();
            opcion = PedirOpcion();

            switch (opcion) {
                case 1:
                    WriteSpace();
                    WriteSpace();
                    AddUser();
                    break;
                case 2:
                    WriteSpace();
                    WriteSpace();
                    ShowById();
                    break;
                case 3:
                    WriteSpace();
                    WriteSpace();
                    ShowAll();
                    break;
                case 4:
                    WriteSpace();
                    WriteSpace();
                    DeleteUser();
                    break;
                case 5:
                    WriteSpace();
                    WriteSpace();
                    Console.WriteLine("Hasta luego.");
                    break;
                default:
                    WriteSpace();
                    Console.WriteLine("Opción inválida. Inténtalo de nuevo.");
                    break;
            }

            Console.WriteLine();
        } while (opcion != 5);
    }

    // Display the main menu
    static void MostrarMenu() {
        Console.WriteLine("Menú de opciones:");
        Console.WriteLine("1. Añadir Usuario");
        Console.WriteLine("2. Mostrar usuario por ID");
        Console.WriteLine("3. Mostrar todos usuarios");
        Console.WriteLine("4. Eliminar usuario");
        Console.WriteLine("5. Salir");
    }

    // Prompt user to choose an option
    static int PedirOpcion() {
        Console.Write("Elige una opción: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    // Helper method to write a new line
    static void WriteSpace() {
        Console.WriteLine("");
    }

    // Method to add a new user to the dictionary
    static void AddUser() {
        Console.Write("Número de identificación: ");
        int id = Convert.ToInt32(Console.ReadLine());

        // Check if the ID already exists in the dictionary
        if (usersDictionary.ContainsKey(id))
        {
            Console.WriteLine("El número de identificación ya existe. Inténtalo de nuevo.");
            return;
        }

        Console.Write("Nombre del usuario: ");
        string name = Console.ReadLine();

        Console.Write("Edad: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Hobbies (separados por comas): ");
        string hobbiesInput = Console.ReadLine();
        string[] hobbiesArray = hobbiesInput.Split(',');

        List<string> hobbiesList = new List<string>(hobbiesArray);

        // Create a new UserInfo object and add it to the dictionary
        usersDictionary[id] = new UserInfo(name, age, hobbiesList);

        Console.WriteLine("Usuario agregado con éxito.");
    }

    // Method to display information of a user based on ID
    static void ShowById() {
        Console.Write("Ingresa el número de identificación del usuario: ");
        int id = Convert.ToInt32(Console.ReadLine());

        if (usersDictionary.TryGetValue(id, out UserInfo user))
        {
            Console.WriteLine($"Información del usuario con ID {id}:");
            Console.WriteLine($"Nombre: {user.Name}");
            Console.WriteLine($"Edad: {user.Age}");
            Console.WriteLine($"Hobbies: {string.Join(", ", user.Hobbies)}");
        }
        else
        {
            Console.WriteLine("No se encontró ningún usuario con ese ID.");
        }
    }

    // Method to display information of all users
    static void ShowAll() {
        if (usersDictionary.Count == 0)
        {
            Console.WriteLine("No hay usuarios registrados.");
            return;
        }

        Console.WriteLine("Información de todos los usuarios:");
        foreach (var userEntry in usersDictionary)
        {
            Console.WriteLine($"ID: {userEntry.Key}");
            Console.WriteLine($"Nombre: {userEntry.Value.Name}");
            Console.WriteLine($"Edad: {userEntry.Value.Age}");
            Console.WriteLine($"Hobbies: {string.Join(", ", userEntry.Value.Hobbies)}");
            Console.WriteLine();
        }
    }

    // Method to delete a user from the dictionary based on ID
    static void DeleteUser() {
        Console.Write("Ingresa el número de identificación del usuario a eliminar: ");
        int id = Convert.ToInt32(Console.ReadLine());

        if (usersDictionary.Remove(id))
        {
            Console.WriteLine("Usuario eliminado con éxito.");
        }
        else
        {
            Console.WriteLine("No se encontró ningún usuario con ese ID.");
        }
    }
}

// A class to represent user information
class UserInfo {
    public string Name { get; } // get means that it's only readable and cannot be modified outside the class
    public int Age { get; }
    public List<string> Hobbies { get; }

    // Constructor to initialize UserInfo object
    public UserInfo(string name, int age, List<string> hobbies) {
        Name = name;
        Age = age;
        Hobbies = hobbies;
    }
}