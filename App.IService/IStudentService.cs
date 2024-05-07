using ZyferaCase.App.Dtos;

namespace ZyferaCase.App.IService
{
    public interface IStudentService
    {
        Task<bool> CreateStudentAsync(CreateStudentDto createStudentDto);
    }
}
