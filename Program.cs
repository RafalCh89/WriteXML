using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Serializacja1
{
    public struct person
    {
        public string name;
        public string surname;
        public int age;
        public string email;
        public string gender;
        public int phone;
    }

    class Program
    {
        static void Main(string[] args)
        {
         
            person o = new person();
            o.name = "Rafal";
            o.surname = "Choma";
            o.age = 26;
            o.email = "Rafal.choma@wp.pl";
            o.gender = "Male";
            o.phone = 0860733333;
            

          

            StreamWriter wr = new StreamWriter("person.xml"); 
            XmlSerializer serializer = new XmlSerializer(typeof(person)); 
            serializer.Serialize(wr, o);
           
            wr.Flush();
            wr.Close();
        }
    }
}