namespace ZyferaCase.App.Domain.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string StdNumber { get; set; }
        public List<Grade> Grades { get; set; }
    }
}
