using DatabaseContext;
using DatabaseContext.Interfaces;
using DatabaseModel;

namespace Core.Services;

public class ExhibitionService
{
    private readonly IExhibitionRepository _exhibitionRepository;

    public ExhibitionService(IExhibitionRepository exhibitionRepository)
    {
        _exhibitionRepository = exhibitionRepository;
    }
    
    public async Task Add(string name, DateTime date)
    {
        var exhibition = Exhibition.Create(name, date);

        await _exhibitionRepository.Add(exhibition);
    }
    
    public async Task Update(Guid exhibitionId, string name, DateTime date)
    {
        await _exhibitionRepository.Update(exhibitionId, name, date);
    }

    public async Task Delete(Guid exhibitionId)
    {
        await _exhibitionRepository.Delete(exhibitionId);
    }
}