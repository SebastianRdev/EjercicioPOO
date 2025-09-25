namespace EjercicioPOO.models;

public static class Administracion
    {
        // -------------------------------
        // Métodos para crear objetos
        // -------------------------------
        public static Empleado CrearEmpleado()
        {
            Console.WriteLine("=== Crear Empleado ===");

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine() ?? "";

            Console.Write("Apellido: ");
            string apellido = Console.ReadLine() ?? "";

            Console.Write("Edad: ");
            byte edad = byte.Parse(Console.ReadLine() ?? "0");

            Console.Write("Número de Identificación: ");
            string numeroId = Console.ReadLine() ?? "";

            Console.Write("Salario: ");
            decimal salario = decimal.Parse(Console.ReadLine() ?? "0");

            Console.Write("Posición: ");
            string posicion = Console.ReadLine() ?? "";

            return new Empleado(nombre, apellido, edad, numeroId, salario, posicion);

        }

        public static Cliente CrearCliente()
        {
            Console.WriteLine("=== Crear Cliente ===");

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine() ?? "";

            Console.Write("Apellido: ");
            string apellido = Console.ReadLine() ?? "";

            Console.Write("Edad: ");
            byte edad = byte.Parse(Console.ReadLine() ?? "0");

            Console.Write("Email: ");
            string email = Console.ReadLine() ?? "";

            Console.Write("Teléfono: ");
            string telefono = Console.ReadLine() ?? "";

            return new Cliente(nombre, apellido, edad, email, telefono);
        }

        // -------------------------------
        // Métodos visuales de consola
        // -------------------------------
        public static void MostrarTitulo(string titulo)
        {
            Console.WriteLine("==================================");
            Console.WriteLine($"         {titulo.ToUpper()}");
            Console.WriteLine("==================================");
        }

        public static void MostrarPie(string pie)
        {
            Console.WriteLine("==================================");
            Console.WriteLine($"         {pie}");
            Console.WriteLine("==================================\n");
        }

        public static void MostrarSeparador()
        {
            Console.WriteLine("----------------------------------");
        }
    }
