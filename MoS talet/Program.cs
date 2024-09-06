int[] numbers = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.Write("Skriv in ett tal :");
    numbers[i] = int.Parse(Console.ReadLine());
}

int min = numbers[0];
int max = numbers[0];

for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] < min)
    {
        min = numbers[i];
    }else if (numbers[i] > max) 
    { 
        max = numbers[i]; 
    }
}

Console.WriteLine("Minsta talet är " + min);
Console.WriteLine("Störst talet är " + max);

