using System;
using System.Collections.Generic;

namespace MusicModel
{
	public class csAlbum : ISeed<csAlbum>
	{
        public string Name { get; set; }
		public int ReleaseYear { get; set; }

    
        #region Random Seeding
        public bool Seeded { get; set; } = false;

        public csAlbum Seed(csSeedGenerator _seeder)
        {
            return new csAlbum
            {
                Name = _seeder.MusicAlbumName,
                ReleaseYear = _seeder.Next(1970, 1990),
    
                Seeded = true
            };
        }
        #endregion
    }
}

