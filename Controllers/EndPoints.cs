using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReactBack.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactBack.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EndPoints : Controller
    {

        [HttpGet("EmpresasDTOsForBandeja")]
        public List<EmpresasDTO> EmpresasDTOsForBandeja()
        {
            List<EmpresasDTO> result = new List<EmpresasDTO>();

            EmpresasDTO empresasDTO = new EmpresasDTO() { id = Guid.NewGuid().ToString(), name = "Nombre", Phone = "961-895-15", email = "akjs@ejje.com", status = "status" };

            result.Add(empresasDTO);

            return result;
        }

        [HttpGet("EmpleadosDTOsForBandeja")]
        public List<EmpleadoDTO> EmpleadosDTOsForBandeja(string FilterValue="", string operatorValue="",string columnField="")
        {
            List<EmpleadoDTO> result = new List<EmpleadoDTO>();

            EmpleadoDTO empresasDTO0 = new EmpleadoDTO() 
            { 
                id=Guid.NewGuid().ToString(), 
                name = "Silvia Ramirez",
                empresa = "APA",
                area="Sistemas",
                departamento = "Desarrollo",
                Puesto="Gerente Desarrollo",
                email = "akjs@ejje.com", status = "Activo" 
            };

            EmpleadoDTO empresasDTO1 = new EmpleadoDTO()
            {
                id = Guid.NewGuid().ToString(),
                name = "Mario Neri",
                empresa = "APA",
                area = "Sistemas",
                departamento = "Infraestructura",
                Puesto = "Gerente infraestrucutra",
                email = "akjs@ejje.com",
                status = "Activo"
            };

            EmpleadoDTO empresasDTO2 = new EmpleadoDTO()
            {
                id = Guid.NewGuid().ToString(),
                name = "Marconi Vanner",
                empresa = "APA",
                area = "Sistemas",
                departamento = "Infraestructura",
                Puesto = "Operador Infraestructura",
                email = "akjs@ejje.com",
                status = "Activo"
            };

            EmpleadoDTO empresasDTO3 = new EmpleadoDTO()
            {
                id = Guid.NewGuid().ToString(),
                name = "Martin Badillo",
                empresa = "APA",
                area = "Sistemas",
                departamento = "Desarrollo",
                Puesto = "Operador Desarrollo",
                email = "akjs@ejje.com",
                status = "Activo"
            };

            EmpleadoDTO empresasDTO4 = new EmpleadoDTO()
            {
                id = Guid.NewGuid().ToString(),
                name = "Cesar Martinez",
                empresa = "APA",
                area = "Sistmeas",
                departamento = "Soporte Plataformas",
                Puesto = "Encargado",
                email = "akjs@ejje.com",
                status = "Activo"
            };

            EmpleadoDTO empresasDTO5 = new EmpleadoDTO()
            {
                id = Guid.NewGuid().ToString(),
                name = "Natalia Barcos",
                empresa = "APA",
                area = "Sistemas",
                departamento = "SAP",
                Puesto = "Encargada departamento",
                email = "akjs@ejje.com",
                status = "Activo"
            };

            result.Add(empresasDTO0);
            result.Add(empresasDTO1);
            result.Add(empresasDTO2);
            result.Add(empresasDTO3);
            result.Add(empresasDTO4);
            result.Add(empresasDTO5);

            return result;
        }



        



        // GET: EndPoints
        public ActionResult Index()
        {
            return View();
        }

        // GET: EndPoints/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EndPoints/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EndPoints/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EndPoints/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EndPoints/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EndPoints/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EndPoints/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
