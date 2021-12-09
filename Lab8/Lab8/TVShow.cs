using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8
{
    class TVShow : IComparable
    {
        public string name;
        public int year;
        public TVShow(string name, int year)
        {
            this.name = name;
            if (year > 2021)
                throw new Exception("year is too large");
            this.year = year;
        }
        public int CompareTo(object tvShow)
        {
            return name.CompareTo(tvShow);
        }
    }
}
