using Api_Task_Techtroll.co.Application.DTOs;
using Api_Task_Techtroll.co.Application.Interfaces;
using Api_Task_Techtroll.co.Domain.Entities;
using AutoMapper;

namespace Api_Task_Techtroll.co.Application.Services.ComponentService
{
    public class ComponentService : IComponentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ComponentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ComponentDto>> GetAllAsync()
        {
            var components = await _unitOfWork.Components.GetAllAsync();
            return _mapper.Map<IEnumerable<ComponentDto>>(components);
        }

        public async Task<ComponentDto?> GetByIdAsync(int id)
        {
            var component = await _unitOfWork.Components.GetByIdAsync(id);
            return component == null ? null : _mapper.Map<ComponentDto>(component);
        }

        public async Task<int> CreateAsync(CreateComponentDto dto)
        {
            var component = _mapper.Map<Component>(dto);
            await _unitOfWork.Components.AddAsync(component);
            await _unitOfWork.SaveAsync();
            return component.Id;
        }

        public async Task<bool> UpdateAsync(UpdateComponentDto dto)
        {
            var component = await _unitOfWork.Components.GetByIdAsync(dto.Id);
            if (component == null) return false;

            _mapper.Map(dto, component);
            _unitOfWork.Components.Update(component);
            await _unitOfWork.SaveAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var component = await _unitOfWork.Components.GetByIdAsync(id);
            if (component == null) return false;

            _unitOfWork.Components.Remove(component);
            await _unitOfWork.SaveAsync();
            return true;
        }
    }
}
