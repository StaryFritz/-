using System;

namespace lab7
{
    public class YearExeption : Exception
    {
        public string Class { get; }
        public YearExeption(string message, string Class) : base(message)
        {
            this.Class = Class;
        }
    }
    public class LengthException : YearExeption
    {
        public LengthException(string message, string Class) : base(message, Class)
        {

        }
    }
    public class GenreException : LengthException
    {
        public GenreException(string message, string Class) : base(message, Class)
        {

        }
    }
}