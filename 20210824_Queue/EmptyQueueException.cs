using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210824_Queue
{
    class EmptyQueueException : QueueException
    {
        public EmptyQueueException()
        {

        }

        public EmptyQueueException(string message)
            : base(message)
        {

        }

        public EmptyQueueException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
