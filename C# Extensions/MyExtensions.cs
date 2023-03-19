using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _2023._01._16
{
    public static class MyExtensions
    {
        /// <summary>
        /// Extension method olduğu için this keyword olmak zorunda ve hangi
        /// tipi istiyorsak o tipte bir nesneyi yazmalıyız. this object veya this string gibi
        /// </summary>
        /// <param name="obj"></param>
        public static void DisplayAssemblyInfo(this object obj)
        {
            Console.WriteLine("Object Type  : {0}, Assembly : \n ",
                obj.GetType().Name,
                Assembly.GetAssembly(obj.GetType()).GetName().Name);
        }

        /// <summary>
        /// Extension method for integer.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static int Square(this int i)
        {
            return i * i;
        }

        /// <summary>
        /// Liste array vb. nesneler için IEnumerable ortak interface kulanıldı
        /// Bu sayede array için list için tek tek methodlar yazmak yerine tek
        /// bir methodta halledildi.
        /// </summary>
        /// <param name="iterator"></param>
        public static void ShowItems(this IEnumerable iterator)
        {
            foreach (var item in iterator)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Adds fullstop to string
        /// </summary>
        /// <param name="stringInput"></param>
        /// <returns></returns>
        public static string AddFullStopToString(this string stringInput)
        {
            return stringInput + ".";
        }
    }
}
