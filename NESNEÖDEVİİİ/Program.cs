using System;

namespace NESNEÖDEVİİİ
{
    class Program
    {
        static void Main(string[] args)
        {
            int mevcut = 0;
            Console.Write("Sınıf mevcudunu giriniz : ");
            mevcut = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            string[] öğrenci = new string[mevcut];

            for (int i = 0; i < mevcut; i++)
            {
                string ad, soyad;
                Console.WriteLine("Adınızı  girin:");
                ad = Console.ReadLine();
                Console.WriteLine("Soyadınızı girin:");
                soyad = Console.ReadLine();
                Console.ReadKey();

                int vize, final, ort;
                Console.Write("Vize notunu giriniz: ");
                vize = Convert.ToInt32(Console.ReadLine());
                Console.Write("Final notunu giriniz: ");
                final = Convert.ToInt32(Console.ReadLine());
                ort = Convert.ToInt32(vize * 0.4 + final * 0.6);
                Console.WriteLine();
                Console.WriteLine("Ortalamanız = {0}", ort);
                Console.WriteLine();
                if (ort < 50 || final < 50)
                    Console.WriteLine("Kaldınız.");
                else
                    Console.WriteLine("Geçtiniz.");
                if (ort >= 0 && ort <= 38)
                {
                    Console.WriteLine("Ortalamanız={0} ", ort);
                    Console.WriteLine("FF Kaldınız");
                }
                else if (ort >= 39 && ort <= 47)
                {
                    Console.WriteLine("Ortalamanız={0} ", ort);
                    Console.WriteLine("FD Kaldınız");
                }
                else if (ort >= 48 && ort <= 57)
                {
                    Console.WriteLine("Ortalamanız={0}", ort);
                    Console.WriteLine("DD Koşullu");
                }
                else if (ort >= 58 && ort <= 67)
                {
                    Console.WriteLine("Ortalamanız={0}", ort);
                    Console.WriteLine("DC Koşullu");
                }
                else if (ort >= 68 && ort <= 74)
                {
                    Console.WriteLine("Ortalamanız={0}", ort);
                    Console.WriteLine("CC Geçtiniz");
                }
                else if (ort >= 75 && ort <= 79)
                {
                    Console.WriteLine("Ortalamanız={0}", ort);
                    Console.WriteLine("CB Geçtiniz");
                }
                else if (ort >= 80 && ort <= 84)
                {
                    Console.WriteLine("Ortalamanız={0}", ort);
                    Console.WriteLine("BB Geçtiniz");
                }
                else if (ort >= 85 && ort <= 89)
                {
                    Console.WriteLine("Ortalamanız={0}", ort);
                    Console.WriteLine("BA Geçtiniz");
                }
                else if (ort >= 90 && ort <= 100)
                {
                    Console.WriteLine("Ortalamanız={0}", ort);
                    Console.WriteLine("AA Geçtiniz");
                }
                else

                    Console.ReadKey();
            }
        }
    }
}
