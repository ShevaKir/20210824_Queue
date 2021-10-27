using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210824_Queue
{
    class CapacityLessThanOneException : QueueException
    {
        public CapacityLessThanOneException()
        {

        }

        public CapacityLessThanOneException(string message)
            : base(message)
        {

        }

        public CapacityLessThanOneException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
