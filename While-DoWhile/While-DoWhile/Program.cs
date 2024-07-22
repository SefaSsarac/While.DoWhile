using System;

class Program
{
    static void Main()
    {
        Console.Write("Limit değerini giriniz: ");
        int limit = int.Parse(Console.ReadLine());

        int sayac = 0;

        // while döngüsü kullanarak sayaç 0'dan başlayarak limit değerine kadar 1'er 1'er artırılır
        while (sayac <= limit)
        {
            Console.WriteLine("Ben bir Patika'lıyım");
            sayac++;
        }

        // do-while döngüsü de aynı işlevi yapar, ancak döngü koşulu döngünün sonunda kontrol edilir
        /*
        Console.Write("Limit değerini giriniz: ");
        int limit = int.Parse(Console.ReadLine());

        int sayac = 0;

        // do-while döngüsü kullanarak sayaç 0'dan başlayarak limit değerine kadar 1'er 1'er artırılır
        do
        {
            Console.WriteLine("Ben bir Patika'lıyım");
            sayac++;
        } while (sayac <= limit);
    }
}
        */
    }
}