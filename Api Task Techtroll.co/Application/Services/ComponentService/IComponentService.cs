using Api_Task_Techtroll.co.Application.DTOs;

namespace Api_Task_Techtroll.co.Application.Services.ComponentService
{
    public interface IComponentService
    {
        Task<IEnumerable<ComponentDto>> GetAllAsync();
        Task<IEnumerable<ComponentDto>> GetComponentsByProductId(int productId);
        Task<ComponentDto?> GetByIdAsync(int id);
        Task<int> CreateAsync(CreateComponentDto dto);

        Task<bool> UpdateAsync(UpdateComponentDto dto);
        Task<bool> DeleteAsync(int id);
    }
}
