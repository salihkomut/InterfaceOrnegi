using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnegi
{
    interface Kutuphane
    {
        void Al(string ad);
        void Oku();
    }
    class Kitap : Kutuphane
    {
        private string dergiAdi;
        public void Al(string ad)
        {
            Console.WriteLine("şu kitap alındı : " + ad);
            dergiAdi = ad;
        }

        public void Oku()
        {
            Console.WriteLine("alınan kitap okundu : "+dergiAdi);
            
        }
    }
    class Ansiklopedi : Kutuphane
    {
        private string dergiAdi;
        public void Al(string ad)
        {
            Console.WriteLine("şu ansiklopedi alındı : " + ad);
            dergiAdi = ad;
        }
        public void Oku()
        {
            Console.WriteLine("alınan ansiklopedi okundu : "+dergiAdi);
        }
    }
    class Dergi : Kutuphane
    {
        private string dergiAdi;
        public void Al(string ad)
        {
            Console.WriteLine("şu dergi alındı : " + ad);
            dergiAdi = ad;
        }
        public void Oku()
        { Console.WriteLine("alınan dergi okundu : " + dergiAdi); }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Kutuphane okunacak;
            
            
            okunacak = new Kitap();
            okunacak.Al("dede korkut");
            okunacak.Oku();

            

            okunacak = new Ansiklopedi();
            okunacak.Al("cumhuriyet ansiklopedisi");
            okunacak.Oku();

            okunacak = new Dergi();
            okunacak.Al("monstar");
            okunacak.Oku();

            Console.ReadKey();

        }
    }
}
