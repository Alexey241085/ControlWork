
string[] array1 = new string[] { "ascd", "13", "35", "):", "web","1111" };
string[] array2 = new string[array1.Length];

void OutputArray (string[] array1, string[] array2) 
{
  int N = 3;
  int k = 0;
  for (int i = 0; i < array1.Length; i++) 
  {
    if (array1[i].Length <= N)
    {
      array2[k] = array1[i];
      k++;          
    }
    
  }
   
}

void PrintArray2(string[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write($"{array[j]} ");
    }
    Console.WriteLine();

}



Console.Clear();
OutputArray(array1, array2);
// Вывод без запятых
PrintArray2(array2);
Console.WriteLine();
// Вывод с запятыми, но получается что запятые по линне массива array1,
// и если пустые значения, запятая ставится, а значения нет)). В примере задачи, запятые есть... 
//как убрать не могу понять пока. Оставил 2 вывода и через метод и обычный.
Console.WriteLine(String.Join(" , ", array2));