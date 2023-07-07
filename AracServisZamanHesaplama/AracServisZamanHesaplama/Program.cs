using System;

namespace AracServisZamanHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Trafiğe çıkış tarihi alınan bir aracın servis zamanını
            //    aşağıdaki bilgilere göre hesaplayınız.
            //    1. Bakım => 1. yıl     
            //    2. Bakım => 2. yıl      
            //    3. Bakım => 3. yıl     
            //    ** Süre hesabını alınan gün, ay, yıl bilgisine göre gün bazlı hesaplayınız..  

            Console.Write("Trafiğe çıktığınız yıl: ");
            int yil = int.Parse(Console.ReadLine());

            Console.Write("Trafiğe çıktığınız ay: ");
            int ay = int.Parse(Console.ReadLine());

            Console.Write("Trafiğe çıktığınız gün: ");
            int gun = int.Parse(Console.ReadLine());

            int toplamGun = (DateTime.Now - new DateTime(yil, ay, gun)).Days;

            if (toplamGun <= 365)
                Console.WriteLine("1.servis");
            else if (toplamGun > 365 && toplamGun <= 365 * 2)
                Console.WriteLine("2.servis");
            else if (toplamGun > 365 * 2 && toplamGun <= 365 * 3)
                Console.WriteLine("3.servis");
            else if (toplamGun > 365 * 3 && toplamGun <= 365 * 4)
                Console.WriteLine("4.servis");
            else if (toplamGun > 365 * 4 && toplamGun <= 365 * 5)
                Console.WriteLine("5.servis");
            else if (toplamGun > 365 * 5 && toplamGun <= 365 * 6)
                Console.WriteLine("6.servis");
            else if (toplamGun > 365 * 6 && toplamGun <= 365 * 7)
                Console.WriteLine("7.servis");
            else if (toplamGun > 365 * 7 && toplamGun <= 365 * 8)
                Console.WriteLine("8.servis");
            else
                Console.WriteLine("yanlış bilgi");

        }
    }
}
