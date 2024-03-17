//Array -in içerisinde verilmiş herf ile başlayan elementleri ekrana yazdıran method
//(example : axtarırıq A hərfi  {"Anar" , "Eli" , "Yusif" , "Arif" }   ==> Anar , Arif)

string[] text1 = { "Samir", "Seymur", "Azer", "Abdulla", "Akif", "Ceyhun", "Camal" };

char letter = 'A';

FindString(text1, letter);


static void FindString(string[] a, char letter)
{
    string result = " ";

    for (int i = 0; i < a.Length; i++)
    {
        if (a[i][0] == letter)
        {
            result += a[i] + " ";
        }

    }

    if (result == " ")

        Console.WriteLine("Massivde bu herfe uygun soz yoxdur");
    else

        Console.WriteLine(result);
}