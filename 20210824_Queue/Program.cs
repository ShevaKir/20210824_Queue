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
            int data11 = 122;
            int data12 = 133;
            int data13 = 144;
            int data14 = 155;
            int data15 = 166;
            int data16 = 177;
            int data17 = 188;
            int data18 = 199;

            queue.Put(data1);
            queue.Put(data2);
            queue.Put(data3);
            queue.Put(data4);
            queue.Put(data5);
            queue.Put(data6);
            queue.Put(data7);
            queue.Put(data8);
            queue.Put(data9);
            queue.Put(data10);
            queue.Put(data11);

            var dataGet1 = queue.GetData();
            var dataGet2 = queue.GetData();

            queue.Put(data12);
            queue.Put(data13);
            queue.Put(data14);
            queue.Put(data15);
            queue.Put(data16);
            queue.Put(data17);
            queue.Put(data18);
            foreach (object item in queue)
            {
                Console.WriteLine("{0}", item);
            }
            


            Console.ReadLine();
        }
    }
}
