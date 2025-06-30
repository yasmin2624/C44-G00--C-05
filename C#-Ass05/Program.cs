namespace C__Ass05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01-Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //Console.WriteLine("Enter integer : ");
            //bool isValid = int.TryParse(Console.ReadLine(), out int number);
            //if (isValid && number > 0)
            //{
            //    Console.WriteLine($"Numbers from 1 to {number} are:");
            //    for (int i = 1; i <= number; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a positive integer.");
            //}   
            #endregion

            #region Q02-Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            //Console.WriteLine("Enter integer to print  a multiplication table : ");
            //bool isValid = int.TryParse(Console.ReadLine(), out int number);
            //if (isValid)
            //{
            //    for (int i = 1; i <= 12; i++)
            //    {
            //        Console.WriteLine($"{number} x {i} = {number * i}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //}

            #endregion

            #region Q03-Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //Console.WriteLine("Enter integer : ");
            //bool isValid = int.TryParse(Console.ReadLine(), out int number);
            //if (isValid && number > 0)
            //{
            //    Console.WriteLine($"Numbers from 1 to {number} are:");
            //    for (int i = 1; i <= number; i++)
            //    {
            //        if(i%2 ==0)
            //        {
            //            Console.WriteLine(i);
            //        }

            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a positive integer.");
            //}
            #endregion

            #region Q06-Write a program to allow the user to enter a string and print the REVERSE of it.
            //Console.Write("Enter a string: ");
            //string? input = Console.ReadLine();
            //Console.WriteLine();
            //Console.Write("Reversed string: ");
            //for (int i = input.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(input[i]);
            //}


            #endregion

            #region Q07-Write a program to allow the user to enter int and print the REVERSED of it.
            //Console.Write("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine());

            //int reversed = 0;

            //while (number != 0)
            //{
            //    int digit = number % 10;            
            //    reversed = reversed * 10 + digit;   
            //    number /= 10;                      
            //}

            //Console.WriteLine($"Reversed number: {reversed}");
            #endregion

            #region Q08-    Write a program in C# Sharp to find prime numbers within a range of numbers.
            //Console.Write("Input starting number of range: ");
            //int? start = int.Parse(Console.ReadLine());

            //Console.Write("Input ending number of range: ");
            //int? end = int.Parse(Console.ReadLine());

            //Console.WriteLine($"The prime number between {start} and {end}");
            //for (int i = start.Value; i <= end.Value; i++)
            //{

            //}
            #endregion

            #region Q09-Write a program in C# Sharp to convert a decimal number into binary without using an array.
            //Console.Write("Enter a number to convert: ");
            //int number = int.Parse(Console.ReadLine());

            //string binary = "";

            //if (number == 0)
            //{
            //    binary = "0";
            //}
            //else
            //{
            //    while (number > 0)
            //    {
            //        int remainder = number % 2; 
            //        binary = remainder + binary;        
            //        number = number / 2;              
            //    }
            //}

            //Console.WriteLine($"The Binary  is {binary}");
            #endregion

            #region Q11-Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n

            //Console.Write("Enter the size of identity matrix (n): ");
            //int n = int.Parse(Console.ReadLine());

            //for (int row = 0; row < n; row++)
            //{
            //    for (int col = 0; col < n; col++)
            //    {
            //        if (row == col)
            //            Console.Write("1 ");
            //        else
            //            Console.Write("0 ");
            //    }
            //    Console.WriteLine(); 
            //}
            #endregion

            #region Q12-Write a program in C# Sharp to find the sum of all elements of the array.
            //int[] arr1 = { 1, 2, 3, 4, 5 };
            //int sum = 0;
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    sum += arr1[i];
            //}
            //Console.WriteLine($"Sum of number = {sum}");
            #endregion

            #region Q13-Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //int[] arr1 = { 1, 5, 9 };
            //int[] arr2 = { 2, 4, 8 };

            //int[] merged = new int[arr1.Length + arr2.Length];

            //Array.Copy(arr1, 0, merged, 0, arr1.Length);
            //Array.Copy(arr2, 0, merged, arr1.Length, arr2.Length);

            //Array.Sort(merged);

            //Console.WriteLine("Merged and sorted array:");
            //foreach (int num in merged)
            //{
            //    Console.Write(num + " ");
            //}
            #endregion

            #region Q14-Write a program in C# Sharp to count the frequency of each element of an array.
            //int[] arr = { 1, 2, 2, 3, 1, 4, 2 };
            //bool[] visited = new bool[arr.Length];

            //Console.WriteLine("Element frequencies:");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (visited[i])
            //        continue; 
            //    int count = 1;

            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            count++;
            //            visited[j] = true;
            //        }
            //    }

            //    Console.WriteLine($"Element {arr[i]} is {count} times");
            //}
            #endregion

            #region Q15-Write a program in C# Sharp to find maximum and minimum element in an array
            //    int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };

            //    int max = arr[0];
            //    int min = arr[0];
            //    for (int i = 1; i < arr.Length; i++)
            //    {
            //        if (arr[i] > max)
            //            max = arr[i];

            //        if (arr[i] < min)
            //            min = arr[i];
            //    }

            //    Console.WriteLine($"Maximum element = {max}");
            //    Console.WriteLine($"Minimum element = {min}");
            //}
            #endregion

            #region Q16-Write a program in C# Sharp to find the second largest element in an array.

            //int[] arr = { 10, 40, 20, 70, 50 };
            //Array.Sort(arr);
            //int secondLargest = arr[arr.Length - 2];
            //Console.WriteLine($"the second largest element is {secondLargest}");

            #endregion

            #region Q17


            #endregion

            #region Q18-Given a list of space separated words, reverse the order of the words
            //Console.Write("Enter a sentence: ");
            //string input = Console.ReadLine();
            //string[] words = input.Split(' ');

            //for (int i = words.Length - 1; i >= 0; i--)
            //{
            //    Console.Write($"{words[i]} ");

            //}

            #endregion

            #region Q19


            #endregion

            #region Q20-Write a Program to Print One Dimensional Array in Reverse Order
            //int[] arr = { 10, 20, 30, 40, 50 };

            //Console.WriteLine("Array in reverse order:");

            //for (int i = arr.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(arr[i] + " ");
            //}

            //Console.WriteLine();

            #endregion


        }
    }
}
