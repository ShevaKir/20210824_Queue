using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210824_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueObject queue = new QueueObject(5);

            int data1 = 22;
            int data2 = 33;
            int data3 = 44;
            int data4 = 55;
            int data5 = 66;
            int data6 = 77;
            int data7 = 88;
            int data8 = 99;
            int data9 = 100;
            int data10 = 111;


            queue.Put(data1);
            queue.Put(data2);
            queue.Put(data3);
            queue.Put(data4);
            queue.Put(data5);
            var data22 = queue.GetData();
            var data33 = queue.GetData();
            var data44 = queue.GetData();
            foreach (object item in queue)
            {
                Console.WriteLine("{0}", item);
            }
            Console.WriteLine();
            queue.Put(data6);
            queue.Put(data7);
            foreach (object item in queue)
            {
                Console.WriteLine("{0}", item);
            }
            queue.Put(data8);

            foreach (object item in queue)
            {
                Console.WriteLine("{0}", item);
            }

            Console.WriteLine();
            queue.Put(data9);
            queue.Put(data10);
            var data55 = queue.GetData();
            var data66 = queue.GetData();
            var data77 = queue.GetData();

            foreach (object item in queue)
            {
                Console.WriteLine("{0}", item);
            }

            Console.ReadLine();
        }
    }
}
