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
    private static void WriteModel(List<csMusicGroup> _greatMusicBands)
    {
        /*
        foreach (var band in _greatMusicBands)
        {
            Console.WriteLine(band);
        }
        */

        Console.WriteLine($"Nr of great music bands: {_greatMusicBands.Count()}");
        Console.WriteLine($"Total nr of albums produced: {_greatMusicBands.Sum(b => b.Albums.Count)}");
        Console.WriteLine($"Total nr of music band members: {_greatMusicBands.Sum(b => b.Members.Count)}");

        Console.WriteLine($"First Friend: {_greatMusicBands.First()}");
        Console.WriteLine($"Last Friend: {_greatMusicBands.Last()}");

    }

    private static List<csMusicGroup> SeedModel(int nrItems)
    {
        var _seeder = new csSeedGenerator();

        //Create a list of 20 great bands
        var _greatMusicBands = new List<csMusicGroup>();
        for (int c = 0; c < nrItems; c++)
        {
            _greatMusicBands.Add(new csMusicGroup().Seed(_seeder));
        }

        return _greatMusicBands;
    }
    #endregion
}

