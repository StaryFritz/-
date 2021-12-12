using System;
using System.Collections.Generic;
using System.Text;

namespace lab11
{
    class Phone
    {
        string firstName;
        public string lastName;
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
        public Phone(string lastName, string firstName, string patronym, string creditCardNumber, int debet, int credit, int cityTalkingTime,
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
        public Phone(string lastName, string firstName, string creditCardNumber, int debet, int credit, int cityTalkingTime,
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
        private Phone(int num4)
        {
            Console.WriteLine("You are using private constructor");
            id = GetHashCode();
            count++;
        }
        public static Phone Create(int num4)
        {
            return new Phone(num4);
        }
        public static void SwapAndSum(ref int a, ref int b, out int sum)
        {
            int temp = a;
            a = b;
            b = temp;
            sum = a + b;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Имя: {firstName}\n Фамилия: {lastName}\n Отчество: {patronym}\n Номер кредитной карточки {creditCardNumber}\n" +
                $"Дебет: {debet}\n Кредит: {credit}\n Время городских разговоров: {cityTalkingTime}\n  междугородных: {intercityTalkingTime}");
        }
        public override int GetHashCode()
        {
            return debet * credit;
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;

            Phone phone = (Phone)obj;
            return (this.creditCardNumber == phone.creditCardNumber);
        }
        public override string ToString()
        {
            return $"{lastName} {firstName} {patronym}";
        }
        public void ShowBill()
        {
            Console.WriteLine("Расчет баланса = " + (debet - credit));
        }
    }
}
