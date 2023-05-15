using System;

namespace WaterTankProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Accepting user inputs
            Console.Write("Enter the capacity of the water tank (in liters): ");
            double tankCapacity = double.Parse(Console.ReadLine());

            Console.Write("Enter the average volume of water that participants drank during each break (in liters): ");
            double avgVolumePerBreak = double.Parse(Console.ReadLine());

            Console.Write("Enter the volume of water that can be added in each water-filling cycle (in liters): ");
            double volumePerFillingCycle = double.Parse(Console.ReadLine());

            Console.Write("Enter the interval between rest periods (in hours): ");
            int breakInterval = int.Parse(Console.ReadLine());

            Console.Write("Enter the interval between filling cycles (in hours): ");
            int fillingInterval = int.Parse(Console.ReadLine());

            Console.Write("Enter the total duration of the activity from start to finish of the day (in hours): ");
            int totalDuration = int.Parse(Console.ReadLine());

            // Initializing variables
            double remainingWater = tankCapacity;
            bool isEnoughWater = true;
            bool isOverflowing = false;

            // Checking if there is enough water throughout the project
            for (int i = 0; i < totalDuration; i++)
            {
                if (i % breakInterval == 0)
                {
                    remainingWater -= avgVolumePerBreak;
                }

                if (i % fillingInterval == 0)
                {
                    remainingWater += volumePerFillingCycle;

                    if (remainingWater > tankCapacity)
                    {
                        isOverflowing = true;
                        break;
                    }
                }

                if (remainingWater < 0)
                {
                    isEnoughWater = false;
                    break;
                }
            }

            // Displaying results
            if (isOverflowing)
            {
                Console.WriteLine("Overflow Water");
            }

            if (isEnoughWater && !isOverflowing)
            {
                Console.WriteLine($"Enough Water, {remainingWater} liters left");
            }

            if (!isEnoughWater)
            {
                Console.WriteLine("Not Enough Water");
            }

            Console.ReadLine();
             static void Main(string[] args)
    {
        const int NUM_BALANCES = 3;
        double[] balances = new double[NUM_BALANCES];
        for (int i = 0; i < NUM_BALANCES; i++)
        {
            Console.Write($"Enter balance {i + 1}: ");
            balances[i] = double.Parse(Console.ReadLine());
        }

        double left = 0;
        while (true)
        {
            Console.Write("Enter payment amount (negative or zero to end): ");
            double payment = double.Parse(Console.ReadLine());
            if (payment <= 0)
            {
                break;
            }

            bool paid = false;
            for (int i = 0; i < NUM_BALANCES; i++)
            {
                if (balances[i] >= payment)
                {
                    balances[i] -= payment;
                    paid = true;
                    break;
                }
            }

            if (!paid)
            {
                left += payment;
            }
        }

        Console.WriteLine($"Balance 1: {balances[0]}, Balance 2: {balances[1]}, Balance 3: {balances[2]}");
        if (left > 0)
        {
            Console.WriteLine($"Left: {left}");
        }

        Console.ReadLine();
    }
}
        }
    }
}