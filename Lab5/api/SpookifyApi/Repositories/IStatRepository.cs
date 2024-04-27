using SpookifyApi.Models;

namespace SpookifyApi.Repositories;

public interface IStatRepository
{
    Task<int> Add(StatModel statModel); // returns id if successful, 0 if not
    Task<bool> Update(StatModel statModel);
    Task<bool> Delete(int statId);
    Task<StatModel> Get(int statId);
    Task<IEnumerable<StatModel>> Get();
}