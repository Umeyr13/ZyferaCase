using ZyferaCase.App.Domain.Entities;

namespace ZyferaCase.App.Dtos
{
    public class CreateStudentDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string StdNumber { get; set; }
        public List<Grade> Grades { get; set; }
    }
}
