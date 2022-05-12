using System;
//ER3N
namespace Soru2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] takim = {"Trabzonspor","Fenerbahçe","Konyaspor","başakşehir","alanyaspor" };

            Console.Write("Takım Adı Giriniz: ");
            string seçim = Console.ReadLine();
            if(seçim==takim[0])
            {
                Console.Write("Takımınız: "+takim[0]+" Sırası: 1");
            }
            if (seçim == takim[1])
            {
                Console.Write("Takımınız: " + takim[1] + " Sırası: 2");
            }
            if (seçim == takim[2])
            {
                Console.Write("Takımınız: " + takim[2] + " Sırası: 3");
            }
            if (seçim == takim[3])
            {
                Console.Write("Takımınız: " + takim[3] + " Sırası: 4");
            }
            if (seçim == takim[4])
            {
                Console.Write("Takımınız: " + takim[4] + " Sırası: 5");
            }

            Console.ReadKey();
        }
    }
}
