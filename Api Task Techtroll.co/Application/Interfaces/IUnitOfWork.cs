using Api_Task_Techtroll.co.Domain.Entities;

namespace Api_Task_Techtroll.co.Application.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
   
        IRepository<Product> Products { get; }
        IRepository<Component> Components { get; }
        IRepository<Subcomponent> Subcomponents { get; }


        Task<int> SaveAsync();
    }
}
