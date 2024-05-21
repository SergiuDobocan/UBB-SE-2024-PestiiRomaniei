using SpookifyApi.Models;
using SpookifyApi.Repositories;
using System.ComponentModel.DataAnnotations;

namespace SpookifyApi.Services;

public class StatService
{
    private readonly IStatRepository _statRepository;

    public StatService(IStatRepository statRepository)
    {
        _statRepository = statRepository;
    }

    // Check if statModel is valid
    private void ValidateSongModel(StatModel statModel, string errorString)
    {
        var validationContext = new ValidationContext(statModel);
        var validationResults = new List<ValidationResult>();
        if (!Validator.TryValidateObject(statModel, validationContext, validationResults, true))
        {
            throw new ValidationException(errorString + '-' + validationResults);
        }
    }

    public async Task<int> Add(StatModel statModel)
    {
        ValidateSongModel(statModel, "Validation failed when trying to add stat.");
        try
        {
            return await _statRepository.Add(statModel);
        }
        catch (Exception e)
        {
            throw new Exception("Failed to add stat.");
        }
    }

    public async Task<bool> Update(StatModel statModel)
    {
        ValidateSongModel(statModel, "Validation failed when trying to update stat.");
        try
        {
            return await _statRepository.Update(statModel);
        }
        catch (Exception e)
        {
            throw new Exception("Failed to update stat.");
        }
    }

    public async Task<int> IncrementStreams(int songId)
    {
        try
        {
            var stats = await _statRepository.Get();
            var songStats = stats.Where(s => s.SongID == songId);
            var songStat = songStats.FirstOrDefault();
            if (songStat != null)
            {
                songStat.Streams++;
                return await _statRepository.Update(songStat) ? songStat.Streams : 0;
            }
        }
        catch (Exception e)
        {
            throw new Exception("Failed to increment streams.");
        }

        return 0;
    }

    public async Task<bool> Delete(int statId)
    {
        try
        {
            return await _statRepository.Delete(statId);
        }
        catch (Exception e)
        {
            throw new Exception("Failed to delete stat.");
        }
    }

    public async Task<bool> DeleteBySongId(int songId)
    {
        try
        {
            var stats = await _statRepository.Get();
            var songStats = stats.Where(s => s.SongID == songId);
            var songStat = songStats.FirstOrDefault();
            if (songStat != null)
            {
                return await _statRepository.Delete(songStat.StatID);
            }
        }
        catch (Exception e)
        {
            throw new Exception("Failed to delete stat.");
        }

        return false;
    }

    public async Task<StatModel> Get(int statId)
    {
        try
        {
            return await _statRepository.Get(statId);
        }
        catch (Exception e)
        {
            throw new Exception("Failed to get stat.");
        }
    }

    public async Task<int> GetStreams(int songId)
    {
        try
        {
            var stats = await _statRepository.Get();
            var songStats = stats.Where(s => s.SongID == songId);
            var songStat = songStats.FirstOrDefault();
            return songStat?.Streams ?? 0;
        }
        catch (Exception e)
        {
            throw new Exception("Failed to get streams.");
        }
    }

    public async Task<IEnumerable<StatModel>> Get()
    {
        try
        {
            return await _statRepository.Get();
        }
        catch (Exception e)
        {
            throw new Exception("Failed to get stats.");
        }
    }
}