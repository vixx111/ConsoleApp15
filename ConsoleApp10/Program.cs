        int[] array = new int[16];
        Console.WriteLine("Введите 16 целых чисел:");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        int countOfReplacements = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 3 == 0)
            {
                array[i] = 0;
                countOfReplacements++;
            }
        }
        Console.WriteLine("Преобразованный массив:");
foreach (var item in array)
{
    Console.Write(item + " ");
}
        Console.WriteLine($"\nКоличество замен: {countOfReplacements}");
    