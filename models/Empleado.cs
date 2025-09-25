namespace EjercicioPOO.models
{
    public class Empleado : Persona
    {
        public string? NumeroDeIdentificacion { get; set; }
        public decimal Salario { get; set; }
        public string? Posicion { get; set; }

        public Empleado(string nombre, string apellido, byte edad, string numeroId, decimal salario, string posicion)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            NumeroDeIdentificacion = numeroId;
            Salario = salario;
            Posicion = posicion;
        }

        private decimal CalcularBonificacion()
        {
            return Salario * 1.10M;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre} {Apellido}, Edad: {Edad}");
            Console.WriteLine($"Número de identificación: {NumeroDeIdentificacion}");
            Console.WriteLine($"Salario: {Salario:N0}");
            Console.WriteLine($"Salario con el bono de 10%: {CalcularBonificacion():N0}");
            Console.WriteLine($"Posición: {Posicion}");
        }

        public void ActualizarDatos(string nombre, string apellido, byte edad, decimal salario)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Salario = salario;
        }
    }
}