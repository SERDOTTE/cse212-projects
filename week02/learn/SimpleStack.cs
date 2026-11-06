using System;
using System.Collections.Generic;

Console.WriteLine("\n======================\nSimple Stack\n======================");

var stack = new Stack<int>();
stack.Push(1);      // Push 1 onto the stack
stack.Push(2);      // Push 2 - 1, 2 onto the stack
stack.Push(3);      // Push 3 - 1, 2, 3 onto the stack
stack.Pop();        // Pop 3 - 1, 2 onto the stack
stack.Pop();        // Pop 2 - 1 onto the stack
stack.Push(4);      // Push 4 - 1, 4 onto the stack
stack.Push(5);      // Push 5 - 1, 4, 5 onto the stack
stack.Pop();        // Pop 5 - 1, 4 onto the stack
stack.Push(6);      // Push 6 - 1, 4, 6 onto the stack
stack.Push(7);      // Push 7 - 1, 4, 6, 7 onto the stack
stack.Push(8);      // Push 8 - 1, 4, 6, 7, 8 onto the stack
stack.Push(9);      // Push 9 - 1, 4, 6, 7, 8, 9 onto the stack
stack.Pop();        // Pop 9 - 1, 4, 6, 7, 8 onto the stack
stack.Pop();        // Pop 8 - 1, 4, 6, 7 onto the stack
stack.Push(10);      // Push 10 - 1, 4, 6, 7, 10 onto the stack
stack.Pop();        // Pop 10 - 1, 4, 6, 7 onto the stack
stack.Pop();        // Pop 7 - 1, 4, 6 onto the stack
stack.Pop();        // Pop 6 - 1, 4 onto the stack
stack.Push(11);      // Push 11 - 1, 4, 11 onto the stack
stack.Push(12);      // Push 12 - 1, 4, 11, 12 onto the stack
stack.Pop();        // Pop 12 - 1, 4, 11 onto the stack
stack.Pop();      // Pop 11 - 1, 4 onto the stack
stack.Pop();        // Pop 4 - 1 onto the stack
stack.Push(13);      // Push 13 - 1, 13 onto the stack
stack.Push(14);      // Push 14 - 1, 13, 14 onto the stack
stack.Push(15);      // Push 15 - 1, 13, 14, 15 onto the stack
stack.Push(16);      // Push 16 - 1, 13, 14, 15, 16 onto the stack
stack.Pop();        // Pop 16 - 1, 13, 14, 15 onto the stack
stack.Pop();        // Pop 15 - 1, 13, 14 onto the stack
stack.Pop();        // Pop 14 - 1, 13 onto the stack
stack.Push(17);      // Push 17 - 1, 13, 17 onto the stack
stack.Push(18);      // Push 18 - 1, 13, 17, 18 onto the stack
stack.Pop();        // Pop 18 - 1, 13, 17 onto the stack
stack.Push(19);      // Push 19 - 1, 13, 17, 19 onto the stack
stack.Push(20);      // Push 20 - 1, 13, 17, 19, 20 onto the stack
stack.Pop();        // Pop 20 - 1, 13, 17, 19 onto the stack
stack.Pop();        // Pop 19 - 1, 13, 17 onto the stack

Console.WriteLine("Final contents:");
Console.WriteLine(String.Join(", ", stack.ToArray()));