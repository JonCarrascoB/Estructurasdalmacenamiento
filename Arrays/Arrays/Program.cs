using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1:
            //Escribir un programa que te escriba un nombre al revés.
            //string nombre = "jon";
            //char[] arrayNombre = nombre.ToCharArray(); //esta función nos separa el nombre jon por letras en sus posiciones
            //Array.Reverse(arrayNombre);
            //Console.WriteLine(arrayNombre);

            //for (int i = 0; i < arrayNombre.Length; i++) //se hace el bucle porque los arrays deben recorrerse enteros (esto es en JAVA)
            //{
            //    Console.Write(arrayNombre[i].ToString()); //es un write a secas para que las letras salgan seguidas, con writeline
            //                                              //saldrían una letra en cada linea
            //}

            //Ejercicio 2:
            //Escribe un programa que al meter tres números por teclado saque el promedio (usa el método correspondiente).


            //Ejercicio 3:
            //Crear un array de 10 ints. Asignar un valor a cada uno de las 10 posiciones. Mostrar los 10 valores en pantalla.

            //int[] valor = { 11, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //for (int i = 0; i < valor.Length; i++)
            //{
            //    Console.WriteLine(valor[i]);
            //}


            //Ejercicio 4:
            //Crear un array de 3 strings. Pedir al usuario 3 veces que escriba un string. 
            //Guardar cada uno de esos strings en la posición 0 , 1 y 2. Mostrar en pantalla en el orden: 
            //primero posición 1, después posición 2 y por último posicion 0.

            //string[] nombres = new string[3];
            //Console.WriteLine("inserte un nombre");
            //nombres[0] = Console.ReadLine();
            //Console.WriteLine("inserte un nombre");
            //nombres[1] = Console.ReadLine();
            //Console.WriteLine("inserte un nombre");
            //nombres[2] = Console.ReadLine();
            //Console.WriteLine(nombres[1]);
            //Console.WriteLine(nombres[2]);
            //Console.WriteLine(nombres[0]);


            //Ejercicio 5:
            //Crear un array de 10 ints. Usar un for para asignar los valores de 20 a 11 a las 10 posiciones(en orden descendente).
            //Usar un for para mostrar los 10 valores en pantalla.

            int[] numeros = new int[10];
            for (int i = 20; i > numeros.Length; i--)
            {
                int [] cifras = {i};
            }
            for (int j = 0; j < numeros.Length; j++)
            {
                Console.WriteLine(numeros[j]);
            }


         Console.ReadLine();
           


            
        }
    }
}
