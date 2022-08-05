// Программа, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа
string [] CreateUserArray (int n)
{
    string [] userArray = new string [n];
    for (int index = 0; index < userArray.Length; index++)
    {
        Console.Write ("Введите элемент строкового массива: ");     // метод по заполнению первоначального массива с клавиатуры пользователем
        userArray [index] = Console.ReadLine ();
    }
    return userArray;
}
