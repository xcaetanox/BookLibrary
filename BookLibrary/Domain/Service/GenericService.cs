
using Domain.Interface;
using Repository.Interfaces;

namespace Domain.Service
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        private readonly IRepositoryServices<T> _repository;

        public GenericService(IRepositoryServices<T> repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return _repository.GetAll();
        }

        public async Task<T> GetById(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task Create(T entity)
        {
            await _repository.CreateAsync(entity);
        }

        public async Task Update(T entity)
        {
            await _repository.UpdateAsync(entity);
        }

        public async Task Delete(T entity)
        {
            await _repository.DeleteAsync(entity);
        }
    }
}