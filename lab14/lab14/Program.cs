using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;
using System.Xml;
using System.Xml.Linq;

namespace lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            var tvShows = new List<TVShow>();
            string[] names = new string[] { "The Sopranos", "The Office", "The Simpsons", "The Witcher", "Friends" };
            for (int i = 0; i < names.Length; i++)
                tvShows.Add(new TVShow(names[i]));
            var binFormatter = new BinaryFormatter();
            using (var file = new FileStream("tvShows.bin", FileMode.Create))
            {
                binFormatter.Serialize(file, tvShows);
            }
            using (var file = new FileStream("tvShows.bin", FileMode.Open))
            {
                var newTVShows = binFormatter.Deserialize(file) as List<TVShow>;
                if (newTVShows != null)
                    foreach (var item in newTVShows)
                        Console.WriteLine(item);
            }
            Console.ReadLine();
            var soapFormatter = new SoapFormatter();
            using (var file = new FileStream("tvShows.soap", FileMode.Create))
            {
                soapFormatter.Serialize(file, tvShows);
            }
            using (var file = new FileStream("tvShows.soap", FileMode.Open))
            {
                var newTVShows = soapFormatter.Deserialize(file) as List<TVShow>;
                if (newTVShows != null)
                    foreach (var item in newTVShows)
                        Console.WriteLine(item);
            }
            Console.ReadLine();
            var xmlFormatter = new XmlSerializer(typeof(List<TVShow>));
            using (var file = new FileStream("tvShows.xml", FileMode.Create))
            {
                xmlFormatter.Serialize(file, tvShows);
            }
            using (var file = new FileStream("tvShows.xml", FileMode.Open))
            {
                var newTVShows = xmlFormatter.Deserialize(file) as List<TVShow>;
                if (newTVShows != null)
                    foreach (var item in newTVShows)
                        Console.WriteLine(item);
            }
            Console.ReadLine();
            var jsonFormatter = new DataContractJsonSerializer(typeof(List<TVShow>));
            using (var file = new FileStream("tvShows.json", FileMode.Create))
            {
                jsonFormatter.WriteObject(file, tvShows);
            }
            using (var file = new FileStream("tvShows.json", FileMode.Open))
            {
                var newTVShows = jsonFormatter.ReadObject(file) as List<TVShow>;
                if (newTVShows != null)
                    foreach (var item in newTVShows)
                        Console.WriteLine(item);
            }

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(@"C:\Users\Михаил Лагуновский\Desktop\ООТП\lab14\lab14\bin\Debug\net5.0\tvShows.xml");
            var xRoot = xmlDocument.DocumentElement;

            var selectNodes = xRoot.SelectNodes("*");
            foreach (object node in selectNodes) Console.WriteLine((node as XmlNode).Name);

            Console.WriteLine();
            var nameNodes = xRoot.SelectNodes("TVShow");
            foreach (XmlNode n in nameNodes)
                Console.WriteLine(n.SelectSingleNode("Name").InnerText);
        }
    }
}
