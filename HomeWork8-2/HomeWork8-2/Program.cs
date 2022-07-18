using System;
using System.Reflection;
class Program
{
    static PropertyInfo GetPropertyInfo(object obj, string str)
    {
        return obj.GetType().GetProperty(str);
    }


    static void Main(string[] args)
    {

    DateTime dT1 = new DateTime();
        //dateTime.DayOfWeek
        //Console.WriteLine(GetPropertyInfo(dT1, "DayOfWeek").CanRead);
        //Console.WriteLine(GetPropertyInfo(dT1, "DayOfWeek").CanWrite);
        Console.WriteLine(GetPropertyInfo(dT1, "DayOfWeek").GetValue(dT1, null));
        Console.WriteLine(GetPropertyInfo(dT1, "DayOfWeek").GetValue(dT1, null));

        Type type = typeof(DateTime);
        foreach (var prop in type.GetProperties())
            Console.WriteLine(prop.Name);





        Console.ReadKey();
    }
}