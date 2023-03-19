using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassessExercise
{
    partial class Book
    {
        /// <summary>
        /// Kitap listesini DB den getir
        /// </summary>
        public void GetBookFromDB()
        {
            BookList.Add("Yabancı", "Albert Camus");
            BookList.Add("Kalpazanlar", "André Gide");
            BookList.Add("Dünyaların Savaşı", "H.G.Wells");   
        }

        /// <summary>
        /// DB ye yeni kitap ekle
        /// </summary>
        public void AddNewBookToDB(string bookName,string bookAuthor)
        {
            BookList.Add(bookName, bookAuthor);
            bool getBooksFromDB = SendNewBookToDB(BookList);  //Parial classtan geliyor.
            if(!getBooksFromDB)
            {
                Console.WriteLine("Kitap listesi alınırken hata oluştu.");
            }
        }

        /// <summary>
        /// Kütüphanedeki tüm kitap listesini göster
        /// </summary>
        public void ShowAvailableBooksAndAuthorsOnLibrary() {
            Console.WriteLine("Kütüphanedeki kitap listesi");
            foreach (var bookAndAuthor in BookList)
            {
                Console.WriteLine("Kitap Adı: {0} Yazar {1}", bookAndAuthor.Key,bookAndAuthor.Value);
            }
        }
    }
}
