using Api_Task_Techtroll.co.Application.Interfaces;
using Api_Task_Techtroll.co.Domain.Entities;
using Api_Task_Techtroll.co.Infrastructure.Persistence;

namespace Api_Task_Techtroll.co.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IRepository<Product> _products;
        private IRepository<Component> _components;
        private IRepository<Subcomponent> _subcomponents;

      

        public UnitOfWork(ApplicationDbContext context )
        {
            _context = context;
            _products = new Repository<Product>(_context);
            _components = new Repository<Component>(_context);
            _subcomponents = new Repository<Subcomponent>(_context);



         
        }

       
        public IRepository<Product> Products => _products;
        public IRepository<Component> Components => _components;
        public IRepository<Subcomponent> Subcomponents => _subcomponents;

        public async Task<int> SaveAsync() => await _context.SaveChangesAsync();

        public void Dispose() => _context.Dispose();
    }
}
