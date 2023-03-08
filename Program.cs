    Console.WriteLine("Pick a number between 0 and 6");
    int day = int.Parse(Console.ReadLine());
    
    switch (day)
    {
        case 0:
            Console.WriteLine("Sunday");
            break;
        case 1:
            Console.WriteLine("Monday");
            break;
        case 2:
            Console.WriteLine("Tuesday");
            break;
        case 3:
            Console.WriteLine("Wednesday");
            break;
        case 4:
            Console.WriteLine("Thursday");
            break;
        case 5:
            Console.WriteLine("Friday");
            break;
        case 6:
            Console.WriteLine("Saturday");
            break;
        default:
            Console.WriteLine("You didn't pick a number between \'0 and 6\'");
        break;

    }
