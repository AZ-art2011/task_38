// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// task 38
void FillArrayRandomNumbers(double[] nums)
{
    for(int i = 0; i < nums.Length; i++)
        {
            nums[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
        }
}

Console.Clear();
Console.WriteLine("Укажите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] nums = new double[size];
FillArrayRandomNumbers(nums);
Console.WriteLine($" [ {String.Join(" ", nums)}]");
double min = 1000;
double max = -1;

for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] > max)
        {
            max = nums[i];
        }
    if (nums[i] < min)
        {
            min = nums[i];
        }
}

Console.WriteLine($"Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разность max-min значений = {max - min}");