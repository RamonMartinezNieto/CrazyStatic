using System.Collections.Generic;

namespace CrazyStatic;
internal static class Extensions
{

    public static SomeSingleton AddMessageToSomeSingletonData(
        this List<string> someData,
        string message)
    {
        var someSingleton = SomeSingleton.Instance();

        lock (someSingleton)
        {
            someData.Add(message);
        }

        return someSingleton;
    }
    public static SomeSingleton AddMessageToSomeSingle(
        this SomeSingleton someSingleton,
        string message)
    {

        lock (someSingleton)
        {
            someSingleton.SomeData.Add(message);
        }

        return someSingleton;
    }

}
