using LabKendo.Models;
using Microsoft.AspNetCore.Mvc;

namespace LabKendo.Controllers
{
    public class EstudiantesController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LeerEstudiantes([DataSourceRequest] DataSourceRequest request)
        {
            

        [HttpPost]
        public ActionResult CrearEstudiante([DataSourceRequest] DataSourceRequest request, Estudiante estudiante)
        {
            

        [HttpPost]
        public ActionResult ActualizarEstudiante([DataSourceRequest] DataSourceRequest request, Estudiante estudiante)
        {
           
        }

        [HttpPost]
        public ActionResult EliminarEstudiante([DataSourceRequest] DataSourceRequest request, Estudiante estudiante)
        {
            // Elimine el estudiante de su fuente de datos
        }
    }


}
