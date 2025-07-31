using Api_Task_Techtroll.co.Application.DTOs;
using Api_Task_Techtroll.co.Application.Interfaces;
using Api_Task_Techtroll.co.Domain.Entities;
using AutoMapper;

namespace Api_Task_Techtroll.co.Application.Services.SubcomponentService
{
    public class SubcomponentService : ISubcomponentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SubcomponentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<SubcomponentDto>> GetAllAsync()
        {
            var entities = await _unitOfWork.Subcomponents.GetAllAsync();
            return _mapper.Map<IEnumerable<SubcomponentDto>>(entities);
        }

        public async Task<SubcomponentDto?> GetByIdAsync(int id)
        {
            var entity = await _unitOfWork.Subcomponents.GetByIdAsync(id);
            return entity == null ? null : _mapper.Map<SubcomponentDto>(entity);
        }

        public async Task<int> CreateAsync(CreateSubcomponentDto dto)
        {
            var entity = _mapper.Map<Subcomponent>(dto);
            await _unitOfWork.Subcomponents.AddAsync(entity);
            await _unitOfWork.SaveAsync();
            return entity.Id;
        }

        public async Task<bool> UpdateAsync(UpdateSubcomponentDto dto)
        {
            var entity = await _unitOfWork.Subcomponents.GetByIdAsync(dto.Id);
            if (entity == null) return false;

            _mapper.Map(dto, entity);
            _unitOfWork.Subcomponents.Update(entity);
            await _unitOfWork.SaveAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var entity = await _unitOfWork.Subcomponents.GetByIdAsync(id);
            if (entity == null) return false;

            _unitOfWork.Subcomponents.Remove(entity);
            await _unitOfWork.SaveAsync();
            return true;
        }
    }
}
