using System;
using System.Collections.Generic;

namespace lab6
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
        public TVShow(string name)
        {
            this.name = name;
            year = 2021;
            length = 20;
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
        public Movie(string name, int year) : base(name)
        {
            this.year = year;
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
        public News(string name) : base(name)
        {}
    }
    partial class Fiction : Movie
    {
        public Fiction(string name, int year) : base(name, year)
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
        public Cartoon(string name, int year) : base(name, year)
        {
            genre = "Cartoon";
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
            Controller controller = new Controller();
            ProgramGuide programGuide = new ProgramGuide();
            TVShow Vesti = new TVShow("Вести");
            TVShow SledstvieVeli = new TVShow("Следствие вели");
            Commercial Colgate = new Commercial();
            Commercial Pivasik = new Commercial();
            Commercial Evroopt = new Commercial();
            Vesti.ads.Add(Colgate);
            Vesti.ads.Add(Pivasik);
            Vesti.ads.Add(Evroopt);
            SledstvieVeli.ads.Add(Pivasik);
            SledstvieVeli.ads.Add(Colgate);
            Console.WriteLine(controller.AdsCounter(Vesti));
            Console.WriteLine(Controller.timeCounter(Vesti));
            programGuide.Add(Vesti);
            programGuide.Add(SledstvieVeli);
            programGuide.Print();
            Movie Avengers = new Movie("Avangers", 2010);
            Movie IronMan = new Movie("IronMan", 2010);
            programGuide.Add(Avengers);
            programGuide.Add(IronMan);
            foreach (var item in controller.findMovie(programGuide, 2010))
                Console.WriteLine(item.name);
            controller.readFile(programGuide);
            programGuide.Print();
        }
    }
}
