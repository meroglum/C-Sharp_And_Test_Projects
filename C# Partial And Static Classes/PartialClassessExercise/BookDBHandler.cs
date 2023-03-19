using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassessExercise
{
    partial class Book
    {
        /// <summary>
        /// Yeni eklenen kitabı DB ye gönder
        /// </summary>
        /// <param name="newBook"></param>
        /// <returns></returns>
        public bool SendNewBookToDB(Dictionary<string,string> newBook) {
            return true;
        }

        /// <summary>
        /// Database den kitapları siler
        /// </summary>
        /// <param name="bookID"></param>
        /// <returns></returns>
        public bool DeleteNewBookToDB(int bookID)
        {
            return true;
        }
    }
}
