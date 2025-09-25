namespace EjercicioPOO.models
{
    public class Empresa
    {
        public string? Nombre { get; set; }
        public string? Direccion { get; set; }
        public List<Empleado> ListaEmpleados { get; set; }
        public List<Cliente> ListaClientes { get; set; }

        // public Empresa(string nombre, string direccion)
        // {
        //     Nombre = nombre;
        //     Direccion = direccion;
        //     ListaEmpleados = new List<Empleado>();
        //     ListaClientes = new List<Cliente>();
        // }


        // AgregarEmpleado: Este método permitirá agregar un empleado a la lista de empleados.
        public void AgregarEmpleado(Empleado empleado)
        {
            ListaEmpleados.Add(empleado);
            Console.WriteLine($"Empleado agregado a la empresa");
        }

        // EliminarEmpleado: Este método permitirá eliminar un empleado de la lista utilizando su número de identificacion.
        public void EliminarEmpleado(string numerodeidentificacion)
        {
            var empleado = ListaEmpleados.FirstOrDefault(e => e.NumeroDeIdentificacion == numerodeidentificacion);
            if (empleado != null)
            {
                ListaEmpleados.Remove(empleado);
                Console.WriteLine($"Empleado eliminado de la empresa {Nombre}");
            }
        }

        // MostrarTodosLosEmpleados: Este método imprimirá en la consola la información de todos los empleados en la lista.
        public void MostrarTodosLosEmpleados()
        {
            Console.WriteLine($"Empleados de la empresa {Nombre}:");
            foreach (var empleado in ListaEmpleados)
            {
                empleado.MostrarInformacion();
            }
        }

        // ActualizarEmpleado: Este método permitirá actualizar un empleado de la lista utilizando su número de identificacion.
        public void ActualizarEmpleado(string numeroDeIdentificacion, string nombre, string apellido, byte edad, decimal salario)
        {
            var empleado = ListaEmpleados.FirstOrDefault(e => e.NumeroDeIdentificacion == numeroDeIdentificacion);
            if (empleado != null)
            {
                empleado.ActualizarDatos(nombre, apellido, edad, salario);
            }
        }

        // BuscarEmpleado: Este método permitirá buscar un empleado por numero de documento
        public Empleado? BuscarEmpleado(string numeroDeIdentificacion)
        {
            var empleado = ListaEmpleados.FirstOrDefault(e => e.NumeroDeIdentificacion == numeroDeIdentificacion);
            if (empleado != null)
            {
                empleado.MostrarInformacion();
            }
            return empleado;
        }

        // MostrarEmpleadosPorCargo: Este método me permitirá buscar a los empleados pero de acuerdo a su cargo, ejemplo me debe mostrar a todos los “supervisores”
        public void MostrarEmpleadosPorPosicion(string posicion)
        {
            var empleadosPorPosicion = ListaEmpleados.Where(e => e.Posicion == posicion).ToList();
            if (empleadosPorPosicion.Any())
            {
                Console.WriteLine($"Empleados con posición de {posicion} en la empresa {Nombre}:");
                foreach (var empleado in empleadosPorPosicion)
                {
                    empleado.MostrarInformacion();
                }
            }
            else
            {
                Console.WriteLine($"No hay empleados con posición de {posicion} en la empresa {Nombre}.");
            }
        }

        // AgregarCliente: Este método permitirá agregar un cliente a la lista de clientes.
        public void AgregarCliente(Cliente cliente)
        {
            ListaClientes.Add(cliente);
            Console.WriteLine($"Cliente agregado a la empresa {Nombre}");
        }

        // EliminarCliente: Este método permitirá eliminar un cliente de la lista utilizando su nombre y apellido.
        public void EliminarCliente(string nombre, string apellido)
        {
            var cliente = ListaClientes.FirstOrDefault(c => c.TieneNombre(nombre, apellido));
            if (cliente != null)
            {
                ListaClientes.Remove(cliente);
                cliente.MostrarInformacion();
            }
        }

        // MostrarTodosLosClientes: Este método imprimirá en la consola la información de todos los clientes en la lista.
        public void MostrarTodosLosClientes()
        {
            Console.WriteLine($"Clientes de la empresa {Nombre}:");
            foreach (var cliente in ListaClientes)
            {
                cliente.MostrarInformacion();
            }
        }

    }
}