using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Escribe un programa que te calcule el total de palabras que hay en un string

            char letter = ' ';
            string text = "a";

            // cause we count spaces
            int words = 1;

            Console.WriteLine("Introduce some text...");
            text = Console.ReadLine();

            for (int i = 0; i < text.Length; i ++)
            {
                if (text[i] == ' ')
                {
                    words++;
                }
            }

            Console.WriteLine("Yout text has " + words + " words.");

            //Escribe un programa que copia un string a otro string.

            string a;
            string b = "Hola";

            a = string.Copy(b);

            Console.WriteLine("Both string have a value of " + a);


           //Escribe un programa que nos cuente el número de vocales en un string.

           int vocal = 0;
           string text1;

            Console.WriteLine("Type a word...");
            text1 = Console.ReadLine();
             

            for (int i = 0; i < text1.Length; i++)
            {
                if (text1[i] == 'a' || text1[i] == 'o' || text1[i] == 'i' || text1[i] == 'e' || text1[i] == 'u')
                {
                    vocal++;
                }
            }

            Console.WriteLine("Yout word has " + vocal + " vocals.");

            // Escribe un programa que devuelva un string en minúsculas en mayúsculas y al revés. NEED A CHANGE

            string textX = "";

            Console.WriteLine("Type a word in lower case or upper case ...");
            textX = Console.ReadLine();

            for (int i = 0; i< textX.Length; i++)
            {
                if (char.IsLower(textX[i]))
                {
                    char.IsUpper(textX[i]);

                    Console.WriteLine(textX);
                }
                else
                {
                    char.IsLower(textX[i]);

                    Console.WriteLine(textX);
                }
            }

            // Escribe un programa que devuelva un string en minúsculas en mayúsculas y al revés.

            string z = "hola natalia";

            string a = z.ToUpper();

            Console.WriteLine(a);

            // to lower case
            string v = "HOLA NATALIA";

            string b = v.ToLower();

            Console.WriteLine(b);

  //Escribe un programa que evalúe si un string contiene la letra ‘r’.

            string newString = "hola rrrrrrrrrrrrrrrrrrrr";

            if (newString.Contains('r'))
            {
                Console.WriteLine("Your string contains letra 'r'.");
            }
            else
            {
                Console.WriteLine("Your string doesn`t contain letra 'r'.");
            }

            // Escribe un programa el que dada una frase sacará su carácter central. Nota:
            // Si la largura de la frase es par deberá sacar los dos caracteres centrales correspondientes.
            // Si es impar deberá sacar su único carácter central.

            string word = "HOLa";
            int startIndex = ' ';
            int length = ' ';

            if (word.Length % 2 == 0)
            {
                startIndex = word.Length / 2;
                length = 2;

                string substring = word.Substring(startIndex, length);

                Console.WriteLine("Even and teh number is " + substring);
            }
            else
            {
                startIndex = word.Length / 2;
                length = 1;

                string substring = word.Substring(startIndex, length);

                Console.WriteLine("Odd " + substring);
            }

            //Escribe un programa que muestre la fecha de hoy. HOW TO MAKE IT SIMPLIER?

            int d = (int)System.DateTime.Now.DayOfWeek;
            Console.WriteLine(d);

            // Escribe un programa que al meter tres números por teclado identifique el mínimo y el máximo (usa el método correspondiente).

            int a= 4, b= 7, c=119;

            Console.WriteLine(Math.Max(Math.Max(a, b),c));

            // Escribe un programa el cual analizará si la contraseña introducida es correcta o no. Para que la contraseña sea correcta deberá cumplir estas directivas:
            // Debe tener 8 caracteres como mínimo.
            //La contraseña deberá contener números.
            //Deberá contener al menos dos dígitos. 
*/
            string contraseña = "";
            // setting up to false cause it will be false until all password requirements are passed
            bool correct = false;
            int contador = 0;

            do
            {
                Console.WriteLine("Type your password below...");
                contraseña = Console.ReadLine();
                if (contraseña.Length == 8)
                {
                    for (int i = 0; i < contraseña.Length; i++)
                    {
                        char.IsDigit(contraseña[i]);

                        contador++;

                        if(contador>=2)
                        {
                            correct = true;
                        }
                    }
                 
                }
            } while (correct == false);

            Console.WriteLine("Your password is correct!");



            Console.ReadLine();
        }
    }
}
