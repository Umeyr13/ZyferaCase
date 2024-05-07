using ZyferaCase.App.Domain.Entities;
using ZyferaCase.App.Dtos;
using ZyferaCase.App.IService;
using ZyferaCase.App.Persistence.Contexts;

namespace ZyferaCase.App.Service
{
    public class StudentService : IStudentService
    {
        private readonly AppDbContext _context;

        public StudentService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateStudentAsync(CreateStudentDto createStudentDto)
        {
            Student student = new Student{
            Name = createStudentDto.Name,
            Surname = createStudentDto.Surname,
            Grades = createStudentDto.Grades,
            StdNumber = createStudentDto.StdNumber
            };

            var courseGrades = student.Grades.GroupBy(g => g.Code).Select(g => new
            {
                CourseCode = g.Key,
                AvarageGrade = g.Average(grade => grade.Value)
            });//eğer varssa her bir öğrencinin not ortalamasını aldık.

            foreach (var course in courseGrades)
            {
                var grade = new Grade
                {
                    Code = course.CourseCode,
                    Value = (int)Math.Round(course.AvarageGrade)
                };
                student.Grades.Add(grade);
            }
            _context.Students.Add(student);
            var result= await _context.SaveChangesAsync();
            if (result>0)
            {
                return true;
            }
            return false;
        }
    }
}
