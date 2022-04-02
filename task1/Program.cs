Console.Clear();
Console.WriteLine("Введите количество строк:" );
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:" );
int n = Convert.ToInt32(Console.ReadLine());
double [,] matrix = new double[m,n];
Random rand = new Random();
void FillArray(double [,] mat){
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            mat[i,j] = rand.NextDouble()*10;
        }
    }
}
void PrintArray(double [,] mat){
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