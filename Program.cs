namespace MusicModel;
class Program
{
    const int nrItemsSeed = 50;

    static void Main(string[] args)
    {
        var _modelList = SeedModel(nrItemsSeed);
        WriteModel(_modelList);
    }

    #region Replaced by new model methods
    private static void WriteModel(List<csMusicGroup> _modelList)
    {
        Console.WriteLine($"Nr of great music bands: {_modelList.Count()}");
        Console.WriteLine($"Total nr of albums produced: {_modelList.Sum(b => b.Albums.Count)}");
        Console.WriteLine($"Total nr of music band members: {_modelList.Sum(b => b.Members.Count)}");

        Console.WriteLine($"First Music group: {_modelList.First()}");
        _modelList.First().Albums.ForEach(album => Console.WriteLine($"  - {album.Name}"));

        Console.WriteLine($"Last Music group: {_modelList.Last()}");
        _modelList.Last().Albums.ForEach(album => Console.WriteLine($"  - {album.Name}"));

    }

    private static List<csMusicGroup> SeedModel(int nrItems)
    {
        var _seeder = new csSeedGenerator();

        //Create a list of 20 great bands
        var _musicgroups = _seeder.ItemsToList<csMusicGroup>(nrItems);
        var _artists = _seeder.ItemsToList<csArtist>(nrItems*8);

        _musicgroups.ForEach(m => {

            //pick 4 to 8 members from the list of _artists
            m.Members = _seeder.UniqueIndexPickedFromList(_seeder.Next(4, 9), _artists);

            //Create between 5 and 16 Albums
            m.Albums = new List<csAlbum>();
            for (int i = 5; i < _seeder.Next(6, 17); i++)
            {
                m.Albums.Add(new csAlbum().Seed(_seeder));
            }

            m.EstablishedYear = m.Albums.Min(a => a.ReleaseYear);
        });

        return _musicgroups;
    }
    #endregion
}

