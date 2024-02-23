QuizObject quiz = new();

int[] newArray = new int[quiz.array.Length + 1];

for (int i = 0, j = 0; i < newArray.Length; i++)
{
    if (i == quiz.index)
    {
        newArray[i] = quiz.e;
    }
    else
    {
        newArray[i] = quiz.array[j];
        j++;
    }
}

// 輸出新數組
Console.WriteLine($"新數組：{string.Join(",", newArray.Select(n => n.ToString()))}");

public class QuizObject
{
    public int[] array = { 1, 4, 3, 6, 9, 11, 8, 36 };
    public int index = 2;
    public int e = 23;
}