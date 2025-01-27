using System;

namespace Arrays
{
    class MyArrays
    {
        public void EnterAndDisplayNumbers()
        {
            int[] numbers = new int[3];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter num: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Numbers entered:");
            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }

        public void CalculateSumOfAngles()
        {
            const int angleCount = 3;
            int[] angles = new int[angleCount];

            for (int i = 0; i < angles.Length; i++)
            {
                Console.Write($"Enter Angle {i + 1}: ");
                angles[i] = Convert.ToInt32(Console.ReadLine());
            }

            int angleSum = 0;
            foreach (int angle in angles)
            {
                angleSum += angle;
            }

            Console.WriteLine($"\nSum of angles: {angleSum}");
        }

        public void SortAndReverseArray()
        {
            int[] nums = new int[] { 1, 2, 3, 20, 5, 40, 0, 8 };
            Array.Sort(nums);

            Console.WriteLine("Sorted array:");
            foreach (int num in nums)
            {
                Console.Write($"{num} ");
            }

            Array.Reverse(nums);
            Console.WriteLine("\nReversed array:");
            foreach (int num in nums)
            {
                Console.Write($"{num} ");
            }

            Console.WriteLine();
            Console.Write("Do you want to clear the array? true or false: ");
            bool userChoice = Convert.ToBoolean(Console.ReadLine());

            if (userChoice)
            {
                Array.Clear(nums, 0, nums.Length);

                Console.WriteLine("\nArray after clearing:");
                foreach (int num in nums)
                {
                    Console.Write($"{num} ");
                }
                Console.WriteLine();
            }
        }

        public void FindIndicesInArray()
        {
            int[] idxArr = new int[] { 30, 40, 1, 4556, 5, -6, 0 };

            foreach (int idx in idxArr)
            {
                int idxOfArr = Array.IndexOf(idxArr, idx);
                Console.WriteLine($"Index of num {idx}: {idxOfArr}");
            }
        }
    }


    class Menu
    {
        public void ShowMenu()
        {
            MyArrays arrays = new MyArrays();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Enter and display numbers");
            Console.WriteLine("2. Calculate sum of angles");
            Console.WriteLine("3. Sort and reverse an array");
            Console.WriteLine("4. Find indices in an array");
            Console.WriteLine("5. Exit");

            while (true)
            {
                Console.Write("\nEnter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        arrays.EnterAndDisplayNumbers();
                        break;
                    case 2:
                        arrays.CalculateSumOfAngles();
                        break;
                    case 3:
                        arrays.SortAndReverseArray();
                        break;
                    case 4:
                        arrays.FindIndicesInArray();
                        break;
                    case 5:
                        Console.WriteLine("Exiting program. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }

    class Tester
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.ShowMenu();
        }
    }
}
