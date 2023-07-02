// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.



string Prompt(string message)
{
    Console.Write(message);
    string item = Console.ReadLine();
    return item;
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}


string[] GetArray()
{
    string[] res = new string[] {};
    int i =0; 

    while (i>= 0)
    {
         
        string item = Prompt("Введите значение или нажмите клавишу Q: ");
        if (item.ToLower() == "q") break;
        else 
        {
            Array.Resize(ref res, res.Length + 1);
            res[i] = item;
        }
        i++;
    }  
    return res;
}

string[] array = GetArray();
PrintArray(array);