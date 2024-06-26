using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4Modulo2
{
    public class VentasMensuales
    {
        public int Id { get; set; }
        public DateTime FechaInforme { get; set; }
        public string CodVendedor { get; set; }
        public decimal Venta { get; set; }
        public bool VentaEmpresaGrande { get; set; }
    }
}
