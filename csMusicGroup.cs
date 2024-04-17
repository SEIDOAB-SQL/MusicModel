using System;
using System.Collections.Generic;

namespace MusicModel
{
	public class csMusicGroup
	{
		public string Name { get; set; }
		public int EstablishedYear { get; set; }

		public List<csArtist> Members { get; set; }
		public List<csAlbum>  Albums { get; set; }

        public override string ToString() =>
            $"{Name} with {Members.Count} members was esblished {EstablishedYear} and made {Albums.Count} great albums. ";

        #region Random Seeding
        public bool Seeded { get; set; } = false;

        public csMusicGroup Seed(csSeedGenerator _seeder)
        {
                //Create between 3 and 8 Members
            var _members = new List<csArtist>();
            for (int i = 3; i < _seeder.Next(4, 9); i++)
            {
                _members.Add(new csArtist().Seed(_seeder));
            }

            //Create between 5 and 16 Albums
            var _albums = new List<csAlbum>();
            for (int i = 5; i < _seeder.Next(6, 17); i++)
            {
                _albums.Add(new csAlbum().Seed(_seeder));
            }

            return new csMusicGroup
            {
                Name = _seeder.MusicGroupName,
                EstablishedYear = _albums.Min(a => a.ReleaseYear),
                Members = _members,
                Albums = _albums,

                Seeded = true
            };
        }
        #endregion
    }
}

