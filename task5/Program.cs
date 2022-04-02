Console.Clear();
Console.WriteLine("Введите количество строк:" );
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:" );
int k = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [n,k];
void FillArray(int [,] mat){
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < k; j++)
        {
            mat[i,j] = new Random().Next(1,101);
        }
    }
}
void PrintArray(int [,] mat){
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < k; j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                Console.Write($"{mat[i,j] * mat[i, j]} ");
            }
            else{
                Console.Write($"{mat[i,j]} ");
            }
        }
        Console.WriteLine();
    }
}
FillArray(matrix);
PrintArray(matrix);