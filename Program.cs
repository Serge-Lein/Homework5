// Task 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

//Version1:
// int[] GetFreeArrayWithoutRegistrationAndVerification(int lenArray)
// {
//     int[] freeArray = new int[lenArray];
// 	for (int i = 0; i < freeArray.Length; i++)
// 	{
// 		freeArray[i] = new Random().Next(100, 1000);
// 	}
// 	return freeArray;
// }

// int QuantityEvenNumInArray(int[] array)
// {
//     int result = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0) result++;
//     }
//     return result;
// }

// void PrintArray(int[] array)
// {
//     Console.Write("Your array: ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
        
//     }
//     Console.WriteLine();
// }

// Console.Write("Input the length of the array: ");
// int lenArray = Convert.ToInt32(Console.ReadLine());

// int[] array = GetFreeArrayWithoutRegistrationAndVerification(lenArray);

// PrintArray(array);
// Console.WriteLine($"The quantity even numbers in array: {QuantityEvenNumInArray(array)}");





// Version2:

// int[] GetFreeArrayWithoutRegistrationAndVerification(int lenArray)
// {
//     int[] freeArray = new int[lenArray];
// 	for (int i = 0; i < freeArray.Length; i++)
// 	{
// 		freeArray[i] = new Random().Next(100, 1000);
// 	}
// 	return freeArray;
// }

// void PrintArray(int[] array)
// {
//     Console.Write("Your array: ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
        
//     }
//     Console.WriteLine();
// }

// Console.Write("Input the length of the array: ");
// int lenArray = Convert.ToInt32(Console.ReadLine());

// int[] array = GetFreeArrayWithoutRegistrationAndVerification(lenArray);

// PrintArray(array);
// Console.WriteLine($"The quantity even numbers in array: {array.Where(x => x % 2 == 0).Count()}");







// Task 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int[] GetFreeArrayWithoutRegistrationAndVerification(int lenArray)
// {
//     int[] freeArray = new int[lenArray];
// 	for (int i = 0; i < freeArray.Length; i++)
// 	{
// 		freeArray[i] = new Random().Next(1, 1000);
// 	}
// 	return freeArray;
// }

// void PrintArray(int[] array)
// {
//     Console.Write("Your array: ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
        
//     }
//     Console.WriteLine();
// }

// int GetSumOfNumOnEvenPositionInArray(int[] array)
// {
//     int sum = 0;
//     for(int i = 1; i < array.Length; i+=2) sum += array[i];
//     return sum
// ;}

// Console.Write("Input the length of the array: ");
// int lenArray = Convert.ToInt32(Console.ReadLine());

// int [] array = GetFreeArrayWithoutRegistrationAndVerification(lenArray);

// PrintArray(array);
// System.Console.WriteLine($"The sum of numbers at an even position in array is equal {GetSumOfNumOnEvenPositionInArray(array)}");




// Task 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


// double a = Math.Round(new Random().NextDouble() + new Random().Next(0, 10), 2);
// System.Console.WriteLine(a);

// double[] GetArrayOfRealNum(int lenArray)
// {
//     double[] freeArray = new double[lenArray];
//     for (int i = 0; i < freeArray.Length; i++)
//     {
//         freeArray[i] = Math.Round(new Random().NextDouble() + new Random().Next(0, 10), 2);
//     }
//     return freeArray;
// }

// void PrintArray(double[] array)
// {
//     Console.Write("Your array: ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");

//     }
//     Console.WriteLine();
// }

// double GetDiffOfMinAndMaxInArray(double[] array)
// {
//     double min = double.MaxValue;
//     double max = double.MinValue;
//     for (int i = 0; i < array.Length; i++)
//     {
//         max = Math.Max(max, array[i]);
//         min = Math.Min(min, array[i]);
//     }
//     double diff = max - min;
//     return diff;
// }

// Console.Write("Input the length of the array: ");
// int lenArray = Convert.ToInt32(Console.ReadLine());

// double[] array = GetArrayOfRealNum(lenArray);

// PrintArray(array);
// Console.WriteLine($"The difference max and min numbers in array is equal {Math.Round(GetDiffOfMinAndMaxInArray(array), 2)}");