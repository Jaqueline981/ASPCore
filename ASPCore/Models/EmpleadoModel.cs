using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCore.Models
{
    public class EmpleadoModel
    {
        public string NoEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Departamento { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string NoProducto { get; set; }
    }
}
