using System;
using System.Collections.Generic;
using System.Text;

namespace lab3
{
    partial class Phone
    {
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
            return debet*credit;
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
