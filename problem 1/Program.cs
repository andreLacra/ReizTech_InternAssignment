﻿namespace problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            // problem 1 
            double sampleTest1 = angleHourMinute(11, 15);  //angleHourMinute(hour, minute)
            Console.WriteLine("{0} Degrees.", sampleTest1);
        }

        // problem 1
        static double angleHourMinute(int hour, int minute)
        {
            // the difference between HOUR ARROW and MINUTE ARROW
            double differenceHourMinute = ((hour * 30 + minute * 0.5) - (minute * 6));
            return (360 - differenceHourMinute);  // return final answer
        }
    }
}