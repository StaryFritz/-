using System;

namespace Kontrolka
{
    interface ICheck
    {
        public bool Check();
    }
    public class Card : ICheck
    {
        int month, year = 2021;
        public int number { get; set; }
        public int Month
        {
            get
            {
                return month;
            }
            set
            {
                if (value > 0 && value <= 12)
                    month = value;
            }
        }
        public int Year
        {
            get
            {
                return year;
            }
        }
        public int balance { get; set; }
        public static Card operator+(Card card, int num)
        {
            card.balance += num;
            CardWithHistory.addPositiveOperation(num);
            return card;
        }
        public static Card operator -(Card card, int num)
        {
            card.balance -= num;
            CardWithHistory.addNegativeOperation(num);
            return card;
        }
        public bool Check()
        {
            return balance > 0;
        }
    }
    public class CardWithHistory : Card
    {
        static public string[] cardHistory = new string[10];
        static int i = 0;
        static public void addPositiveOperation(int num)
        {
            cardHistory[i] = "Было добавлено " + num;
            i++;
        }
        static public void addNegativeOperation(int num)
        {
            cardHistory[i] = "Было снято " + num;
            i++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ushort max = ushort.MaxValue;
            Console.WriteLine("Ushort max value = " + max);
            string[] weekDays = new string[] { "monday", "tuesday", "wednesday", "thursday", "friday", "saturday", "sunday" };
            Card card = new Card() {number = 123, balance = 10, Month = 11};
            card += 10;
            Console.WriteLine(card.balance);
            card -= 5;
            Console.WriteLine(card.balance);
            if (card.Check())
                Console.WriteLine("Баланс положителен");
            else
                Console.WriteLine("Баланс отрицателен");
            foreach (var item in CardWithHistory.cardHistory)
                Console.WriteLine(item);
        }
    }
}
