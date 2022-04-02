Console.Clear();
Console.WriteLine("Введите количество строк:" );
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:" );
int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [m,n];
void FillArray(int [,] mat){
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            mat[i,j] = new Random().Next(1,101);
        }
    }
}
void PrintArray(int [,] mat){
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{mat[i,j]} ");
        }
        Console.WriteLine();
    }
}
FillArray(matrix);
PrintArray(matrix);