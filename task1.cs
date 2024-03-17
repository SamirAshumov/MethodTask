// 2 string array-i içerisindeki ortaq elementleri tapib ekrana yazdiran metod

string[] text1 = { "Baku", "Ankara", "Moscow", "Berlin", "Tehran", "Beijing", "Washington", "Riga", "London" };

string[] text2 = { "Oslo", "Paris", "Baku", "Tallin", "Astana", "Rabat", "Washington", "Tokyo", "London" };

CompareString(text1, text2);



static void CompareString (string[] a, string[] b)
{
    string commonWords = " ";

    for (int i = 0; i < a.Length; i++)
    {


        for (int j = 0; j < b.Length; j++)
        {
            if (a[i] == b[j])
            {
                commonWords += a[i] + " ";
            }
            

        }

    }

    Console.WriteLine(commonWords);
}