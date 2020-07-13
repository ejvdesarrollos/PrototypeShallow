# PrototypeShallow
Patrón creacional

El objetivo es clonar un objeto superficialmente, es decir, sus atributos. La clase implementa ICloneable, con un método de interfaz. 
Existe en C# un método específico para generar la clonación. Las variables apuntan a objetos. Con este padron se hace una copia del objeto.
Shallow: Solo copia el objeto principal. Si un atributo es otro Objeto, ambos (original y clon) apuntan al mismo.

Deep: Se crean copias del objeto principal y de todos los dependientes que contenga el objeto principal.
