using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Soner";
            int yas = 22;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Soner ATEŞ";
            kurs1.IzlenmeOrani = 34;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "HTML";
            kurs2.Egitmen = "Soner ATEŞ";
            kurs2.IzlenmeOrani = 99;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "CSS";
            kurs3.Egitmen = "Soner ATEŞ";
            kurs3.IzlenmeOrani = 85;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ":" + kurs.Egitmen + ":" + kurs.IzlenmeOrani);
            }
        }
    }
}
