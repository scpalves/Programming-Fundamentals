﻿namespace Elevator
{
    using System;

    public class Elevator
    {
        public static void Main()
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int numberOfCourses = (int)Math.Ceiling((double)numberOfPeople / capacity);

            Console.WriteLine(numberOfCourses);
        }
    }
}

