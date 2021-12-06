using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;

namespace lab6
{
    class Controller
    {
        public List<TVShow> findMovie(ProgramGuide programGuide, int year)
        {
            return programGuide.tvShow.FindAll(movie => movie.year == year);
        }
        public int AdsCounter(TVShow tvShow)
        {
            int count = 0;
            foreach (var item in tvShow.ads)
                count++;
            return count;
        }
        public static int timeCounter(TVShow tvShow)
        {
            int sum = tvShow.length;
            foreach (var item in tvShow.ads)
                sum += item.length;
            return sum;
        }
        public void readFile(ProgramGuide programGuide)
        {
            string s;
            StreamReader f = new StreamReader("text.txt");
            while((s = f.ReadLine()) != null)
            {
                TVShow tvShow = new TVShow(s);
                programGuide.Add(tvShow);
            }
        }
        public void readJsonFile(ProgramGuide programGuide)
        {
        }
    }
}
