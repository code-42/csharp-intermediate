﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Exercise: Design a Stack

A Stack is a data structure for storing a list of elements in a LIFO (last in, first out) fashion.

Design a class called Stack with three methods.
void Push(object obj)
object Pop()
void Clear()

The Push() method stores the given object on top of the stack. We use the “object” type here so
we can store any objects inside the stack. Remember the “object” class is the base of all classes
in the .NET Framework. So any types can be automatically upcast to the object. Make sure to
take into account the scenario that null is passed to this object. We should not store null
references in the stack. So if null is passed to this method, you should throw an
InvalidOperationException. Remember, when coding every method, you should think of all
possibilities and make sure the method behaves properly in all these edge cases. That’s what
distinguishes you from an “average” programmer.

The Pop() method removes the object on top of the stack and returns it. Make sure to take into
account the scenario that we call the Pop() method on an empty stack. In this case, this method
should throw an InvalidOperationException. Remember, your classes should always be in a valid
state and used properly. When they are misused, they should throw exceptions. Again, thinking
of all these edge cases, separates you from an average programmer. The code written this way
will be more robust and with less bugs.

The Clear() method removes all objects from the stack.

We should be able to use this stack class as follows:
var stack = new Stack();
stack.Push(1);
stack.Push(2);
stack.Push(3);

Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());

The output of this program will be
3
2
1

Note: The downside of using the object class here is that if we store value types (eg int, char,
bool, DateTime) in our Stack, boxing and unboxing occurs, which comes with a small
performance penalty. In my C# Advanced course, I’ll teach you how to resolve this by using
generics, but for now don’t worry about it. 
// Then why did he talk about it in Lecture 24 - Boxing and Unboxing
*/

namespace Lecture_26___Exercise___Design_a_Stack
{
    class Stack
    {
        private object _stack { get; set; }

        public Stack()
        {
            Console.WriteLine("Inside Stack ctor");
        }

        public void Push(object obj)
        {
            // if null is passed to this method
            // throw InvalidOperationException
            _stack = obj;
            if (_stack != null)
            {
                Console.WriteLine("75. " + _stack);
            }
        }

        public object Pop()
        {
            // Removes the object from top of stack and returns it
            // if Pop() is called on empty stack,
            // throw InvalidOperationException
            try
            {
                Console.WriteLine(_stack.ToString());
            }
            catch
            {
                Console.WriteLine("OOPs");
            }
            return 0;
        }

        void Clear()
        {
            // Removes all objects from the stack
            
        }

        //public override string ToString()
        //{
        //    // Prevents printing namespace.classname
        //    return (string)this._stack;
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push("Ed");
            stack.Push(DateTime.Now);

            //Console.WriteLine(stack.Push("Waldo!"));

            // throws error
            //foreach (object Obj in stack)
            //{
            //    Console.WriteLine(Obj);
            //}

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
        }
    }
}
