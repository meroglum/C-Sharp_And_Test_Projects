using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Lecture notes.
    /// </summary>
    internal class Program
    {
        // these are used on region part01.
        private static string dolarTitleXPath = "//div[@class='dovizBar mBot20']//a[1]//span[1]//span[1]";
        private static string dolarAlisXpath = "//div[@class='dovizBar mBot20']//a[1]//span[2]//span[2]";
        private static string dolarSatisXPath = "//div[@class='dovizBar mBot20']//a[1]//span[3]//span[2]";

        private static string euroTitleXPath = "//div[@class='dovizBar mBot20']//a[2]//span[1]//span[1]";
        private static string euroAlisXpath = "//div[@class='dovizBar mBot20']//a[2]//span[2]//span[2]";
        private static string euroSatisXPath = "//div[@class='dovizBar mBot20']//a[2]//span[3]//span[2]";

        private static string sterlinTitleXpath = "//div[@class='dovizBar mBot20']//a[3]//span[1]//span[1]";
        private static string sterlinAlisXpath = "//div[@class='dovizBar mBot20']//a[3]//span[2]//span[2]";
        private static string sterlinSatisXPath = "//div[@class='dovizBar mBot20']//a[3]//span[3]//span[2]";

        private static string dovizXPath = "//div[@class='dovizBar mBot20']//a";

        static void Main(string[] args)
        {
            HtmlWeb htmlWeb= new HtmlWeb();
            HtmlDocument doc = htmlWeb.Load("https://bigpara.hurriyet.com.tr/doviz/");
            List<BigPara> dovizler = new List<BigPara>();
            #region part01
            //   
          

            //   var dolarTitle = doc.DocumentNode.SelectSingleNode(dolarTitleXPath).InnerText;
            //   var dolarAlis = doc.DocumentNode.SelectSingleNode(dolarAlisXpath).InnerText;
            //   var dolarSatis = doc.DocumentNode.SelectSingleNode(dolarSatisXPath).InnerText;

            //   var euroTitle = doc.DocumentNode.SelectSingleNode(euroTitleXPath).InnerText;
            //   var euroAlis = doc.DocumentNode.SelectSingleNode(euroAlisXpath).InnerText;
            //   var euroSatis = doc.DocumentNode.SelectSingleNode(euroSatisXPath).InnerText;

            //   var sterlinTitle = doc.DocumentNode.SelectSingleNode(sterlinTitleXpath).InnerText;
            //   var sterlinAlis = doc.DocumentNode.SelectSingleNode(sterlinAlisXpath).InnerText;
            //   var sterlinSatis = doc.DocumentNode.SelectSingleNode(sterlinSatisXPath).InnerText;

            //   dovizler.Add(
            //       new BigPara() {
            //           AlisFiyat = dolarAlis,
            //           SatisFiyat = dolarSatis,
            //           DovizTur = dolarTitle,
            //       });

            //   dovizler.Add(
            //new BigPara()
            //{
            //    AlisFiyat = euroAlis,
            //    SatisFiyat = euroSatis,
            //    DovizTur = euroTitle,
            //});

            //   dovizler.Add(
            //new BigPara()
            //{
            //    AlisFiyat = sterlinAlis,
            //    SatisFiyat = sterlinSatis,
            //    DovizTur = sterlinTitle,
            //});

            //   foreach (var para in dovizler)
            //   {
            //       Console.WriteLine($"Döviz Tür: {para.DovizTur}, Alış Fiyatı: {para.AlisFiyat}, Satış Fiyatı: {para.SatisFiyat}");
            //   }
            //   Console.ReadLine();
            //  
            #endregion

            #region part02 with less code of part 01
            var dovizTotal = doc.DocumentNode.SelectNodes(dovizXPath);

            foreach (var doviz in dovizTotal)
            {
                var dovizTitle = doviz.SelectSingleNode(".//span[1]//span[1]").InnerText;
                var dovizAlis = doviz.SelectSingleNode(".//span[2]//span[2]").InnerText;
                var dovizSatis = doviz.SelectSingleNode(".//span[3]//span[2]").InnerText;

                dovizler.Add(
                    new BigPara()
                    {
                        AlisFiyat= dovizAlis,
                        SatisFiyat= dovizSatis,
                        DovizTur = dovizTitle,
                    });
            }

            foreach (var para in dovizler)
            {
                Console.WriteLine($"Döviz Tür: {para.DovizTur}, Alış Fiyatı: {para.AlisFiyat}, Satış Fiyatı: {para.SatisFiyat}");
            }
            Console.ReadLine();
            #endregion
        }
    }
}
