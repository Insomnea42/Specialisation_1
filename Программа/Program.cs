// Задать массив из строк
//  найти те элементы с длиной <=3
//  вывести в новый массив

// Блок вспомогательных методов
void PrintNewArray(string[] arr)
{
    int leng = arr.Length;
    for (int i = 0; i < leng; i++)
    {
        if (arr[i] != null) Console.Write(arr[i] + ", ");
    }
}

string[] CreateNewArray(string[] arr1)
{
    int leng = arr1.Length;
    string[] arr2 = new string[leng];
    int j = 0;
    for (int i = 0; i < leng; i++)
    {
        if (arr1[i].Length <= 3)
        {
            arr2[j] = arr1[i];
            j++;
        }
    }
    if (j == 0) Console.Write("Нет подходящих элементов");
    else
    {
        Console.WriteLine("Новый массив, длина элементов <= 3: ");
    }
    return arr2;
}

// Блок основного кода

Console.WriteLine("Введите длину исходного массива: ");
int m = Convert.ToInt32(Console.ReadLine());
if (m > 0)
{
    string[] arr1 = new string[m];
    string temp = "";

    Console.WriteLine("Введите элементы исходного массив: ");

    //Заполнение исходного массива из терминала:
    for (int i = 0; i < m; i++)
    {
        temp = Convert.ToString(Console.ReadLine());
        if (temp != "" && temp != null) arr1[i] = temp;
        else
        {
            arr1[i] = "Введено пустое значение";
        }
    }

    string[] arr2 = CreateNewArray(arr1);
    PrintNewArray(arr2);
}
else Console.Write("Длина массива должна быть положительным числом, попробуйте снова");

Console.WriteLine();