using System;

namespace CrazyStatic;
internal class Program
{
    static void Main(string[] args)
    {
        var someSingleton = SomeSingleton.Instance();

        someSingleton.SomeData.AddMessageToSomeSingletonData("this is shit");
        someSingleton.SomeData.AddMessageToSomeSingletonData("too bad way to do this");

        someSingleton.AddMessageToSomeSingle("este duele un poco menos");

        Console.WriteLine(someSingleton.ToString());
    }
}
