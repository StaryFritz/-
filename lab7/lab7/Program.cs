using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace lab7
{
    interface IFuncs
    {
        void showInfo();
    }
    public abstract class NameInfo
    {
        public virtual void showInfo()
        {
            Console.WriteLine("Abstract method");
        }
    }
    class TVShow : NameInfo, IFuncs
    {
        public string name;
        public int year;
        public int length;
        public int count = 0;
        public TVShow(string name, int year)
        {
            this.name = name;
            if (year > 2021)
                throw new YearExeption("year is too large", "TVShow");
            this.year = year;
        }
        public List<Commercial> ads = new List<Commercial>();
        void IFuncs.showInfo()
        {
            Console.WriteLine("This is interface " + name);
        }
        public override void showInfo()
        {
            Console.WriteLine("This is abstract class " + name);
        }
    }
    class Movie : TVShow
    {
        public Movie(string name, int year, int length) : base(name, year)
        {
            if (length < 90 || length > 120)
                throw new LengthException("length is incorrect", "Movie");
            base.length = length;
        }
        public string genre;
        public override string ToString()
        {
            return $"It's a {this.GetType()} name - {this.name}";
        }
        public override bool Equals(object obj)
        {
            Movie someMovie = (Movie)obj;
            return (name == someMovie.name && genre == someMovie.genre);
        }
        public override int GetHashCode()
        {
            return name.GetHashCode();
        }
        public override void showInfo()
        {
            Console.WriteLine(name + " " + genre);
        }
    }
    class News : TVShow
    {
        public News(string name, int year, int length) : base(name, year)
        {
            if (length != 30)
                throw new LengthException("length is incorrect", "News");
            base.length = length;
        }
    }
    partial class Fiction : Movie
    {
        public Fiction(string name, int year, int length, string genre) : base(name, year, length)
        {
            if (genre != "Fiction")
                throw new GenreException("genre is incorrect", "Fiction");
            base.genre = genre;
        }
        public override string ToString()
        {
            return $"It's a {this.GetType()} name - {this.name}";
        }
    }
    class Cartoon : Movie
    {
        public Cartoon(string name, int year, int length, string genre) : base(name, year, length)
        {
            if (genre != "Cartoon")
                throw new GenreException("genre is incorrect", "Cartoon");
            base.genre = genre;
        }
        public override string ToString()
        {
            return $"It's a {this.GetType()} name - {this.name}";
        }
    }
    class Commercial
    {
        public string name;
        public int length;
        public Commercial()
        {
            name = "Commercial";
            length = 3;
        }
        public Commercial(string name, int length)
        {
            this.name = name;
            this.length = length;
        }
        public override string ToString()
        {
            return $"It's a {this.GetType()} name - {this.name}";
        }
    }
    sealed class Director : NameInfo
    {
        public string firstName;
        public string lastName;
        public Director()
        {
            firstName = "Quentin";
            lastName = "Tarantino";
        }
        public Director(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public override void showInfo()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
        public override string ToString()
        {
            return $"It's a {this.GetType()} name - {this.firstName} {this.lastName}";
        }
    }
    public class Printer
    {
        public virtual void IAmPrinting(NameInfo item)
        {
            Console.WriteLine(item.ToString());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TVShow tvShow = new TVShow("The Office", 2022);
            }
            catch (YearExeption ex)
            {
                Console.WriteLine($"{ex.Message} in {ex.Class}" );
            }
            try
            {
                Movie movie = new Movie("Godfather", 1972, 177);
            }
            catch (LengthException ex)
            {
                Console.WriteLine($"{ex.Message} in {ex.Class}");
            }
            try
            {
                Fiction fiction = new Fiction("Dune", 2021, 100, "Documentary");
            }
            catch (GenreException ex)
            {
                Console.WriteLine($"{ex.Message} in {ex.Class}");
            }
            try
            {
                int x = 5, y = 0;
                int z = x / y;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                int[] nums = new int[4];
                nums[5] = 5;
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("The End");
                Debug.Assert(false);
                int index = -40;
                Debug.Assert(index > -1, "incorrect data");
            }
        }
    }
}
