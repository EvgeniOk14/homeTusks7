 void InputArray(int[,] matrix)
{
  for(int i = 0; i < matrix.GetLength(0); i++)
   {
     for(int j = 0; j < matrix.GetLength(1); j++)
     {
        matrix[i, j] = new Random().Next(0, 11);
        Console.Write($"{matrix[i, j]} \t");
     }
   Console.WriteLine();
   }
} 

void ReleaseArray(int[,] matrix, int a, int b)
{
        
         
                  for (int j = 0; j < matrix.GetLength(1); j++)
           {
             int Sum = 0;
             double mean = 0;
                for(int i = 0; i < matrix.GetLength(0); i++)
                {
                   Sum = Sum + matrix[i,j];
                   mean = Sum / matrix.GetLength(0);
                }
                   Console.WriteLine("сумма элементов " + j + " столбеца равна " + Sum);
                   Console.WriteLine("среднее арифметичесое " + j + " столбца равно: " + mean);
                   Console.WriteLine();
           }
                
              
}        
           

Console.Clear();
Console.WriteLine("Введите размеры массива: ");
int[] size = Console.ReadLine().Split(" ").Select(x=> int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
int a = size[0];
int b = size[1];
InputArray(matrix); 
ReleaseArray(matrix, a, b);

              
         
          
   
  

