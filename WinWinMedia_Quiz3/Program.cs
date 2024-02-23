int[] numbers = new int[10];
Console.WriteLine("請輸入10個不重複的數值：");
for (int i = 0; i < 10; i++)
{
    int num;
    bool isValidInput = false;
    do
    {
        Console.Write($"輸入第{i + 1}個數值：");
        string input = Console.ReadLine();
        isValidInput = int.TryParse(input, out num) && !Array.Exists(numbers, element => element == num);
        if (!isValidInput)
        {
            Console.WriteLine("輸入不合法或數值已存在，請重新輸入。");
        }
    } while (!isValidInput);

    numbers[i] = num;
}

Array.Sort(numbers);
Array.Reverse(numbers);

Console.WriteLine("排序後的數值（從大到小）：");
foreach (var num in numbers)
{
    Console.Write(num + " ");
}