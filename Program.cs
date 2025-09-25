using EjercicioPOO.models;

class Program
{
    static void Main()
    {
        Administracion.MostrarTitulo("Sistema de Administración");

        var empleado = Administracion.CrearEmpleado();
        var cliente = Administracion.CrearCliente();

        Administracion.MostrarSeparador();
        Console.WriteLine("Empleado creado:");
        empleado.MostrarInformacion();

        Administracion.MostrarSeparador();
        Console.WriteLine("Cliente creado:");
        cliente.MostrarInformacion();

        Administracion.MostrarPie("Fin del Programa");
    }
}
