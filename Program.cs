using System;

class Human
{
    // Propiedades para Humano
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    public int Health;

    //  Constructor que toma un valor para establecer el Nombre y asigna los demás campos a valores predeterminados
    public Human(string name)
    {
        Name = name;
        Strength = 10; // Valor predeterminado de fuerza
        Intelligence = 10; // Valor predeterminado de inteligencia
        Dexterity = 10; // Valor predeterminado de destreza
        Health = 100; // Valor predeterminado de salud
    }

    // Constructor para asignar valores personalizados a todos los campos
    public Human(string name, int strength, int intelligence, int dexterity, int health)
    {
        Name = name;
        Strength = strength;
        Intelligence = intelligence;
        Dexterity = dexterity;
        Health = health;
    }

    // Método Atacar
    public int Attack(Human target)
    {
        int damage = Strength * 3; // Cálculo de daño
        target.Health -= damage;   // Reducir la salud del objetivo
        return target.Health;       // Devolver la salud restante del objetivo
    }
}

class Program
{
    static void Main()
    {
        // Crear una instancia de la clase Human usando el constructor con argumentos
        Human person = new Human("Zero", 15, 12, 10, 100);
        
        // Mostrar los valores por pantalla
        Console.WriteLine("Nombre: " + person.Name);
        Console.WriteLine("Fuerza: " + person.Strength + " -> Cargado por 3");
        Console.WriteLine("Inteligencia: " + person.Intelligence);
        Console.WriteLine("Destreza: " + person.Dexterity);
        
        // Realizar un ataque y mostrar la salud restante del objetivo
        Human target = new Human("Rockman", 10, 8, 12, 100);
        int remainingHealth = person.Attack(target);
        
        Console.WriteLine("Salud Restante del Objetivo -> " + target.Name + " -> Salud : " + remainingHealth);
    }
}
