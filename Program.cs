using System;

class Program
{
    static int TrailingZeroes(int n)
    {
        int count = 0;

        while (n >= 5)
        {
            n /= 5;
            count += n;
        }

        return count;
        /*
         *  // Faktorial har qanday son n uchun faqatgina 5 ga bo'linadigan sonlarda ohirgi nollarni olish mumkin.
        // Shuning uchun, faktorial hisoblanishida nechta 5 ga bo'linadigan sonlar mavjudligini hisoblaymiz.
        // Qo'shimcha ravishda, har bir 5 ga bo'linadigan son kamida bir ohirgi nolga hisoblanadi.
        // 25 ga bo'linadigan sonlar ikkinchi ohirgi nolga, va hokazo.
        // Shu sababli, berilgan son necha marta 5, 25, 125 va hokazo ga bo'linishi bilan aniqlik bilan tanishamiz.
        // Bu amalni, bulimlar 0 bo'lishgacha ishlatiladigan tsikl orqali amalga oshiramiz.
        */
    }

    static void Main(string[] args)
    {
        int n = 30; // Or any other number you want to find the trailing zeroes for

        int result = TrailingZeroes(n);


        Console.WriteLine("The number of trailing zeroes in " + n + "! is: " + result);
    }
}
