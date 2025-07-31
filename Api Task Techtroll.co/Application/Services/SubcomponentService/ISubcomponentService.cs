using Api_Task_Techtroll.co.Application.DTOs;

namespace Api_Task_Techtroll.co.Application.Services.SubcomponentService
{
    public interface ISubcomponentService
    {
        Task<IEnumerable<SubcomponentDto>> GetAllAsync();
        Task<SubcomponentDto?> GetByIdAsync(int id);
        Task<int> CreateAsync(CreateSubcomponentDto dto);
        Task<bool> UpdateAsync(UpdateSubcomponentDto dto);
        Task<bool> DeleteAsync(int id);
    }
}
