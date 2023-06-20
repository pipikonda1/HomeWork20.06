Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        int absNumber = Math.Abs(number);

        int numDigits = (int)Math.Floor(Math.Log10(absNumber) + 1);

        if (numDigits >= 3)
        {
            int thirdDigit = (absNumber / 100) % 10;
            Console.WriteLine($"Третья цифра числа {number} равна {thirdDigit}");
        }
        else
        {
            Console.WriteLine($"В числе {number} меньше трех цифр");
        }