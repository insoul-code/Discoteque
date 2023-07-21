using Discoteque.Business.IServices;
using Discoteque.Data.Models;

namespace Discoteque.Business.Services;

public class ArtistService : IArtistService
{
    public async Task<Artist> CreateArtist(Artist artist)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Artist>> GetArtistsAsync()
    {
        int min = 1;
        int max = 100;
        Random rnd = new Random();
        var names = new List<string>() { "Aerophone", "Fly so high", "Rodolfo Aicardi", "Dua Lipa", "Kase O" };
        var label = new List<string>() { "Emi", "Grammy", "Bilboards" };
        Random r = new Random();
        int indexLabel = r.Next( label.Count );
        string randomLabel = label[ indexLabel ];
        var list = new List<Artist>();

        foreach (var name in names)
        {
            list.Add(new Artist()
            {
                Id = rnd.Next(min, max),
                Name = name,
                Label = randomLabel,
                IsOnTour = rnd.Next(0, 2) == 1
            });
        }
        return list;
        // Implementar una lista de 5 artistas random id
    }

    public async Task<Artist> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<Artist> UpdateArtist(Artist artist)
    {
        throw new NotImplementedException();
    }
}