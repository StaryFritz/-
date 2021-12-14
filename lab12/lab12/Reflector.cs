using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;
using System.Linq;

namespace lab12
{
    static class Reflector
    {
        public static void AssemblyInfo(string typeName)
        {
            Type myType = Type.GetType(typeName);
            StreamWriter sw = new StreamWriter("info.txt");
            sw.WriteLine($"Current class {myType} is situated in {myType.Assembly}");
            sw.Close();
        }
        public static void publicConstructors(string typeName)
        {
            Type myType = Type.GetType(typeName);
            ConstructorInfo[] myConstructorInfo = myType.GetConstructors();
            StreamWriter sw = new StreamWriter("info.txt", true);
            sw.WriteLine("Class Constructors:");
            foreach (var item in myConstructorInfo)
                sw.WriteLine(item);
            sw.Close();
        }
        public static void classMethods(string typeName)
        {
            Type myType = Type.GetType(typeName);
            MethodInfo[] myMethodInfo = myType.GetMethods();
            StreamWriter sw = new StreamWriter("info.txt", true);
            sw.WriteLine("Class Methods:");
            foreach (var item in myMethodInfo)
            {
                sw.WriteLine(item);
            }
            sw.Close();
        }
        public static void FieldsAndProperties(string typeName)
        {
            Type myType = Type.GetType(typeName);
            FieldInfo[] myFieldInfo = myType.GetFields();
            PropertyInfo[] myProperyInfo = myType.GetProperties();
            StreamWriter sw = new StreamWriter("info.txt", true);
            sw.WriteLine("Class Fields:");
            foreach (var item in myFieldInfo)
            {
                sw.WriteLine(item);
            }
            sw.WriteLine("Class Properties:");
            foreach (var item in myProperyInfo)
            {
                sw.WriteLine(item);
            }
            sw.Close();
        }
        public static void classInterfaces(string typeName)
        {
            Type myType = Type.GetType(typeName);
            Type[] myInterfaceInfo = myType.GetInterfaces();
            StreamWriter sw = new StreamWriter("info.txt", true);
            sw.WriteLine("Class Interfaces");
            foreach (var item in myInterfaceInfo)
            {
                sw.WriteLine(item);
            }
            sw.Close();
        }
        public static void findMethod(string typeName, string paramType)
        {
            StreamWriter sw = new StreamWriter("info.txt", true);
            sw.WriteLine($"{typeName} methods with {paramType} parameter");
            Type myType = Type.GetType(typeName);
            var methodsWithUserParametr = new List<string>();
            MethodInfo[] myMethodInfo = myType.GetMethods();
            foreach (var item in myMethodInfo)
            {
                var itemParameters = item.GetParameters();
                if (itemParameters.Any(param => param.ParameterType == Type.GetType(paramType)))
                    methodsWithUserParametr.Add(item.ToString());
            }
            foreach (var item in methodsWithUserParametr)
                sw.WriteLine(item);
            sw.Close();
        }
        public static void Invoke(string typeName, string methodName)
        {
            StreamReader sr = new StreamReader("invoke.txt");
            Type myType = Type.GetType(typeName);
            MethodInfo methodInfo = myType.GetMethod(methodName);
            object obj = Activator.CreateInstance(myType);
            var result = methodInfo.Invoke(obj, new object[] {int.Parse(sr.ReadLine()), int.Parse(sr.ReadLine())});
            Console.WriteLine($"Invoke: {result}");
            sr.Close();
        }
        public static object Create(string typeName)
        {
            return Activator.CreateInstance(Type.GetType(typeName));
        }
    }
}
