Console.Clear();
Console.WriteLine("Введите количество строк:" );
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:" );
int k = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [n,k];
bool find = false;
void FillArray(int [,] mat)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < k; j++)
        {
            mat[i,j] = new Random().Next(1,101);
        }
    }
}
void PrintArray(int [,] mat)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < k; j++)
        {
            Console.Write($"{mat[i,j]} ");
        }

        Console.WriteLine();
    }
}
void Findnumb (int [,] mat, int chtoto)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < k; j++)
        {
            if (mat[i, j] == chtoto)
            {
                Console.WriteLine($"{i+1}, {j+1}");
                find = true;
            }
        }
    }
    if (find == false) {Console.WriteLine("Ошибка. Такого числа нет в матрице");}
}
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine("Введите нужное число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Число находится по адресу: ");
Findnumb(matrix, num);