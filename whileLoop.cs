using System;

class Program {
    static void Main() {
        Console.Write("Ingresa el límite de la suma: ");
        int limite = Convert.ToInt32(Console.ReadLine());

        int suma = 0;
        int numero = 1;

        Console.WriteLine("Ingresa números para sumar (ingresa 0 para terminar):");

        while (numero!=0 && suma<limite) {
            numero = Convert.ToInt32(Console.ReadLine());

            suma += numero;
        }

        Console.WriteLine($"La suma total es: {suma}");
    }
}