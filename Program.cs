string input;
float coins = 0;
float ParkingTime = 0;
float minutes = 0;
float hours = 0;
float amount = 0;
float money_temp = 0;
float money_temp2 = 0;
float temp = 0;

void PrintWelcome()
{
    System.Console.WriteLine("Hello! ");
}

void EnterCoins()
{
    do
    {
        System.Console.WriteLine("Put in 5(Cents), 10(Cents), 20(Cents), 50(Cents), 1(Euro), 2(Euro).");
        input = Console.ReadLine()!;

        switch (input)
        {
            case "5":
                coins += 0.05f;
                break;

            case "10":
                coins += 0.10f;
                break;

            case "20":
                coins += 0.20f;
                break;

            case "50":
                coins += 0.50f;
                break;

            case "1":
                coins += 1f;
                break;

            case "2":
                coins += 2f;
                break;

            case "d":
                if (amount < 0.5f)
                {
                    money_temp2 = amount * 100;
                    System.Console.WriteLine($"Min.Input 50 Cent, you put in: {money_temp2} Cent");
                }
                { money_temp = 0; }
                break;

            case "D":
                if (amount < 0.5f)
                {
                    money_temp2 = amount * 100;
                    System.Console.WriteLine($"Min.Input 50 Cent, you put in: {money_temp2} Cent ");
                }
                { money_temp = 0; }
                break;

            default:
                System.Console.WriteLine("wrong input");
                temp = 1;
                break;
        }
    }
    while (temp == 1);
}

void AddParkingTime()
{
    if (coins == 2)
    { hours += 2; }

    if (coins == 1)
    { hours += 1; }

    if (coins == 0.50f)
    { minutes += 30; }

    if (coins == 0.20f)
    { minutes += 12; }

    if (coins == 0.10f)
    { minutes += 6; }

    if (coins == 0.05f)
    { minutes += 3; }

    if (minutes >= 60)
    {
        hours++;
        minutes -= 60;
    }
}

void PrintParkingTime()
{
    System.Console.WriteLine($"your ParkingTime is: {hours}:{minutes : 00}");
}

void PrintDonation()
{
    float donation = ParkingTime - money_temp;
    if (ParkingTime < money_temp)
    {
        System.Console.WriteLine($"Donation: {donation}");
    }
}

PrintWelcome();
EnterCoins();
AddParkingTime();
PrintParkingTime();
PrintDonation();