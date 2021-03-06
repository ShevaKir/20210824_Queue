using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210824_Queue
{
    class QueueEnumerator : IEnumerator
    {
        private object[] _data;
        private int _first;
        private int _end;
        private bool firstElement = true;
        public QueueEnumerator(object[] data, int first, int end)
        {
            _data = data;
            _first = first;
            _end = end;
        }

        public object Current
        {
            get
            {
                //if (position == -1 || position >= _points.Length)
                //    throw new InvalidOperationException();

                return _data[_first];
            }
        }

        public bool MoveNext()
        {
            bool result = false;
            
            if (_first != _end)
            {
                _first++;
                if (_first > _data.Length - 1)
                {
                    _first = 0;
                }
                result = true;
            }
            if(firstElement)
            {
                result = true;
                firstElement = false;
                _first--;
            }
                       

            return result;
        }

        public void Reset()
        {
            _first = -1;
        }
    }
}
