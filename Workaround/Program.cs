using System;
using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            SelamVer("Engin");
            SelamVer("Ayşe");
            SelamVer("Ahmet");
            SelamVer();           

            /*string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };
            sehirler2 = sehirler1;  //------> Reference Type (class, interface, array
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);         // Adana yazdırır */

            /*List<string> yeniSehirler1 = new List<string> { "Ankara", "İstanbul", "İzmir" }; //---->Generic Collection
            yeniSehirler1.Add("Eskişehir");*/

            Person person1 = new Person();
            person1.FirstName = "SELİM";
            person1.LastName = "YÜKSEL";
            person1.DateOfBirthYear = 1997;
            person1.NationalIdentity = 123;
           
                                
            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);


            Console.ReadLine();
        }

        static void SelamVer(string isim = "isimsiz")  //static ---> mainde kullanılacağı için
        {
            Console.WriteLine("Merhaba " + isim);
        }     
    }
}

