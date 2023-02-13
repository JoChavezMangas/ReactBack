using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactBack.DTOS
{
    public class EmpresasDTO
    {
        public string id { get; set; }
        public string name { get; set; }
        public string Phone { get; set; }
        public string email { get; set; }
        public string status { get; set; }
    }

    public class EmpleadoDTO
    {
        public string id { get; set; }
        public string name { get; set; }
        public string empresa { get; set; }
        public string area { get; set; }
        public string departamento { get; set; }
        public string areaDepartamento { get { return area + departamento; } }
        public string Puesto { get; set; }
        public string email { get; set; }
        public string status { get; set; }
    }

}
