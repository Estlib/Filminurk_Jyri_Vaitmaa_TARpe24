using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filminurk.Core.Domain
{
    public enum Genre
    {
        Horror,Action,Superhero,Anime,Romance,Comedy,AISlop,Documentary,MadeForTv,Cartoon,Silent,FilmNoir
    }
    public class Movie
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateOnly FirstPublished { get; set; }
        public string Director { get; set; }
        public List<string>? Actors { get; set; }
        public decimal? CurrentRating { get; set; }
        //public List<UserComment>? Reviews { get; set; }

        /* 3 õpilase valitud andmetüüpi */
        public string? CountryOfOrigin { get; set; }
        public Genre? MovieGenre { get; set; }
        public Genre? SubGenre { get; set; }

    }
}
