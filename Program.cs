// Задача:
// Написать программу, которая из имеющегося массива строк формирует массив строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.


string[] array1 = new string[]{"hello", "2", "world", ":-)"};
PrintArray(array1);
string[] array2 = new string[array1.Length];
GetArray(array1, array2);
Console.Write("-> ");
PrintArray(array2);
//----------Methods----------
void PrintArray(string[] array){
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
void GetArray(string[] array1, string[] array2){
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if(array1[i].Length <= 3){
            array2[count] = array1[i];
            count++;
        }
    }
}