// Программа, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам

string [] CreateUserArray (int n)
// метод по заполнению первоначального массива с клавиатуры пользователем
{
    string [] userArray = new string [n];
    for (int index = 0; index < userArray.Length; index++)
    {
        Console.Write ("Введите элемент строкового массива: ");     
        userArray [index] = Console.ReadLine ();
    }
    return userArray;
}

string [] CreateNewArrayFrom3SymbolsElements (string [] anyArray, int count) 
// метод по созданию нового массива из элементов, длина которых меньше либо равна 3 символам
{
    string [] newArray = new string [count];
    int k = 0;
    for (int j = 0; j < anyArray.Length; j++)
    {
        if (anyArray[j].Length <= 3)
        {                                    
            newArray [k] = anyArray [j];
            k++;
        }
    }
    return newArray;
}

void ShowArray (string [] randomArray)
// метод по выведению массива на экран
{
    for (int m = 0; m < randomArray.Length; m++)
    {
        Console.Write (randomArray [m] + " ");
    }
}

// код самой программы
Console.WriteLine ("Введите количество элементов создаваемого массива: ");
int size = Convert.ToInt32 (Console.ReadLine ());
string [] array = CreateUserArray (size);

int newArraySize = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array [i].Length <= 3) newArraySize++;
}

if (newArraySize > 0)
    {
        string [] resultArray = CreateNewArrayFrom3SymbolsElements (array, newArraySize);
        ShowArray (array);
        Console.Write (" -> ");
        ShowArray (resultArray);
    }
else
    {
        ShowArray (array);
        Console.Write ("-> []");
    }