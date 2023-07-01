// напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
    {
        Console.Write("введите число:");
        var n = Convert.ToInt32(Console.ReadLine());
        var sum = 0;
        while(n > 0)
        {
            sum += n % 10;
            n /= 10;
        }
        Console.WriteLine(sum);
    }