using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ReactBack.DTOS
{
    public class EmpresasDTO
    {
        public string id { get; set; }
        public string name { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public string status { get; set; }
        public string RFC { get; set; }
        public string address { get; set; }
        public string businessName { get; set; }
        public string city { get; set; }
        public string colony { get; set; }
        public bool isVerified { get; set; }
        public string state { get; set; }
        public string zipCode { get; set; }
        //public IFormFile avatarUrl { get; set; }
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
