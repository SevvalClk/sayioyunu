using System;

namespace sayioyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı Tahmin Oyununa Hoş Geldiniz!");

            while (true)
            {
                Console.WriteLine("Kolay, Orta veya Zor seviyeyi seçin:");
                Console.WriteLine("Kolay için 1, Orta için 2, Zor için 3 girin:");

                int maxTries = 0;
                int level = int.Parse(Console.ReadLine());

                if (level == 1)
                {
                    maxTries = 8;
                }
                else if (level == 2)
                {
                    maxTries = 6;
                }
                else if (level == 3)
                {
                    maxTries = 3;
                }


                Random random = new Random();
                int randomNumber = random.Next(1, 101);

                Console.WriteLine($"Tahmin etmek için 1 ile 100 arasında bir sayı girin. {maxTries} hakkınız var:");

                for (int i = 0; i < maxTries; i++)
                {
                    int guess = int.Parse(Console.ReadLine());

                    if (guess < randomNumber)
                    {
                        Console.WriteLine("Daha yüksek bir sayı girin.");
                    }
                    else if (guess > randomNumber)
                    {
                        Console.WriteLine("Daha düşük bir sayı girin.");
                    }
                    else
                    {
                        Console.WriteLine("Tebrikler, doğru sayıyı buldunuz!");

                        if (level == 1)
                        {
                            Console.WriteLine("Orta seviyeye geçmek ister misiniz? (Evet/Hayır)");
                            string response = Console.ReadLine().ToLower();
                            if (response == "evet")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Oyunumuzu oynadığınız için teşekkürler.");
                                return;
                            }
                        }
                        else if (level == 2)
                        {
                            Console.WriteLine("Zor seviyeye geçmek ister misiniz? (Evet/Hayır)");
                            string response = Console.ReadLine().ToLower();
                            if (response == "evet")
                            {
                                maxTries = 3;
                                level = 3;
                                randomNumber = random.Next(1, 101);
                                Console.WriteLine($"Tahmin etmek için 1 ile 100 arasında bir sayı girin. {maxTries} hakkınız var:");
                            }
                            else
                            {
                                Console.WriteLine("Oyunumuzu oynadığınız için teşekkürler.");
                                return;
                            }
                        }
                        else if (level == 3)
                        {
                            Console.WriteLine("Tekrar oynamak ister misiniz? (Evet/Hayır)");
                            string response = Console.ReadLine().ToLower();
                            if (response == "evet")
                            {
                                maxTries = 3;
                                i = -1;
                                randomNumber = random.Next(1, 101);
                                Console.WriteLine($"Tahmin etmek için 1 ile 100 arasında bir sayı girin. {maxTries} hakkınız var:");
                            }
                            else
                            {
                                Console.WriteLine("Oyunumuzu oynadığınız için teşekkürler.");
                                return;
                            }
                        }
                    }
                }

                Console.WriteLine($"Tahmin hakkınız bitti. Doğru sayı: {randomNumber}. Oyunu tekrar oynamak ister misiniz? (Evet/Hayır)");
                string again = Console.ReadLine().ToLower();
                if (again != "evet")
                {
                    Console.WriteLine("Oyunumuzu oynadığınız için teşekkürler.");
                    break;
                }
            }
        }
    }
}
