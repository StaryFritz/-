using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab8
{
    public class Set<T> : IFuncs<T> where T : IComparable
    {
        List<T> list;
        public bool error = false;
        public class Owner
        {
            int Id;
            public string name;
            string organisationName;
            public Owner(int Id, string name, string organisationName)
            {
                this.Id = Id;
                this.name = name;
                this.organisationName = organisationName;
            }
        }
        public class Date
        {
            public string CreationDate { get; private set; }
            public Date()
            {
                CreationDate = DateTime.Now.ToString();
            }
        }
        public Set()
        {
            list = new List<T>();
        }
        public void Add(T item)
        {
            if (list.Contains(item))
                throw new Exception("Элементы должны быть уникальными");
            list.Add(item);
        }
        public void Remove(T item)
        {
            if (!list.Contains(item))
                throw new Exception("Элемент не найден");
            list.Remove(item);
        }
        public void Show()
        {
            foreach (var item in list)
                Console.WriteLine(item);
        }
    }
}
