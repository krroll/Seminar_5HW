// Урок 5. Функции и одномерные массивы

// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

//  int [] array = new int [4];
//  int count = 0;
//     for (int i =0; i< array.Length; i++)
//     {
//         array[i] = new Random().Next(100,1000);
//         if (array[i] % 2 == 0)
//         {
//             count++;
//         }   
//     }
//     Console.WriteLine(String.Join(",",array));
//     Console.WriteLine ("количество чётных чисел в массиве= "+ count);

// -----------------------------------------------------------
// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

//  int [] array = new int [4];
//  int sum = 0;
//     for (int i =0; i< array.Length; i++)
//     {
//         array[i] = new Random().Next(-10,100);
//         if (array[i] % 2 != 0)
//         {
//             sum += array[i];
//         }   
//     }
//     Console.WriteLine(String.Join(",",array));
//     Console.WriteLine ("сумма элементов, стоящих на нечётных позициях= "+ sum);

// ------------------------------------------------------------
// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

 int [] array = new int [5];
 int result = 0;
 int max = 0;
 int min = 0;
    for (int i =0; i< array.Length; i++)
    {
       Console.Write("Введите [" + i + "] элемент: ");
       array[i]=Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("");
        if (array[i] > max)
        {
            max = array[i];
        }
        if (i==0)
        {
            min = array[0];
        }
        else if (array[i]<min)
        {
            min = array[i];
        }
        

    }
    Console.WriteLine(String.Join(",",array));
    Console.WriteLine ("max= "+ max);
    Console.WriteLine ("min= "+ min);