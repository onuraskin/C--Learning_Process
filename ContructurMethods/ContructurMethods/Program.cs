using System;

namespace ContructurMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Kimlik kml = new Kimlik();
            kml.AD = Console.ReadLine();
            kml.SOYAD = Console.ReadLine();
            kml.MEMLEKET = "Elazığ ";
            Console.WriteLine(kml.AD);
            Console.WriteLine(kml.SOYAD);
            Console.WriteLine(kml.YAS);
            Console.WriteLine(kml.CİNSİYET);
            Console.WriteLine(kml.MEMLEKET);
            
            




          
            
            
            Console.Read();
        }
    }
}
