using SpookifyApi.Models;

namespace SpookifyApi.Repositories;

public interface ISongRepository
{
    Task<int> Add(SongModel songModel); //returns id if successful, 0 if not
    Task<bool> Update(SongModel songModel);
    Task<bool> Delete(int songId);
    Task<SongModel> Get(int songId);
    Task<IEnumerable<SongModel>> Get();
}