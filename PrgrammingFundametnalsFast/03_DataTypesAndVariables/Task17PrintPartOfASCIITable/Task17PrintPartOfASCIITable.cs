﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Task17PrintPartOfASCIITable
    {
        static void Main(string[] args)
        {

        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        for (int i = firstNumber; i <= secondNumber; i++)
        {
            Console.Write(Convert.ToChar(i)+" ");
        }
        Console.WriteLine();
    }
}

