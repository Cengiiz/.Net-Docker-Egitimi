﻿// See https://aka.ms/new-console-template for more information
int i = 0;

while (i<10000)
{
    Console.WriteLine("Hello, World!"+i);

    i++;
    System.Threading.Thread.Sleep(1000);
}
