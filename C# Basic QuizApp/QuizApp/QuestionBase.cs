using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    /// <summary>
    /// Anket Soruları tanımla
    /// </summary>
    internal class QuestionBase
    {
        //Soruları tanımla, public erişim için kullanıldı.
        public List<string> Questions { get; set; } = new List<string> {
            "Ad:",
            "Soyad:",
            "Konuştuğunuz diller:",
            "İlgi alanlarınız:",
        };
    }
}
