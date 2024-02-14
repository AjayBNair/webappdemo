using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("GetStudentList")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public string StudentName()
        {
            return "Student Name";
            {

            }
        }
    }
}
