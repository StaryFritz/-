using System;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.ObjectModel;


namespace lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCollection = new MyCollection<Furniture>();
            var enotherCollection = myCollection;
            myCollection.Add(new Furniture("Кровать"));
            myCollection.Add(new Furniture("Стол"));
            myCollection.Add(new Furniture("Комод"));
            myCollection.Show();
            Furniture sofa = new Furniture("Софа");
            myCollection.Insert(1, sofa);
            myCollection.Show();
            Console.WriteLine(myCollection.Contains(sofa));
            myCollection.Remove(sofa);
            myCollection.RemoveAt(0);
            Console.WriteLine(myCollection[0]);
            var array = new Furniture[4];
            myCollection.CopyTo(array, 2);
            foreach (var i in array) Console.Write($"{i} ");
            Console.WriteLine();

            myCollection.Show();
            myCollection.Clear();
            myCollection.Show();
            Console.WriteLine(myCollection.Equals(enotherCollection));

            // 2

            ArrayList arrayList = new ArrayList();
            Queue queue = new Queue();
            arrayList.Add(69);
            arrayList.Add("NICE");
            arrayList.Add(420);
            foreach (var item in arrayList)
                Console.WriteLine(item);
            arrayList.Remove("NICE");
            foreach (var item in arrayList)
                queue.Enqueue(item);
            foreach (var item in queue)
                Console.WriteLine(item);
            Console.WriteLine(queue.Contains(69));

            // 3

            var newCollection = new ObservableCollection<Furniture>();
            newCollection.CollectionChanged += SayChange;

            newCollection.Add(new Furniture("диван"));
            newCollection.Add(new Furniture("стул"));
            newCollection.Add(new Furniture("стеллаж"));

            newCollection.RemoveAt(2);
        }
        private static void SayChange(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
                Console.WriteLine("|Add comlete|");
            else if (e.Action == NotifyCollectionChangedAction.Remove) Console.WriteLine("|Remove complete|");
        }
    }
}
