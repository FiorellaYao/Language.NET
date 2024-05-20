namespace EjercicioClase2Modulo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Utilizando LINQ resolver las siguientes consignas:

            //Carga de datos
            var lstClientes = new List<Clientes>()
            {
                new Clientes() { Apellido = "Jara", Nombre = "Alejandro" ,CodCliente = 123 , Vip = true},
                new Clientes() { Apellido = "Mossier", Nombre = "Fernando" ,CodCliente = 345 , Vip = false},
                new Clientes() { Apellido = "Bustos", Nombre = "Andres" ,CodCliente = 567 , Vip = true},
                new Clientes() { Apellido = "Dalpiaz", Nombre = "Carla" ,CodCliente = 789 , Vip = true},
                new Clientes() { Apellido = "Miranda", Nombre = "Micaela" ,CodCliente = 112 , Vip = false},
                new Clientes() { Apellido = "De Castillo", Nombre = "Andrea" ,CodCliente = 223 , Vip = false},
            };


            #region Ejercicio1 LINQ

            // Detectar cual es el numero mas grande e imprimirlo por consola

            var lstNumeros = new List<int>() { 25,10,99,105, 1, 84, 22};
        
            var listaNumerosFiltrados = lstNumeros.Max(x => x);

            Console.WriteLine($"El númnero más grande es: {listaNumerosFiltrados}");

            #endregion

            #region Ejercicio2 LINQ

            //Ordenar los nombres alfabeticamente
            var lstNombres = new List<string>() { "Ana", "Alejandro", "Alexis", "Pablo", "Carlos", "Anibal", "Carla", "Susana" };

            var listaNombresOrdenados = lstNombres.OrderBy(user => user).ToList();

            //ForEach no devuelve nada, solo recorre la lista
            listaNombresOrdenados.ForEach(user => Console.WriteLine($"Nombres ordenados alfabeticamente: {user}"));

            #endregion

            #region Ejercicio3 LINQ
            // Utilizando la variable "lstClientes" filtrar los clientes que tengan vip = true e imprimirlo por consola
            var listaClientesFiltrados = lstClientes.Where(cliente => cliente.Vip).ToList();

            listaClientesFiltrados.ForEach(cliente => Console.WriteLine($"Estos clientes son VIP: {cliente.Nombre}"));
            #endregion

            #region Ejercicio4 LINQ

            //Utilizando la variable "lstClientes" crear una nueva lista donde solo se encuentren los nombres de los clientes e imprimir los nombres
            
            // Seleccionar solo los nombres de los clientes
            var newListClientes = lstClientes.Select(nameCliente => new NewListClientes {Nombre = nameCliente.Nombre}).ToList();

            newListClientes.ForEach(nameCliente => Console.WriteLine($"Nombres de los clientes: {nameCliente.Nombre}"));

            #endregion

            #region Ejercicio5
            //Apartir de la variable "lstClientes" crear una lista que contenga todos los datos pero  modificando los siguientes campos:
            // Nombre tiene que guardarse en mayusculas
            // Apellido tiene que guardarse en mayusculas
            // Vip => se debe evaluar el bool y si es true se debe asignar el texto "Premium" y si es false "Normal"

            // Seleccionar sobre los datos de los clientes el nombre, el apellido y si es Vip
            var nuevaListaClientes = lstClientes.Select(modificadosClientes => new ModificadosClientes
            {
                CodCliente = modificadosClientes.CodCliente,
                Nombre = modificadosClientes.Nombre.ToUpper(),
                Apellido = modificadosClientes.Apellido.ToUpper(),
                Vip = modificadosClientes.Vip ? "Premium" : "Normal"
            }).ToList();

            nuevaListaClientes.ForEach(modificadoCliente => Console.WriteLine($"Clientes Modificados: {modificadoCliente.CodCliente + " " + modificadoCliente.Nombre + " " + modificadoCliente.Apellido + " " + modificadoCliente.Vip}")); 
            #endregion
        }
    }

    public class NewListClientes
    {
        public string Nombre { get; set; }
    }

    public class ModificadosClientes
    {
        public int CodCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Vip { get; set; }

    }
}