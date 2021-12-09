using System;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Set<int> set = new Set<int>();
                //set.Add(3);
                //set.Add(4);
                //set.Show();
                //set.Remove(1);
                //set.Remove(4);
                //set.Add(3);
                //set.Add(5);
                //set.Show();

                TVShow office = new TVShow("Office", 2005);
                Set<TVShow> programGuide = new Set<TVShow>();
                programGuide.Add(office);
                programGuide.Show();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("The End");
            }
        }
    }
}
