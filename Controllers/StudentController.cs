using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ZyferaCase.App.Dtos;

namespace ZyferaCase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CreateStudent(CreateStudentDto createStudentDto)
        {
            return Ok();
        }
    }
}
