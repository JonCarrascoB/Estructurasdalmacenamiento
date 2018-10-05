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

            //int[] numeros = new int[10];
            //int valorn = 20;
            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    numeros[i] = valorn;
            //    valorn--;
            //    Console.WriteLine(numeros[i] + " , ");
            //}


            //Ejercicio 6:
            //Crear un array de 3 ints. Usar un for para pedir al usuario que introduzca valores a cada una de las posiciones. 
            //Usar otro for para mostrarlos en pantalla.

            //int[] valores = new int[3];

            //for (int i = 0; i < valores.Length; i++)
            //{
            //    Console.WriteLine("inserte un valor");
            //    int valor = Convert.ToInt32(Console.ReadLine());
            //    valores[i] = valor;
            //}
            //for (int j = 0; j < valores.Length; j++)
            //{
            //    Console.WriteLine(valores[j] + " ");
            //}

            //Ejercicio 7:
            //Crear un array de 3 ints. Usar un for para pedir al usuario que introduzca valores a cada una de las posiciones. 
            //Mirar los valores del array una vez tenga los 3 valores y mostrar en pantalla el más pequeño.

            //int[] num = new int[3];
            //for (int i = 0; i < num.Length; i++)
            //{
            //    Console.WriteLine("inserte un valor");
            //    num [i] = Convert.ToInt32(Console.ReadLine());

            //}
            //    Console.WriteLine(" el valor minimo es: " + num.Min());

            //  O

            //int[] num = new int[3];
            //int comparador = 10000;
            //for (int i = 0; i < num.Length; i++)
            //{
            //    Console.WriteLine("inserte un valor");
            //    num [i] = Convert.ToInt32(Console.ReadLine());
            //    if (comparador > num[i])
            //      {
            //          comparador = num[i];
            //      }
            //}
            //    Console.WriteLine("el minimo es: " + comparador);


            //Ejercicio 8:
            //Poner los nombres de los meses en un array de 12. Cuando el usuario introduce un número del 1 al 12, 
            // mostrar el nombre de ese mes en pantalla.

            //string[] meses = {"enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre"};

            //Console.WriteLine("inserte un nuemro de 1 al 12");
            //int nummes = Convert.ToInt32(Console.ReadLine()) - 1;
            //Console.WriteLine("el mes es: " + meses[nummes]);

            //  *** o ****

            //string[] meses = { "enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre" };

            //Console.WriteLine("inserte un nuemro de 1 al 12");
            //int nummes = Convert.ToInt32(Console.ReadLine());

            //while (nummes <=0 || nummes > 10)
            //{
            //    Console.WriteLine("introduce un mes correcto");
            //    nummes = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("el mes es: " + meses[nummes-1]);


            //Ejercicio 9:
            //Hacer la media de 10 valores utilizando un array.

            //int[] num = new int [10];
            //int valor = 1;
            //for (int i = 0; i < num.Length; i++)
            //{
            //    num[i] = valor;
            //    valor++;
            //    Console.WriteLine("los numeros son: " + num[i]);
            //}

            //Console.WriteLine("La suma es: " + num.Sum());
            //Console.WriteLine("la media de los numeros es: " + (num.Sum() / num.Length));

            //o

            //int[] num = new int[10];
            //int valor = 1;
            //double suma = 0;
            //for (int i = 0; i < num.Length; i++)
            //{
            //    num[i] = valor;
            //    valor++;
            //    Console.WriteLine("los numeros son: " + num[i]);
            //}
            //for (int i = 0; i < num.Length; i++)
            //{
            //    suma = suma + num[i];
            //}
            //Console.WriteLine("La suma es: " + suma);
            //Console.WriteLine("la media de los numeros es: " + (suma / num.Length));

            // *** o ****
            //int[] numero = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //double media = numero.Average();
            //Console.WriteLine("la media es: " + media);


            //Ejercicio 10:
            //Crear un array de 11 ints. Pedir al usuario que introduzca valores entre 0 y 10.
            //Cada vez que introduzca un dígito, añadir uno al valor en esa posición del array.
            //Si por ejemplo introduce un 3, sumar uno a la posición 3. Mostrar en pantalla los valores.
            //Si introduce un número mayor que 10, decir que ese número es incorrecto. 
            //Si introduce un número negativo, mostrar en pantalla el número de cada posición y el valor que contiene.
            //Por ejemplo, si introduce 7, 7, 7, 5, 6, 5, 9, 9, 10, -1 mostrar:
            //0    0
            //1    0
            //2    0
            //3    0
            //4    0
            //5    2
            //6    1
            //7    3
            //8    0
            //9    2
            //10   1

            //int[] numero = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int[] tabla = new int[11];
            //int valor;
            //do
            //{
            //    Console.WriteLine("inserte un valor");
            //    valor = Convert.ToInt32(Console.ReadLine());
            //    if (valor == 0)
            //    {
            //        tabla[0]++;
            //    }
            //    else if (valor == 1)
            //    {
            //        tabla[1]++;
            //    }
            //    else if (valor == 2)
            //    {
            //        tabla[2]++;
            //    }
            //    else if (valor == 3)
            //    {
            //        tabla[3]++;
            //    }
            //    else if (valor == 4)
            //    {
            //        tabla[4]++;
            //    }
            //    else if (valor == 5)
            //    {
            //        tabla[5]++;
            //    }
            //    else if (valor == 6)
            //    {
            //        tabla[6]++;
            //    }
            //    else if (valor == 7)
            //    {
            //        tabla[7]++;
            //    }
            //    else if (valor == 8)
            //    {
            //        tabla[8]++;
            //    }
            //    else if (valor == 9)
            //    {
            //        tabla[9]++;
            //    }
            //    else if (valor == 10)
            //    {
            //        tabla[10]++;
            //    }
            //    else if (valor >= 10)
            //    {
            //        Console.WriteLine("numero incorrecto");
            //    }

            //} while (valor >= 0);

            //if (valor < -1)
            //{
            //    for (int i = 0; i < numero.Length; i++)
            //    {
            //        Console.WriteLine(numero[i] + "\t" + tabla[i]);
            //    }
            //}


            //Ejercicio 11:
            //Crear un array de 10 valores. Poner el valor 1 en cada una de la posición. 
            //Pedir al usuario que introduzca un número entre 0 y 9. 
            //Cada vez que introduzca un valor entre 0 y 9, mostrar el valor de esa posición del array, 
            //y modificarlo multiplicando por 2.


            //int[] tecleo = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            //int valor;

            //do
            //{
            //    Console.WriteLine("Introduzca un numero entre 0 y 9");
            //    valor = Convert.ToInt32(Console.ReadLine());
            //    if (valor >= 0 && valor <= 9)
            //    {
            //        tecleo[valor] = tecleo[valor] * 2;
            //    }
            //    else if (valor > 9)
            //    {
            //        Console.WriteLine("el valor es incorrecto");
            //    }
            //} while (valor > -1);

            //if (valor < -1)
            //{
            //    for (int i = 0; i < tecleo.Length; i++)
            //    {
            //        Console.WriteLine("el resultado es: " + "\t" + tecleo[i]);
            //    }
            //}


            //Programa que lee las edades de 20 alumnos (validado entre 18 y 35), las almacena en un array 
            //y calcula y escribe su media (para probar, se pueden generar aleatoriamente entre 18 y 35).
            //Random edad = new Random();
            //int años = edad.Next(18, 36);
            //int[] alumnos = new int[20];
            ////double sumaEdad = 0;
            //for (int i = 0; i < alumnos.Length; i++)
            //{
            //    alumnos[i] = edad.Next(18, 36);
            //    Console.WriteLine("la edad del alumno " + (i + 1) + " es: " + edad.Next(18,36));
            //}
            //Console.WriteLine("la media de las edades de los alumnos es: " + alumnos.Average());

            //**** o ****
            //for (int i = 0; i <alumnos.Length; i++)
            //{
            //    sumaEdad = sumaEdad + alumnos[i];
            //}

            //Console.WriteLine("la media de las edades de los alumnos es: " + (sumaEdad/alumnos.Length));

            //*****************************************************
            //Ejercicios PRO:

            //Ejercicio 1:
            //Cargar una tabla de 20 componentes enteros y calcular la suma de los componentes de posición par 
            //y el producto de los componentes de posición impar. Los valores se generarán aleatoriamente entre 1 y 100.



          Console.ReadLine();
           


            
        }
    }
}
