// Задача № 54
// Создаем двухмерный рандомный массив

int[,] SetArray(int rows, int columns, int min, int max)
{
   var array = new int[rows, columns];
   var rnd = new Random();

   for (int i = 0; i < rows; i++)
   {
      for (int j = 0; j < columns; j++)
      {
         array[i, j] = rnd.Next(min, max + 1);
      }
   }
   return array;
}

// ## Выводим двухмерный рандомный массив

void PrintMatrixTwoDimensional(int[,] matrixTwoDimensional)
{
   for (int i = 0; i < matrixTwoDimensional.GetLength(0); i++)
   {
      Console.Write("[ ");
      for (int j = 0; j < matrixTwoDimensional.GetLength(1); j++)
      {
         if (matrixTwoDimensional[i, j] >= 0)
            Console.Write($" {matrixTwoDimensional[i, j]} ");
         else Console.Write($"{matrixTwoDimensional[i, j]} ");
      }
      Console.Write(" ]");
      Console.WriteLine();
   }
}


int[,] matr = SetArray(4, 4, 0, 10);

Console.WriteLine("Не отсортированный массив");
PrintMatrixTwoDimensional(matr);
Console.WriteLine();


void SotrArray(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         for (int a = 0; a < array.GetLength(1) - 1; a++)
         {
            if (array[i, a] < array[i, a + 1])
            {
               int temp = array[i, a + 1];
               array[i, a + 1] = array[i, a];
               array[i, a] = temp;
            }
         }
      }
   }
}

SotrArray(matr);
Console.WriteLine(" Отсортированный массив");
PrintMatrixTwoDimensional(matr);