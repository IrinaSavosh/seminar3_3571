// Написать метод для разворота массива, не используя память под дополнительный массив

int[] array = { 1, 6, 96, 12, -5, 4 };
void PrintArray(int[] array)
{
   int count = array.Length;
   for (int i = 0; i < count; i++)
   {
      Console.Write($"{array[i]} ");
   }
   Console.WriteLine();
}
Console.WriteLine("Пришлось воспользоваться информацией из третьей лекции, ");
Console.WriteLine("потому что не знаю, как выводить данные массива проще)))");
//int count = array.Length;
// Console.WriteLine(count);
void Rev(int[] array)
{
   int i = 0;
   int j = array.Length - 1;
   while (i < j)
   {
      int temp = array[i];
      array[i] = array[j];
      array[j] = temp;
      i++;
      j--;
   }
   
}

PrintArray(array);
Rev(array);
PrintArray(array);

