using System;

namespace lab5
{
    interface IFuncs
    {
        void showInfo();
    }
    public abstract class NameInfo
    {
        public abstract void showInfo();
    }
    class TVShow : NameInfo, IFuncs
    {
        public string name;
        void IFuncs.showInfo()
        {
            Console.WriteLine("This is interface ");
        }
        public override void showInfo()
        {
            Console.WriteLine("This is abstract class ");
        }
    }
    class Movie : TVShow
    {
        public Movie()
        {
            name = "Movie";
        }
        public Movie(string name)
        {
            base.name = name;
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
        public News()
        {
            name = "News";
        }
        public News(string name)
        {
            base.name = name;
        }
    }
    class Fiction : Movie
    {
        public Fiction()
        {
            name = "FictionMovie";
            genre = "Fiction";
        }
        public Fiction(string name) : base(name)
        {
            genre = "Fiction";
        }
        public override string ToString()
        {
            return $"It's a {this.GetType()} name - {this.name}";
        }
    }
    class Cartoon : Movie
    {
        public Cartoon()
        {
            name = "CartoonMovie";
            genre = "Cartoon";
        }
        public Cartoon(string name) : base(name)
        {
            genre = "Cartoon";
        }
        public override string ToString()
        {
            return $"It's a {this.GetType()} name - {this.name}";
        }
    }
    class Commercial : TVShow
    {
        public Commercial()
        {
            name = "Commercial";
        }
        public Commercial(string name)
        {
            base.name = name;
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
            TVShow obj = new TVShow();
            obj.showInfo();
            ((IFuncs)obj).showInfo();
            Fiction fictionMovie = new Fiction();
            if (fictionMovie is Fiction)
                Console.WriteLine("it's a fiction");
            else
                Console.WriteLine("it's not a fiction");
            Movie ad = fictionMovie as Movie;
            if (ad == null)
                Console.WriteLine("Преобразование прошло неудачно");
            else
                Console.WriteLine(ad.name);
            var fiction = new Fiction("Shawshank Redemption");
            var cartoon = new Cartoon("Avatar - the last airbender");
            var array = new Movie[2];
            array[0] = fiction;
            array[1] = cartoon;
            Printer printer = new Printer();
            foreach (var arrayItem in array)
                printer.IAmPrinting(arrayItem);
        }
    }
}
