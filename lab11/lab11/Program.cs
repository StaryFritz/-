using System;
using System.Collections.Generic;
using System.Linq;

namespace lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            string[] months = new string[] { "January", "February", "March", "April", "May", "June", "July", "August",
            "September", "October", "November", "December"};
            int n = 4;
            IEnumerable<string> monthsByLength =
                from month in months
                where month.Length == n
                select month;
            foreach (var month in monthsByLength)
                Console.WriteLine(month);
            Console.WriteLine();
            IEnumerable<string> SummerAndWinterMonths =
                from month in months
                where Array.IndexOf(months, month) < 2 ||
                Array.IndexOf(months, month) > 4 && Array.IndexOf(months, month) < 8 ||
                Array.IndexOf(months, month) == 11
                select month;
            foreach (var month in SummerAndWinterMonths)
                Console.WriteLine(month);
            Console.WriteLine();
            List<string> monthInAlphabet =
                (from month in months
                 orderby month
                 select month
                 ).ToList();
            foreach (var month in monthInAlphabet)
                Console.WriteLine(month);
            Console.WriteLine();
            int monthCounter =
                (from month in months
                 where month.Contains("u") && month.Length >= 4
                 select month
                ).Count();
            Console.WriteLine(monthCounter);
            Console.WriteLine();


            // 2

            List<Phone> phoneList = new List<Phone>();
            phoneList.Add(new Phone());
            phoneList.Add(new Phone("Кулик", "Егор", "Сергеевич", "1264 9639 2959 2458", 420, 69, 20, 0));
            phoneList.Add(new Phone("Каплич", "Виталий", "1494 9249 2949 0421", 90, 35, 17));
            phoneList.Add(new Phone("Сергеев", "Егор", "Викторович", "8296 2095 5362 8096", 58, 14, 45, 31));
            phoneList.Add(new Phone("Артем", "Елизавета", "Владимировна", "7602 1460 9327 4731", 27, 13, 86, 0));
            phoneList.Add(new Phone("Яскович", "Марк", "Эдуардович", "2575 2789 2789 4218", 27, 9, 57, 32));
            phoneList.Add(new Phone("Дикун", "Игорь", "05853 6035 3562 6996", 58, 14, 45, 0));
            phoneList.Add(new Phone("Сапегина", "Екатерина", "Игоревна", "5676 2455 8274 2496", 97, 61, 46, 0));
            phoneList.Add(new Phone("Гусев", "Роман", "Николаевич", "2365 2565 5472 8846", 75, 65, 64, 0));
            phoneList.Add(new Phone("Булавский", "Кирилл", "Георгиевич", "4052 9548 2712 8724", 54, 34, 43, 31));
            foreach (var user in phoneList.Where(phone => phone.cityTalkingTime > 50))
                Console.WriteLine(user);
            Console.WriteLine();
            foreach (var user in phoneList.Where(phone => phone.intercityTalkingTime > 0))
                Console.WriteLine(user);
            Console.WriteLine();
            IEnumerable<Phone> usersInAlphabet =
                from phone in phoneList
                orderby phone.lastName
                select phone;
            foreach (var user in usersInAlphabet)
                Console.WriteLine(user);
            Console.WriteLine();

            // 4

            var newQuery =
                from phone in phoneList
                group phone by phone.intercityTalkingTime == 0;
            foreach (var phoneGroup in newQuery)
            {
                Console.WriteLine(phoneGroup.Key ? "Междугородная связь подключена:" : "Междугородная связь не подключена:");
                foreach (var phone in phoneGroup)
                    Console.WriteLine(phone);
            }
            Console.WriteLine();

            // 5

            Operator a1 = new Operator { Name = "A1", User = phoneList[0] };
            Operator mts = new Operator { Name = "МТС", User = phoneList[3] };
            Operator life = new Operator { Name = "Life", User = phoneList[7] };
            Operator tMobile = new Operator { Name = "T-Mobile", User = phoneList[9] };

            List<Operator> operators = new List<Operator> { a1, mts, life, tMobile };

            var myQuery =
                from company in operators
                join phone in phoneList on company.User equals phone
                select new { operatorName = company.Name, user = phone };
            foreach (var operatorAndUser in myQuery)
                Console.WriteLine($"{operatorAndUser.operatorName} is used by {operatorAndUser.user}");
        }
    }
}
