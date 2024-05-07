using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using System.Net;
using ZyferaCase.App.Dtos;
using ZyferaCase.App.IService;

namespace ZyferaCase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateStudent(CreateStudentDto createStudentDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _studentService.CreateStudentAsync(createStudentDto);
            if (result)
            {
                return StatusCode((int)HttpStatusCode.Created);
            }

            throw new Exception("Hata Oluştu");
        }
    }
}
