using System;
using System.Collections.Generic;
using System.Text;

namespace lab7
{
    class ProgramGuide
    {
        public List<TVShow> tvShow { get; private set; }
        public ProgramGuide()
        {
            tvShow = new List<TVShow>();
        }
        public void Add(TVShow tvShow)
        {
            this.tvShow.Add(tvShow);
        }
        public void Remove(TVShow tvShow)
        {
            this.tvShow.Remove(tvShow);
        }
        public void Print()
        {
            foreach (var item in tvShow)
                Console.WriteLine($"name: {item.name}\nlength: {Controller.timeCounter(item)}\nyear: {item.year}");
        }
    }
}
