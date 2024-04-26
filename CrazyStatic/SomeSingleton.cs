using System;
using System.Collections.Generic;

namespace CrazyStatic;

public class SomeSingleton
{
    private static SomeSingleton _instance;

    public List<string> SomeData { get; }

    private SomeSingleton()
    {
        SomeData = new();
    }

    public static SomeSingleton Instance() =>
        _instance ??= new SomeSingleton();

    public override string ToString()
    {
        return String.Join(", ", SomeData.ToArray());
    }
}
