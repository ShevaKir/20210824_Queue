using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210824_Queue
{
    interface IQueue
    {
        void Put(object data);
        object GetData();
    }
}
