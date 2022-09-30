Console.Clear();
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);

int[] new_array = create_array();
print_array(new_array);
Console.WriteLine($"Сумма элементов на нечетных позициях равна: {sum_odd_pozition_numbers(new_array)}.");

int sum_odd_pozition_numbers(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
        sum += array[i];
    return sum;
}

void print_array(int[] x)
{
    int[] new_array = x;
    for (int i = 0; i < new_array.Length; i++)
        Console.Write($"{new_array[i]} ");
}

int[] create_array()
{
    int[] new_array = new int[size];
    Random randGenerator = new Random();
    for (int i = 0; i < size; i++)
    {
        new_array[i] = randGenerator.Next(0, 1000);
    }
    return(new_array);
}