namespace EjercicioPOO.models;

public abstract class Persona
{
    protected Guid Id { get; set; }
    protected string? Nombre { get; set; }
    protected string? Apellido { get; set; }
    protected byte Edad { get; set; }

    // MostrarInformacion: Este método imprimirá en la consola la información de la persona (nombre completo y edad).
    public abstract void MostrarInformacion();
}
