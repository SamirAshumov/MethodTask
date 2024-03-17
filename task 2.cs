// 2 eyni uzunluqlu array içerisindeki elementlerin indexlerine uygun hasilini tapib ekrana yazdiran metod
// (example : { 5 , 10 ,15}. ve {2 , 4 , 5}. ==>  { 10 , 40 ,75 })

int[] numbers1 = { 8, 12, 20, 30 };

int[] numbers2 = { 3, 10, 5, 3 };


Multiply(numbers1, numbers2);


static void Multiply(int[] a, int[] b)
{

    string result = " ";

    for (int i = 0; i < a.Length; i++)
    {
        result += a[i] * b[i] + " ";
    }

    Console.WriteLine(result);
}