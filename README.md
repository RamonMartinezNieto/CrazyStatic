
# CrazyStatic 

## Descripción del problema

SomeSingleton representa una librería que no podemos modificar.

Para poder añadir datos a una colección de string a la que tenemos acceso pero que no podemos añadir datos por el motivo que sea, se decide hacer un método de extensión y así podemos ampliar su funcionalidad.

Se presentan dos vías en las que he visto esta práctica alguna vez, la primera cogemos el método de extensión está sobre la colección, esto es una práctica extremadamente mala por que estamos haciendo que todas las colecciones del tipo List<string> tengan acceso a dicha funcionalidad, pero por desgracía hay gente que abusa de programación funcional y hace cosas raras de estas. 

La segunda opción el método estático está creado sobre el singleton, lo que límita el acceso a dicha clase concreta, es menos negativo pero se sigue modificando una colección de un singleton a través de un método de extensión que es estático y que obliga a que la clase sea estática.

## Duda

¿Cómo podemos arreglar este legacy code con las técnicas de costura que hemos visto?

Esta duda surgió cuando vimos las costuras Statics & Globals.

Es un ejemplo extremo que podría meter alguien con poca experiencia facilmente ya que "es cómodo" (lo he visto en otras empresas)
