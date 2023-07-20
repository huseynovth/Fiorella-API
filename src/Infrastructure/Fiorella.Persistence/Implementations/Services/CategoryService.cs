using Fiorella.Aplication.Abstraction.Repository;
using Fiorella.Aplication.Abstraction.Services;
using Fiorella.Aplication.DTOs.CategoryDTOs;

namespace Fiorella.Persistence.Implementations.Services;

public class CategoryService : ICategoryService
{
    private readonly ICategoryReadRepository _readRepository;

    public CategoryService(ICategoryReadRepository readRepository,
                           ICategoryWriteRepository writeRepository)
    {
        _readRepository = readRepository;
        _writeRepository = writeRepository;
    }

    private readonly ICategoryWriteRepository _writeRepository;
    public Task CreateAsync(CategoryCreateDto categoryCreateDto)
    {
        throw new NotImplementedException();
    }

    public Task<List<CategoryGetDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<CategoryGetDto> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }
}
