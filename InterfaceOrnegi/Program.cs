using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnegi
{
    interface Kutuphane
    {
        void Oku(string adi);
    }
    class Kitap : Kutuphane
    {
        public void Oku(string kitapAi)
        {
            Console.WriteLine("şu kitap okundu : "+kitapAi);
            
        }
    }
    class Ansiklopedi : Kutuphane
    {
        public void Oku(string adi)
        {
            Console.WriteLine("ansiklopedi okundu : "+adi);
        }
    }
    class Dergi : Kutuphane
    {
        public void Oku(string adi)
        { Console.WriteLine("dergi okundu : "+adi); }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Kutuphane okunacak;
            
            
            okunacak = new Kitap();
            okunacak.Oku("Dede Korkut");
            

            okunacak = new Ansiklopedi();
            okunacak.Oku("cumhuriyet ansiklopedisi");

            okunacak = new Dergi();
            okunacak.Oku("monstar");

            Console.ReadKey();

        }
    }
}
