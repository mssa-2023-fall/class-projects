using System;
using ASync_Await;
using File_Hasher;
using SmartFiles;
using System.Diagnostics;

namespace project2
{
    class Program
    {
        static void Main(string[] args)
        {
            var runningASync = new WeekendTasks();
            runningASync.WeekendTasks1();
            Console.ReadLine();
        }
    }
}