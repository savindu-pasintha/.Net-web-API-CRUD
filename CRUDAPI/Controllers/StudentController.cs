using CRUDAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUDAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        List<Model.Student> _oStudents = new List<Model.Student>()
        {
            new Model.Student(){ Id=1,Name="Nethmee",ROLE=1001 },
             new Model.Student(){ Id=2,Name="Ruwani",ROLE=1002 },
              new Model.Student(){ Id=3,Name="Bishini",ROLE=1003 },
               new Model.Student(){ Id=4,Name="Sheela",ROLE=1004 },
                new Model.Student(){ Id=5,Name="Rukshana",ROLE=1005 },

        };
 

        [HttpGet]
        public IActionResult Gets()
        {
            if (_oStudents.Count == 0)
            {
                return NotFound("No list was found");

            }
            return Ok(_oStudents);

        }

        [HttpPost]
        public IActionResult Save(Model.Student oStudent )
        {
            _oStudents.Add(oStudent);
            if(_oStudents.Count == 0)
            {
                return NotFound("No list was found");

            }
            return Ok(_oStudents);
        }

        [HttpDelete]
        public IActionResult DeleteStudent(int id)
        {
            var oStudent = _oStudents.SingleOrDefault(x => x.Id  == id);
            if(_oStudents == null)
            {
                return NotFound("No Student Found");
            }
            _oStudents.Remove(oStudent);
            if (_oStudents.Count == 0)
            {
                return NotFound("No was list was found");

            }
            return Ok(_oStudents);
        }
         
        



    }
}
