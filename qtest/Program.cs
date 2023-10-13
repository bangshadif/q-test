using System; 
using System.Collections;

namespace qtest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Triangle
            int side1 = Convert.ToInt32(Console.ReadLine());
            int side2 = Convert.ToInt32(Console.ReadLine());
            int side3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Triangle(side1, side2, side3));

            // Fibonacci
            int fiboNum = Convert.ToInt32(Console.ReadLine());
            Fibonacci(fiboNum);

            // Queue
            /*
            Queue could be used in loading container in port, queue will ensure the first container
            arrive will be processed immediately before the other
            */
            Queue shippingDock = new Queue();
            shippingDock.Enqueue("shippingContainer1"); 
            PrintQueue(shippingDock);
            shippingDock.Enqueue("shippingContainer2"); 
            PrintQueue(shippingDock);
            shippingDock.Enqueue("shippingContainer3"); 
            PrintQueue(shippingDock);
            shippingDock.Dequeue(); 
            PrintQueue(shippingDock);

            //Quick Sort
            var arr = new int[] {12, 46, 37, 29, 51};
            int s = 0;
            int e = arr.Length - 1;
            QuickSort(arr, s, e);
            Console.Write("Sorted Array: ");
            foreach (int elm in arr)
            {
                Console.Write(elm.ToString() + " ");
            }
        }

        static string Triangle(int s1, int s2, int s3)
        {
            if (s1 == s2 && s2 == s3)
            {
                return "equilateral";
            } else if (s1 == s2 || s2 == s3 || s1 == s3)
            {
                return "isoceles";
            } else return "scalene";
        }

        static void Fibonacci(int num)
        {
            int base1 = 0;
            int base2 = 1;
            Console.WriteLine("Fibonacci: ");
            for (int i = 0; i <= num; i++)
            {
                int fibo = base1 + base2;
                base1 = base2;
                base2 = fibo;
                Console.WriteLine(fibo);
            }
        }

        static void PrintQueue(Queue q)
        {
            Object[] arr = q.ToArray();
            foreach(Object obj in arr)
            {
                Console.Write(obj + " - ");
            }
            Console.WriteLine();
        }

        /*
        Quick Sort Time Complexity
        Best: O(n * log n)
        Avg: O(n * log n)
        Worst O(n^2)
        */
        static void QuickSort(int[] arr, int start, int end)
        {
            int i = start;
            int n = end;
            int pvt = arr[start];
            while (i <= n)
            {
                while(arr[n] > pvt)
                {
                    n--;
                }
                while(arr[i] < pvt)
                {
                    i++;
                }

                if (i <= n)
                {
                    int tmp = arr[i];
                    arr[i] = arr[n];
                    arr[n] = tmp;
                    i++;
                    n--;
                }

            }
            if (start < n)
            {
                QuickSort(arr, start, n);
            }
            if (i < end){
                QuickSort(arr, i, end);
            }
        }
    }
}
