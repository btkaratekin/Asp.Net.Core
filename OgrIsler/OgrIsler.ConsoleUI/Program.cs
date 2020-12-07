
using OgrIsler.Business.Concrete;

using System;
using System.Threading.Tasks;

namespace OgrIsler.ConsoleUI
{
    class Program
    {
        
        static async Task Main(string[] args)
        {
          
            OgrBilgiService _OgrBilgiService = new OgrBilgiService();

            var veriler = await _OgrBilgiService.GetList();
            foreach (var veri in veriler)
            {
                Console.WriteLine("Öğrenci No:" + veri.OgrNo);
                Console.WriteLine("Öğrenci Adı:" + veri.Adi);
                Console.WriteLine("Öğrenci Soyadı:" + veri.Soyadi);
                Console.WriteLine("Öğrenci Doğum Tarihi:" + veri.Dtarih.ToShortDateString());
                Console.WriteLine("Öğrenci Cinsiyeti:{0}", veri.Cinsiyet ? "Kız" : "Erkek");
                Console.WriteLine();
            }


            _OgrBilgiService.Insert()
            //IOgrBilgiService _OgrBilgiService = new OgrBilgiService(new OgrBilgiDal());

            //var veriler = await _OgrBilgiService.GetList();
            //foreach (var veri in veriler)
            //{
            //    Console.WriteLine("Öğrenci No:" + veri.OgrNo);
            //    Console.WriteLine("Öğrenci Adı:" + veri.Adi);
            //    Console.WriteLine("Öğrenci Soyadı:" + veri.Soyadi);
            //    Console.WriteLine("Öğrenci Doğum Tarihi:" + veri.Dtarih.ToShortDateString());
            //    Console.WriteLine("Öğrenci Cinsiyeti:{0}", veri.Cinsiyet ? "Kız" : "Erkek");
            //    Console.WriteLine();
            //}


            Console.ReadLine();
        }

        
    }

}
