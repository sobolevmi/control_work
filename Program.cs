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
        newArray [k] = anyArray [j];
        k++;
    }
    return newArray;
}