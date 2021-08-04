using System;
using System.IO;

namespace E_Exceptions
{
    class Program
    {
        // если нам нужен собствееный тип исключений- можем его создать
        public class CreditCardWithDrawException : Exception
        {

        }
        // теперь его можно выбрасывать
        static void Main(string[] args)
        {
       
        }
        static void TryCatchDemo()
        {
            FileStream file = null;
            try
            {
                file = File.Open("temp.txt", FileMode.Open);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                if (file != null)
                {
                    file.Dispose();
                }
            }

            Console.ReadLine();

            Console.WriteLine("Please input a number");

            string result = Console.ReadLine();

            int number = 0;
            try
            {
                number = int.Parse(result);
            }
            catch (FormatException ex)
            {

                Console.WriteLine("A format exception has occured.");
                Console.WriteLine("Information is bellow:");
                Console.WriteLine(ex.ToString());
            }
            catch (Exception ex) // так, кст, обробатывать исключения нельзя. Обычно в такое правильнее записывать какое-нибудь логирование
            {
                Console.WriteLine(ex.ToString());
            }


            Console.WriteLine(number);
        }
    }
}
