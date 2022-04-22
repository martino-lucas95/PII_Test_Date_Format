# PII_Test_Date_Format

Ejercicio individual.

Entrega el link al repositorio donde está tu código. Recuerda hacerlo público o darle acceso a los profesores.

1. Crea tests para probar tu programa que cambia el formato de una fecha dada (ejercicio previo de Python a C#). 

2. Utiliza TDD para agregar un nuevo método de formateo de fecha que retorne la fecha en otro formato diferente al anterior (por ejemplo, DD-MM-YYYY).



Dejamos aquí una solución al ejercicio de DateFormat

Escribir una función que recibe una cadena de caracteres como parámetro con una fecha de la forma “dd/mm/aaaa” y devuelve la fecha en formato “aaaa­‐mm­‐dd”.
 Ej.: 10/11/1977 -> 1977­‐11­‐10
 
 La función para cambiar el forma de la fecha está implementada en el método de clase ChangeFormat de la clase Program. Ese método se invoca desde el método de clase Main de la clase Program que es el punto de entrada del programa.


namespace DateFormat
{
    public class Program
    {
        public static String ChangeFormat(String year)
        {
            return year.Substring(6) + "-" + year.Substring(3, 2) + "-" + year.Substring(0, 2);
        }

        public static void Main(string[] args)
        {
            string testDate = "10/11/1977";
            Console.WriteLine("{0} se convierte a: {1} ", testDate, ChangeFormat(testDate));
        }
    }
}
