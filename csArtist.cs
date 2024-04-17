using System;
using System.Collections.Generic;

namespace MusicModel
{
	public class csArtist : ISeed<csArtist>
	{
        public string FirstName { get; set; }
        public string LastName { get; set; }

        #region Random Seeding
        public bool Seeded { get; set; } = false;

        public csArtist Seed(csSeedGenerator _seeder)
        {
            return new csArtist
            {
                FirstName = _seeder.FirstName,
                LastName = _seeder.LastName,
    
                Seeded = true
            };
        }
        #endregion
    }
}

