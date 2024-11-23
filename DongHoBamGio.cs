using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] arr = new int[100000];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1,100000);
            }
            StopWatch stopwatch = new StopWatch();
            stopwatch.Start();
            SelectionSort(arr);
            stopwatch.Stop();
            stopwatch.TinhThoiGian();
            Console.WriteLine($"thoi gian thuc thi het: {stopwatch.TinhThoiGian()} ms");

        }
        static void SelectionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                // Hoán đổi phần tử nhỏ nhất với phần tử đầu tiên
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }

        }
        public class StopWatch
    {
        private DateTime startTime;
        private DateTime endTime;
        public StopWatch() {
        
            startTime = DateTime.Now;
        }
        public void Start()
        {
           startTime = DateTime.Now;
        }
        public void Stop()
        {
            endTime = DateTime.Now;
        }
        public DateTime GetStartTime() { return startTime; }
        public DateTime GetEndTime() { return endTime; }
        public double TinhThoiGian()
        {
            return(endTime - startTime).TotalMilliseconds;
        }

    }
}
