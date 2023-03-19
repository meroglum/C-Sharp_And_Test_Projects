using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _1_BinarySerialization
{
    // http://www.csharpstar.com/serialize-and-deserialize-data-csharp/
    /// <summary>
    /// This is the lecture note.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //string data = "dataa";
            //FileStream stream = new FileStream("BinaryData.bta", FileMode.Create);
            //BinaryFormatter formatter = new BinaryFormatter();
            //formatter.Serialize(stream, data);


            //FileStream stream = new FileStream("BinaryData.bta", FileMode.Open);
            //BinaryFormatter formatter = new BinaryFormatter();
            //string deSerializeData = (string)formatter.Deserialize(stream);
            //Console.WriteLine("Data : " + deSerializeData);

            #region Örnek : Person

            //Person p = new Person
            //{
            //    Id = 1,
            //    Name = "Steve Smith"
            //};

            //IFormatter formatter = new BinaryFormatter();

            //using (Stream stream = new FileStream("data.bin", FileMode.Create))
            //{
            //    formatter.Serialize(stream, p);
            //}

            //using (Stream stream = new FileStream("data.bin", FileMode.Open))
            //{
            //    Person dp = (Person)formatter.Deserialize(stream);
            //}

            #endregion

            #region Örnek : Person (..Serializ..)

            //Person p = new Person
            //{
            //    Id = 1,
            //    Name = "Steve Smith"
            //};

            //IFormatter formatter = new BinaryFormatter();

            //using (Stream stream = new FileStream("data.bin", FileMode.Create))
            //{
            //    formatter.Serialize(stream, p);
            //}

            //using (Stream stream = new FileStream("data.bin", FileMode.Open))
            //{
            //    Person dp = (Person)formatter.Deserialize(stream);
            //}

            #endregion

            Console.ReadLine();
        }

        //IDeserializationCallback
    }

    // Örnek : Person
    //[Serializable]
    //public class Person
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    private bool isDirty = false;
    //}

    // Örnek : Person (..Serializ..)
    [Serializable]
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [NonSerialized]
        private bool isDirty = false;
        
        [OnSerializing()]
        internal void OnSerializingMethod(StreamingContext context)
        {
            Console.WriteLine("OnSerializing.");
        }

        [OnSerialized()]
        internal void OnSerializedMethod(StreamingContext context)
        {
            Console.WriteLine("OnSerialized.");
        }

        [OnDeserializing()]
        internal void OnDeserializingMethod(StreamingContext context)
        {
            Console.WriteLine("OnDeserializing.");
        }

        [OnDeserialized()]
        internal void OnDeserializedMethod(StreamingContext context)
        {
            Console.WriteLine("OnSerialized.");
        }
    }
}
