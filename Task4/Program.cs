﻿// Даны два положительных целых числа, представленных в виде строк. 
// Необходимо получить сумму чисел, которые представлены этими строками. 
// Причем полученная сумма должна быть преобразована в строку.
// Для решения этой задачи запрещено преобразовывать входные строки 
// сразу напрямую в целое число при помощи встроенной функции. 
// Необходимо сделать это самостоятельно.


Console.Write("num1=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("num2=");
            int b = int.Parse(Console.ReadLine());
            int с;
            с = a + b;
            Console.WriteLine(с);