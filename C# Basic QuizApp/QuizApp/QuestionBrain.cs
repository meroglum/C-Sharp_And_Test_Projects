using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    internal class QuestionBrain:QuestionBase,IQuestionBrain
    ///QuestionBase.cs soruları getirmek için kullanıldı
    ///IQuestionBrain interface için kullanıldı.
    {
        int QuestionIndex = 0; //Sorular arası için index.
        List<string> VerilenCevaplar= new List<string>();

        /// <summary>
        /// Verilen Cevapları kaydet
        /// </summary>
        /// <param name="givenAnswer"></param>
        public void SaveGivenAnswers(string givenAnswer)
        {
            try
            {
                ///Herhangi bir cevap vermeme durumu için
                VerilenCevaplar.Add(givenAnswer);
            }catch(Exception ex) ///Exception kullanılabilir
            {
                //Console.WriteLine("Cevap Verilmeme hatası : "  + ex.Message);
                VerilenCevaplar.Add("Cevap verilmedi"); //Eğer cevap verilmezse bu değeri ekle
            }
            
        }

        /// <summary>
        /// Tüm soruları görüntülemek için----TODO Tek bir method ile de çözülebilir
        /// </summary>
        public void QuestionHandler()
        {
            for (int i = 0; i < Questions.Capacity; i++)
            {
                ShowQuestion();
                NextQuestion();
            }
        }

        /// <summary>
        /// Soruyu konsolda görüntülemek için
        /// </summary>
        public void ShowQuestion()
        {
           
                Console.Write(Questions[QuestionIndex]); //Soruyu konsolda göster.
                SaveGivenAnswers(Console.ReadLine()); //Cevabı kaydet. Exception methodta yönetiliyor.
        }

        /// <summary>
        /// Sonraki soruya geçmek için kullanlacak method.
        /// </summary>
        public void NextQuestion()
        {
            if (QuestionIndex < Questions.Count-1) ///Testi tamamlamadan önce sorulan sorular.
            {
                ///Soru sayısından fazla ilerlememesini kontrol eder.
                QuestionIndex++; //Bir sonraki soru indexi.

            }
            else
            {
                /// Sorulacak soru bitti.
                QuestionIndex++;//Sıradaki soruyu görüntüle.
                ShowTheEnd();
            }
        }

        /// <summary>
        /// Anketin bittiğini konsolda kullanıcıya bildirir
        /// </summary>
        public void ShowTheEnd()
        {
            ///Anket bitimini konsolda göster
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("*************************");
            Console.WriteLine("Anketi tamamladınız!");
            Console.WriteLine("*************************");
        }

        /// <summary>
        /// Anketin bittiğinde sonucu göster
        /// </summary>
        public void ShowResult()
        {
            ///Anket bitimini konsolda göster
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("-----------------------");
            Console.WriteLine("Anket Sonucu: İYİ Kİ VARSIN :)");
            Console.WriteLine("-----------------------");
        }

        /// <summary>
        /// Soruları kendi isteğimize göre değiştirmek için
        /// </summary>
        /// <param name="YourQuestionList"></param>
        public void WriteOnYourOwnQuestions(List<string> YourQuestionList)
        {
            Questions = YourQuestionList;
        }
    }
}
