using System;

namespace EJERCICIO5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar cuatro números y 
            //luego mostrar por pantalla cuáles son mayores a 100.

            //Paso 0: Crear Variables
            int N1, N2, N3, N4;

            //Paso 1: Pedir Numeros
            Console.WriteLine("Ingrese 1er numero: ");
            N1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese 2do numero: ");
            N2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese 3er numero: ");
            N3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese 4to numero: ");
            N4 = int.Parse(Console.ReadLine());

            //Paso 2: Condiciones
            if(N1 > 100)
                Console.WriteLine("Primer Numero: " + N1);
            if(N2 > 100)
                Console.WriteLine("Segundo Numero: " + N2);
            if(N3 > 100)
                Console.WriteLine("Terceri Numero: " + N3);
            if(N4 > 100)
                Console.WriteLine("Cuarto Numero: " + N4);

            Console.WriteLine("FIN DEL PROGRAMA");


        }
    }
}
