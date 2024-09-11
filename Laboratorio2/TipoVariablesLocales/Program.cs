// Creando nueva instancia
using Laboratorio21;

MyClass object1 = new MyClass();
object1.Nombre = "Yeison";
object1.Edad = 28;

// Asignando un variable a otra
MyClass object2 = object1;

// Este cambio en la propiedad afecta tanto a object1 como object2.
object2.Nombre = "Jose";

// Al imprimir en consola vemos que ambas referencias imprimen el mismo valor Jose.
Console.WriteLine(object2.Nombre);
Console.WriteLine(object1.Nombre);