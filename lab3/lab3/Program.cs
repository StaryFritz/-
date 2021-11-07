using System;

namespace lab3
{
    partial class Phone
    {
        string firstName;
        string lastName;
        string patronym;
        string creditCardNumber;
        int debet;
        int credit;
        public int cityTalkingTime;
        public int intercityTalkingTime;
        readonly int id;
        public static int count;
        public int Debet
        {
            get
            {
                return debet;
            }
            set
            {
                if (value > 0)
                    debet = value;
                else
                    Console.WriteLine("Значение не подходит по формату");
            }
        }
        public int Credit
        {
            get
            {
                return credit;
            }
            private set
            {
                if (credit > 0)
                    credit = Credit;
                else
                    Console.WriteLine("Значение не подходит по формату");
            }
        }
        public const int x = 25;
        public Phone()
        {
            firstName = "Михаил";
            lastName = "Лагуновский";
            patronym = "Борисович";
            creditCardNumber = "1234 5678 9876 5432";
            debet = 100;
            credit = 30;
            cityTalkingTime = 15;
            intercityTalkingTime = 0;
            id = GetHashCode();
            count++;
        }
        public Phone(string firstName, string lastName, string patronym, string creditCardNumber, int debet, int credit, int cityTalkingTime, 
            int intercityTalkingTime)
        {
            if (creditCardNumber.Length == 19)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.patronym = patronym;
                this.creditCardNumber = creditCardNumber;
                this.credit = credit;
                this.debet = debet;
                this.cityTalkingTime = cityTalkingTime;
                this.intercityTalkingTime = intercityTalkingTime;
            }
            id = GetHashCode();
            count++;

        }
        public Phone(string firstName, string lastName, string creditCardNumber, int debet, int credit, int cityTalkingTime,
            int intercityTalkingTime = 17)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.patronym = "Генадьевич";
            this.creditCardNumber = creditCardNumber;
            this.credit = credit;
            this.debet = debet;
            this.cityTalkingTime = cityTalkingTime;
            this.intercityTalkingTime = intercityTalkingTime;
            id = GetHashCode();
            count++;
        }
        static Phone()
        {
            count = 0;
            Console.WriteLine("There are " + count + " objects");
        }
        private Phone(int num4)
        {
            Console.WriteLine("You are using private constructor");
            id = GetHashCode();
            count++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Phone MyObject = new Phone();
            Phone MyObject1 = new Phone("Кулик", "Егор", "Сергеевич", "1264 9639 2959 2458", 420, 69, 20, 15);
            Phone MyObject2 = new Phone("Каплич", "Виталий", "1494 9249 2949 0421", 90, 35, 17);
            Phone PrivateConstr = Phone.Create(4);
            int a = 5, b = 6;
            Phone.SwapAndSum(ref a, ref b, out int sum);
            Console.WriteLine($"{a} + {b} = {sum}");
            Phone[] Phones = new Phone[3];
            Phones[0] = MyObject;
            Phones[1] = MyObject1;
            Phones[2] = MyObject2;
            Console.WriteLine("сведения об абонентах, у которых время внутригородских разговоров превышает заданное");
            foreach (var phone in Phones)
                if (phone.cityTalkingTime > 18)
                    phone.ShowInfo();
            Console.WriteLine("сведения об абонентах, которые пользовались междугородной связью");
            foreach (var phone in Phones)
                if (phone.intercityTalkingTime > 0)
                    Console.WriteLine(phone.ToString());
            Console.WriteLine(MyObject.Equals(MyObject));
            MyObject1.ShowBill();
            var user = new { Name = "Tom", Age = 34 };
            Console.WriteLine(user.GetType().Name);
        }
    }
}
