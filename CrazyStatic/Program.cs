using System;

namespace CrazyStatic;
internal class Program
{
    /*
     * SomeSingleton representa una librería que no podemos modificar.
     * Para poder añadir datos a una colección de string a la que tenemos acceso
     * se decide hacer un método de extensión y así podemos ampliar su funcionalidad.
     *
     * Es un caso extremo, por ejemplo el método de extensión podría estar directamente
     * creado sobe SomeSingleton en lugar de List<string> para evitar que se tuviera acceso
     * directamente al método desde cualquier List<String> que es el segundo caso
     * que ya está "un poco mejor".
     *
     * El problema es que hemos extendido la librería SomeSingleton en un método Static
     * y ese Static utiliza el Singleton directamente.
     *
     * ¿Cómo podemos arreglar este legacy code con las técnicas de costura que hemos visto?
     * Esta duda surgió cuando vimos las costuras Statics & Globals.
     *
     * Aún que el primero sea un caso extremos, lo he visto demasiado (en otras empresas)
     */
    static void Main(string[] args)
    {
        var someSingleton = SomeSingleton.Instance();

        someSingleton.SomeData.AddMessageToSomeSingletonData("this is shit");
        someSingleton.SomeData.AddMessageToSomeSingletonData("too bad way to do this");

        someSingleton.AddMessageToSomeSingle("este duele un poco menos");

        Console.WriteLine(someSingleton.ToString());
    }
}
