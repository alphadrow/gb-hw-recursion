// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

// Console.Clear();
// int m = 5;
// int n = 5;

// Console.WriteLine(rec(m, n));

// string rec(int m, int n)
// {
//     if (n < m)
//     {
//         return rec(n, m);
//     }
//     if (n > m)
//     {
//         if (n == m)
//             return $"{n}";
//         return rec(m, n - 1) + $" {n}";
//     }
//     else
//     {
//         return "" + n;
//     }

// }

// -------------------------------------------------------------------------------------
// Задача 2: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.

// Console.Clear();
// int n = 2;
// int m = 3;

// Console.WriteLine(recAckermann(m, n));

// int recAckermann(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0)
//     {
//         return recAckermann(m - 1, 1);
//     }
//     else 
//     {
//         return recAckermann(m - 1, recAckermann(m, n -1));
//     }
// }


// -------------------------------------------------------------------------------------
// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

// Console.Clear();

// int[] array = { 1, 4, 6, 12, 89, 34, 56, 21};
// Console.WriteLine(recPrint(array, 0));

// string recPrint(int[] arr, int pos)
// {
//     if (pos == arr.Length)
//     {
//         return "";
//     }
//     return recPrint(arr, pos + 1) + $" {arr[pos]}" ;
// }