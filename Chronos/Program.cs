using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();
            crono1.Start();
            Thread.Sleep(600);
            crono2.Start();
            Thread.Sleep(200);
            crono1.Stop();
            crono2.Stop();
            float elapsedSeconds1 = (float)crono1.ElapsedMilliseconds/10000;
            float elapsedSeconds2 = (float)crono2.ElapsedMilliseconds/1000;
            Console.WriteLine(elapsedSeconds1.ToString("0.000"));
            Console.WriteLine(elapsedSeconds2.ToString("0.000"));
        }
    }
}
