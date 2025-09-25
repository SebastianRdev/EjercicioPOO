namespace EjercicioPOO.models;

public class Cliente : Persona
{
    public string? Email { get; set; }
    public string? Telefono { get; set; }

    public Cliente(string nombre, string apellido, byte edad, string email, string telefono)
    {
        Nombre = nombre;
        Apellido = apellido;
        Edad = edad;
        Email = email;
        Telefono = telefono;
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre} {Apellido}, Edad: {Edad}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Telefono: {Telefono}");
    }

    public bool TieneNombre(string nombre, string apellido)
    {
        return Nombre == nombre && Apellido == apellido;
    }

}
