using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210824_Queue
{
    class QueueException : Exception
    {
        public QueueException()
        {

        }

        public QueueException(string message)
            : base(message)
        {

        }

        public QueueException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
