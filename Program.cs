using System;
namespace IkiliDegerHesaplama
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("***Kullanicidan n tane integer ikililerin toplamini alan, eğer sayilar birbirinden farkliysa toplamlarini ekrana yazdiran, sayilar ayniysa toplaminin karesini ekrana yazdirma***");
            Console.WriteLine("__________________________________________________________________________________");
            Console.Write("n tane ikili deger giriniz (0'a basarak programi sonlandirabilirsiniz): ");

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                try
                {
                    for (int i = 0; i < input.Length; i += 2)
                    {
                        if (i + 1 < input.Length)
                        {
                            int sayi1 = Convert.ToInt32(input[i]);
                            int sayi2 = Convert.ToInt32(input[i + 1]);
                            int toplam = sayi1 + sayi2;

                            if (sayi1 != sayi2)
                            {
                                Console.Write(toplam + " ");
                            }
                            else
                            {
                                Console.Write(toplam * toplam + " ");
                            }
                        }
                    }
                    Console.WriteLine();
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Gecerli bir sayi girisi yapmadiniz. Lutfen tekrar deneyin");
                }
            }
        }
    }
}