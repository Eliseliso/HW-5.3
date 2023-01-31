Console.WriteLine("Введите размер массива : ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
RandomArray(numbers);
GetArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int index = 0; index < numbers.Length; index++)
{
    if (numbers[index] > max)
        {
            max = numbers[index];
        }
    if (numbers[index] < min)
        {
            min = numbers[index];
        }
}

Console.WriteLine($"Разница = {max - min}");

void RandomArray(double[] numbers)
{
    for(int index = 0; index < numbers.Length; index++)
        {
            numbers[index] = new Random().Next(1,100);
        }
}
void GetArray(double[] numbers)
{
    for(int index = 0; index < numbers.Length; index++)
        {
            Console.Write(numbers[index] + " ");
        }
    Console.WriteLine();
}
