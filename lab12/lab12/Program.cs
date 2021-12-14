using System;
using System.Reflection;

namespace lab12
{
    class SomeClass
    {
        public int field;
        public SomeClass() { field = 0; }
        public SomeClass(int a) { field = a; }

        public int Property { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Reflector.AssemblyInfo("lab12.Reflector");
            Reflector.publicConstructors("lab12.SomeClass");
            Reflector.classMethods("System.Int32");
            Reflector.FieldsAndProperties("lab12.SomeClass");
            Reflector.classInterfaces("System.Array");
            Reflector.findMethod("System.Int32", "System.Int32");
            Reflector.Invoke("lab12.mul", "multiply");
            var mult = Reflector.Create("lab12.mul");
            Console.WriteLine(mult is mul);
        }
    }
}
