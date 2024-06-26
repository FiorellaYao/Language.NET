using System.ComponentModel.DataAnnotations;
using System.Globalization;
using Microsoft.EntityFrameworkCore;

namespace Ejercicio4Modulo2
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region PUNTO 1
            //Conectar a Base de Datos
            var options = new DbContextOptionsBuilder<BDContext>();
            options.UseSqlServer("Data Source=CDA-AR-0957\\SQL;Initial Catalog=Ejercicio4Modulo2;Integrated Security=True;Trust Server Certificate=True");
            #endregion

            #region PUNTO 2
            using (var context = new BDContext(options.Options))
            {
                // Leer archivo txt
                string path = $"{AppDomain.CurrentDomain.BaseDirectory}\\data.txt";
                var file = File.ReadAllLines(path);

                var fechaParametriaStr = context.Parametria
                                             .Where(p => p.Key == "fecha_proceso")
                                             .Select(p => p.Value)
                                             .FirstOrDefault();

                //Parsear significa convertir. En este caso se parsea "fechaParametria": La cadena de texto que contiene la fecha a convertir.
                //(!DateTime.TryParseExact(...)): Verifica si la cadena no pudo ser convertida a DateTime
                if (fechaParametriaStr == null || !DateTime.TryParseExact(fechaParametriaStr, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out var fechaParametriaAct))
                // Variable de salida (out var fechaParametriaAct): Variable donde se almacena la fecha parseada si la conversión tiene éxito
                {
                    Console.WriteLine("Registro rechazado");
                    return;
                }

                foreach (var line in file)
                {
                    var registro = ParsearLinea(line);
                    var venta = ValidarRegistro(registro, fechaParametriaAct);

                    if (venta.Any())
                    {
                        InsertarRechazo(context, registro, venta);
                    }
                    else
                    {
                        InsertarVentasMensuales(context, registro);
                    }
                }

                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                    Console.WriteLine(ex.InnerException?.Message);
                }

                GenerarListas(context);
            }
        }

        private static Dictionary<string, string> ParsearLinea(string line)
        {
            return new Dictionary<string, string>
    {
        { "fecha", line.Substring(0, 10).Trim() },
        { "cod_vendedor", line.Substring(10, 3).Trim() },
        { "venta", line.Substring(13, 11).Trim() },
        { "venta_empresa_grande", line.Substring(24, 1).Trim() }
    };
        }

        private static List<string> ValidarRegistro(Dictionary<string, string> registro, DateTime fechaParametria)
        {
            var venta = new List<string>();

            // Validar fecha del informe y fecha de parametria
            if (!DateTime.TryParseExact(registro["fecha"], "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out var fechaDelInforme) || fechaDelInforme != fechaParametria)
            {
                venta.Add("Registro Rechazado. Fecha del informe no coincide con la fecha de parametría");
            }

            // Validar código del vendedor
            if (string.IsNullOrWhiteSpace(registro["cod_vendedor"]))
            {
                venta.Add("Registro Rechazado. Código del vendedor faltante");
            }

            // Validar venta
            if (!decimal.TryParse(registro["venta"], out _))
            {
                venta.Add("Registro Rechazado. Venta inválida");
            }

            // Validar flag de venta a empresa grande. Cualquier dato diferente a S o N se rechaza
            if (registro["venta_empresa_grande"] != "S" && registro["venta_empresa_grande"] != "N")
            {
                venta.Add("Registro Rechazado. Flag de Venta a empresa grande inválido");
            }

            return venta;
        }
        #endregion

        #region PUNTO 3 
        private static void InsertarVentasMensuales(BDContext context, Dictionary<string, string> registro)
        {
            context.VentasMensuales.Add(new VentasMensuales
            {
                FechaInforme = DateTime.ParseExact(registro["fecha"], "yyyy-MM-dd", CultureInfo.InvariantCulture),
                CodVendedor = registro["cod_vendedor"],
                Venta = decimal.Parse(registro["venta"]),
                VentaEmpresaGrande = registro["venta_empresa_grande"] == "S"
            });
        }
        #endregion

        #region PUNTO 4
        private static void InsertarRechazo(BDContext context, Dictionary<string, string> registro, List<string> venta)
        {
            context.Rechazos.Add(new Rechazos
            {
                RegistroOriginal = string.Join(",", registro.Values),
                Error = string.Join(";", venta)
            });
        }
        #endregion

        #region PUNTO 5
        private static void GenerarListas(BDContext context)
        {
            // Vendedores que superaron los 100,000 en el mes
            var vendedoresSuperaron100k = context.VentasMensuales
                .GroupBy(v => v.CodVendedor)
                .Select(l => new { CodVendedor = l.Key, TotalVenta = l.Sum(v => v.Venta) })
                .Where(l => l.TotalVenta > 100000)
                .ToList();

            Console.WriteLine("Vendedores que superaron los 100.000 en el mes: ");
            foreach (var vendedor in vendedoresSuperaron100k)
            {
                Console.WriteLine($"El vendedor {vendedor.CodVendedor} vendió {vendedor.TotalVenta}");
            }
        #endregion
       
        #region PUNTO 6 
            // Vendedores que no superaron los 100,000 en el mes
            var vendedoresNoSuperaron100k = context.VentasMensuales
                .GroupBy(v => v.CodVendedor)
                .Select(l => new { CodVendedor = l.Key, TotalVenta = l.Sum(v => v.Venta) })
                .Where(l => l.TotalVenta < 100000)
                .ToList();

            Console.WriteLine("Vendedores que no superaron los 100.000 en el mes: ");
            foreach (var vendedor in vendedoresNoSuperaron100k)
            {
                Console.WriteLine($"El vendedor {vendedor.CodVendedor} vendió {vendedor.TotalVenta}");
            }
        #endregion
        
        #region PUNTO 7
            // Vendedores que vendieron al menos una vez a una empresa grande
            var vendedoresEmpresaGrande = context.VentasMensuales
                .Where(v => v.VentaEmpresaGrande)
                .Select(v => v.CodVendedor)
                .Distinct()
                .ToList();

            Console.WriteLine("Vendedores que vendieron al menos una vez a una empresa grande: ");
            foreach (var vendedor in vendedoresEmpresaGrande)
            {
                Console.WriteLine($"El vendedor {vendedor}");
            }
        #endregion
        
        #region PUNTO 8
            // Listar rechazos
            var rechazos = context.Rechazos.ToList();
            foreach (var rechazo in rechazos)
            {
                Console.WriteLine($"Rechazo: {rechazo.Error}, Registro Original: {rechazo.RegistroOriginal}");
            }
        }
        #endregion
    }
}