using System;

namespace ConsoleScreens
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba");
            Console.WriteLine("Dünya");
            String kelime = "Merhaba Dünya ";
            Console.Write("\n"+kelime);
            int x = 5;
            Console.Write("\n"+x+ "\n");
            Message mesaj = new Message();
            mesaj.metin();
            Kisiler people = new Kisiler();
            
            people.kisilistesi("Ebrar Karlı ");
            //string keyboardinp;
            //Console.Write("isim Giriniz : ");
            //keyboardinp = Console.ReadLine();
            //people.kisilistesi(keyboardinp);
            islem calculater = new islem();
            Console.WriteLine(calculater.topla(4,6));
            calculater.karesi(5);




            Console.ReadLine();
        }
    }
}
