﻿using Pet_Stack.Model;
using System;
using System.Collections.Generic;

namespace Pet_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            EasyStack<int> easyStack = new EasyStack<int>();

            easyStack.Push(1);
            easyStack.Push(2);
            easyStack.Push(3);
            easyStack.Push(4);
            easyStack.Push(5);

            var item = easyStack.Pop();
            var item2 = easyStack.Peek();

            Console.WriteLine(item);
            Console.WriteLine(item2);
            
            Console.ReadLine();

            //Stack<double> stack = new Stack<double>();


            var linkedStack = new LinkedStack<int>();

            linkedStack.Push(10);
            linkedStack.Push(20);
            linkedStack.Push(30);
            linkedStack.Push(40);
            linkedStack.Push(50);

            Console.WriteLine(linkedStack.Peek());
            Console.WriteLine(linkedStack.Pop());
            Console.WriteLine(linkedStack.Pop());
            Console.WriteLine(linkedStack.Peek());

            Console.ReadLine();



            var arrayStack = new ArrayStack<int>(5);
            arrayStack.Push(100);
            arrayStack.Push(200);
            arrayStack.Push(300);
            arrayStack.Push(400);
            arrayStack.Push(500);

            Console.WriteLine(arrayStack.Peek());
            Console.WriteLine(arrayStack.Pop());
            Console.WriteLine(arrayStack.Pop());
            Console.WriteLine(arrayStack.Pop());
            Console.WriteLine(arrayStack.Pop());
            Console.WriteLine(arrayStack.Pop());

            Console.ReadLine();
        }
    }
}
