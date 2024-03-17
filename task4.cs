//// Area deyə Method(lar) yaradın
//   a. Çevrənin sahəsi - S = p*r² (p=3)
//   b. Düzbucaqlının sahəsi - S = a*b
//   c. Düzbucaqlı paralelpipedin tam səthinin sahəsi - S=2(a*b+a*c+b*c)
//   d. Üçbucaqlının daxilinə çəkilmiş çevrənin sahəsi - S=p*r; p = (a + b + c) / 2


using System;

class Program
{
    static void Main(string[] args)
    {
        int selector = 0;

        Console.WriteLine("Emeliyyatlardan birini secin : ");
        Console.WriteLine("1.Cevrenin sahesinin hesablamaq \n2.Duzbucaqlinin sahesini hesablamaq \n3.Duzbucaqli paralelpipedin tam sethinin sahesini hesablamaq \n4.Ucbucagin daxiline cekilmis cevrenin sahesini hesablamaq");
        selector = Convert.ToInt32(Console.ReadLine());

        switch (selector)
        {
            case 1:
                int radius = 0;
                Console.WriteLine("Radiusu daxil edin : ");
                radius = Convert.ToInt32(Console.ReadLine());
                Area(radius);
                break;

            case 2:
                int a = 0;
                int b = 0;
                Console.WriteLine("Duzbucaqlinin tereflerini daxil edin : ");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Area(a, b));
                break;

            case 3:
                Console.WriteLine("Duzbucaqli paralelpipedin tereflerini daxil edin : ");
                int c = 0;
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = Convert.ToInt32(Console.ReadLine());
                Area(a, b, c);
                break;

            case 4:
                int rad = 0;
                Console.WriteLine("Ucbucagin tereflerini daxil edin : ");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ucbucagin daxiline cekilmis cevrenin radisunu daxil edin : ");
                rad = Convert.ToInt32(Console.ReadLine());
                Area(a, b, c, rad);
                break;

            default:
                Console.WriteLine("Emeliyyat duzgun secilmeyib!");
                break;

        }
    }


    static void Area(int radius)
    {
        int p = 3;
        Console.WriteLine(p * radius * radius);
    }


    static int Area(int a, int b)
    {
        return a * b;
    }

    static void Area(int a, int b, int c)
    {
        Console.WriteLine(2 * (a * b + a * c + b * c));
    }

    static void Area(int a, int b, int c, int rad)
    {
        int p = (a + b + c) / 2;

        Console.WriteLine(p * rad);
    }

}
