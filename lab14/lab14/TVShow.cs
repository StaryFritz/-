using System;
using System.Collections.Generic;
using System.Text;

namespace lab14
{
    [Serializable]
    public class TVShow
    {
        [NonSerialized]
        Random rnd = new Random();
        public string Name { get; set; }
        private int Length { get; set; }
        public TVShow()
        {
            Name = "Some TVShow";
            Length = rnd.Next(30, 180);
        }
        public TVShow(string name)
        {
            Name = name;
            Length = rnd.Next(30, 180);
        }
        public override string ToString()
        {
            return $"It's a {Name} which last for - {Length}";
        }
    }
    [Serializable]
    public class Movie : TVShow
    {
        public string Genre { get; set; }
        public Movie()
        {
            Name = "Movie";
        }
        public Movie(string name, int length, string genre) : base(name)
        {
            Genre = genre;
        }
        public override string ToString()
        {
            return $"It's {this.GetType()}, name - {this.Name}";
        }
        public override bool Equals(object obj)
        {
            Movie someMovie = (Movie)obj;
            return (Name == someMovie.Name && Genre == someMovie.Genre);
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
