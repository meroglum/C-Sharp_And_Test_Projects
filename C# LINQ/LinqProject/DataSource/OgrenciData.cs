using _2023._01._25LINQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._01._25LinqApp.DataSource
{
    public class OgrenciData
    {
        //    public List<Ogrenci> OgrenciListesi { get; set; } = new List<Ogrenci>()
        //{
        //    new Ogrenci{Cinsiyet = false,Id = 1, Ad = "Cihan", Soyad = "Ozhan", Notlar = {92.5 } ,DogumTarih = new DateTime(1988,7,17)},
        //    new Ogrenci{Cinsiyet = false,Id = 2, Ad = "Hakkı", Soyad = "Bulut",Notlar = { 78.56 } , DogumTarih = new DateTime(1987,3,10) },
        //    new Ogrenci{Cinsiyet = false,Id = 3, Ad = "Ali", Soyad = "Bulut", Notlar = { 56.90 } ,DogumTarih = new DateTime(1986,4,7)},
        //    new Ogrenci{Cinsiyet = false,Id = 4, Ad = "Veli", Soyad = "Yağmur",Notlar = { 88.45 } , DogumTarih = new DateTime(1985,1,22)},
        //    new Ogrenci{Cinsiyet = false,Id = 5, Ad = "Zeki", Soyad = "Su",Notlar = { 98.99 } , DogumTarih = new DateTime(1984,6,11)},
        //    new Ogrenci{Cinsiyet = true,Id = 6, Ad = "Medine", Soyad = "Toprak",Notlar = { 65.36 } , DogumTarih = new DateTime(1983,1,14)},
        //    new Ogrenci{Cinsiyet = true,Id = 7, Ad = "Ayşe", Soyad = "Tahta",Notlar = { 79.84 } , DogumTarih = new DateTime(1983,8,12)},
        //    new Ogrenci{Cinsiyet = true,Id = 8, Ad = "Fatma", Soyad = "Odun",Notlar = { 52.51 } , DogumTarih = new DateTime(1982,3,12)},
        //    new Ogrenci{Cinsiyet = false,Id = 9, Ad = "Murtaza", Soyad = "Ateş",Notlar = { 45.5 } , DogumTarih = new DateTime(1981,11,18)},
        //    new Ogrenci{Cinsiyet = false,Id = 10, Ad = "Kemal", Soyad = "Cemal",Notlar = { 80.01 } , DogumTarih = new DateTime(1976,12,20)},
        //    new Ogrenci{Cinsiyet = true,Id = 11, Ad = "Ayşe", Soyad = "Sözlü",Notlar = { 79.84 } , DogumTarih = new DateTime(1983,8,12)},
        //};


        public List<Ogrenci> OgrenciListesi { get; set; } = new List<Ogrenci>()
        {
            new Ogrenci{Cinsiyet = false,Id = 1, Ad = "Cihan", Soyad = "Ozhan", NotOrtalaması = 92.5  ,DogumTarih = new DateTime(1988,7,17)},
            new Ogrenci{Cinsiyet = false,Id = 2, Ad = "Hakkı", Soyad = "Bulut",NotOrtalaması =  78.56  , DogumTarih = new DateTime(1987,3,10) },
            new Ogrenci{Cinsiyet = false,Id = 3, Ad = "Ali", Soyad = "Bulut", NotOrtalaması =  56.90  ,DogumTarih = new DateTime(1986,4,7)},
            new Ogrenci{Cinsiyet = false,Id = 4, Ad = "Veli", Soyad = "Yağmur",NotOrtalaması =  88.45  , DogumTarih = new DateTime(1985,1,22)},
            new Ogrenci{Cinsiyet = false,Id = 5, Ad = "Zeki", Soyad = "Su",NotOrtalaması =  98.99  , DogumTarih = new DateTime(1984,6,11)},
            new Ogrenci{Cinsiyet = true,Id = 6, Ad = "Medine", Soyad = "Toprak",NotOrtalaması =  65.36  , DogumTarih = new DateTime(1983,1,14)},
            new Ogrenci{Cinsiyet = true,Id = 7, Ad = "Ayşe", Soyad = "Tahta",NotOrtalaması =  79.84  , DogumTarih = new DateTime(1983,8,12)},
            new Ogrenci{Cinsiyet = true,Id = 8, Ad = "Fatma", Soyad = "Odun",NotOrtalaması =  52.51  , DogumTarih = new DateTime(1982,3,12)},
            new Ogrenci{Cinsiyet = false,Id = 9, Ad = "Murtaza", Soyad = "Ateş",NotOrtalaması = 45.5  , DogumTarih = new DateTime(1981,11,18)},
            new Ogrenci{Cinsiyet = false,Id = 10, Ad = "Kemal", Soyad = "Cemal",NotOrtalaması =  80.01  , DogumTarih = new DateTime(1976,12,20)},
            new Ogrenci{Cinsiyet = true,Id = 11, Ad = "Ayşe", Soyad = "Sözlü",NotOrtalaması =  79.84  , DogumTarih = new DateTime(1983,8,12)},
        };
    }
}
