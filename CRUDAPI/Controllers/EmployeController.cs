using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUDAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeController : ControllerBase
    {

        List<Model.Employe> _oEmployes = new List<Model.Employe>()
        {
            new Model.Employe(){ id=1,name="Nethmee" },
             new Model.Employe(){ id=2,name="Ruwani" },
              new Model.Employe(){ id=3,name="Bishini" },
               new Model.Employe(){ id=4,name="Sheela"},
                new Model.Employe(){ id=5,name="Rukshana"},

        };


        [HttpGet]
        public IActionResult Gets()
        {
            if (_oEmployes.Count == 0)
            {
                return NotFound("No list was found");

            }
            return Ok(_oEmployes);

        }

        [HttpPost]
        public IActionResult Save(Model.Employe oEmploye)
        {
            _oEmployes.Add(oEmploye);
            if (_oEmployes.Count == 0)
            {
                return NotFound("No list was found");

            }
            return Ok(_oEmployes);
        }

        [HttpDelete]
        public IActionResult DeleteStudent(int id)
        {
            var oEmploye = _oEmployes.SingleOrDefault(x => x.id == id);
            if (_oEmployes == null)
            {
                return NotFound("No Student Found");
            }
            _oEmployes.Remove(oEmploye);
            if (_oEmployes.Count == 0)
            {
                return NotFound("No was list was found");

            }
            return Ok(_oEmployes);
        }
    }
}
