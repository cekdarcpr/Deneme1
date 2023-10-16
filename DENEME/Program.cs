namespace DENEME
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            
            //Console.WriteLine("Hola Amigo");
            /* Console.Clear(); // Ekran Temizlenir 

             Console.WriteLine("\t\t**************************************");
             Console.WriteLine("\t\t*                                    *");
             Console.WriteLine("\t\t*   MATEMATİKSEL OPERATÖR ÖRNEKLERİ  *");
             Console.WriteLine("\t\t*                                    *");
             Console.WriteLine("\t\t**************************************");

             // Mod alma operatörü 
             int a = 5 % 2;

             Console.WriteLine("\n\t\tMod işleminin Sonucu = {0}",a);

             float b = 5 / 2f;
             Console.WriteLine("İlginç durum sonucu = " + b + "\n");

             float c = 2 / 5f / 2f;

             Console.WriteLine("ancak durumu sonucu = " + c + "\n");

             float e = 2f / 5 / 2 / 2 / 4 / 8 / 4 / 5 / 3;
             Console.WriteLine("daha ilginç durum = " + e); */
           
           // Console.BackgroundColor = ConsoleColor.DarkRed; // Konsole panel rengini değiştiren komut...
            
            Console.Write("\t1. Sayınızı Giriniz = ");
            
            double sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\t2. Sayınızı Giriniz = ");
            
            double sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n");


            double toplama = sayi1 + sayi2; 
            double cıkarma = sayi1 - sayi2;
            double carpma = sayi1 * sayi2;
            double bolme = sayi1 / sayi2;

            Console.WriteLine("\t{0} + {1} = {2}",sayi1,sayi2,toplama);
            Console.WriteLine("\t{0} - {1} = {2}", sayi1, sayi2, cıkarma);
            Console.WriteLine("\t{0} * {1} = {2}", sayi1, sayi2, carpma);
            Console.WriteLine("\t{0} / {1} = {2}", sayi1, sayi2, bolme);

            Console.ReadKey();  


        }
    }
}
