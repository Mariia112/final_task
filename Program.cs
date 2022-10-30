/*Написать программу, которая из имеющегося массива 
сток формирует массив из строк, длина которых меньше, 
либо равна 3 символа.*/
Console.WriteLine("Введите текст через пробел: ");

string text = Console.ReadLine()!;
string[] stringArray1 = text.Split(' ');
string[] stringArray2 = new string[stringArray1.Length];

findStringWithAtMostThree(stringArray1);
PrintArray(stringArray2);


void findStringWithAtMostThree (string[] stringArray1)
{
    int count = 0;
    for (int i = 0; i < stringArray1.Length; i++)
    {
        if (stringArray1[i].Length <= 3)
        {
        stringArray2[count] = stringArray1[i];
        count++;
        }
    }
}

void PrintArray (string[] stringArray2)
{
    for (int count = 0; count < stringArray2.Length; count++)
    {
        Console.Write($"{stringArray2[count]} ");
    }
    Console.WriteLine();
}
