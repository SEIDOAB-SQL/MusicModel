using System;
using System.Collections.Generic;

namespace MusicModel
{
	public class csMusicGroup : ISeed<csMusicGroup>
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

            return new csMusicGroup
            {
                Name = _seeder.MusicGroupName,
                EstablishedYear = 0,

                Seeded = true
            };
        }
        #endregion
    }
}

