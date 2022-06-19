// Программа, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа

string[] arrayInput = new string[]{"hello", "2", "world", ":-)", "1234", "1567","-2"};
int size = lengthArray(arrayInput);
string[] newArray = new string [size];

FillArray(arrayInput, newArray, size);
WriteArray(arrayInput);
Console.WriteLine();
WriteArray(newArray);

int lengthArray(string[]array)
{
    int count = 0;
    int size = array.Length;
    for (int i = 0; i < size; i++)
        if (array[i].Length <= 3) count++;
    return count;
}
void FillArray (string []arrayInput, string[]newArray, int size)
{
    if (size > 0)
    {
        int index = 0;
        int length = arrayInput.Length;
        for (int j = 0; j < length; j++)
        {
            if (arrayInput[j].Length <= 3)
            {
                newArray[index] = arrayInput[j];
                index++;
            }
        }

    }
}
void WriteArray (string[]array)
{
  Console.Write('[');
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write('"');
    Console.Write($"{array[i]}");
    Console.Write('"');
    if (i != array.Length -1)
    {
        Console.Write(", ");
    }
  }
  Console.Write(']');
}