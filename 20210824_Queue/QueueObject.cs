using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210824_Queue
{
    class QueueObject : IQueue, IEnumerable
    {
        private const int INCREMENT = 5;
        private int _size = 5;
        private int _firstData = 0;
        private int _endData = -1;
        private int _countObject;
        private object[] _data;

        public QueueObject(int sizeQueue)
        {
            _data = new object[sizeQueue];
        }

        public void Put(object data)           
        {
            if(_countObject == _size)
            {
                object[] newArray = new object[_data.Length + INCREMENT];

                Array.Copy(_data, _firstData, newArray, 0, _data.Length - _firstData);
                Array.Copy(_data, 0, newArray, _data.Length - _firstData, _firstData);

                _data = newArray;
                _size += INCREMENT;
                _firstData = 0;
                _endData = _data.Length - INCREMENT - 1;
                //_size += INCREMENT;
                //Array.Resize(ref _data, _size);

                //for (int i = 0; i < _countObject; i++)
                //{
                //    if (_firstData + i + INCREMENT < _data.Length)
                //    {
                //        _data[_firstData + i + INCREMENT] = _data[_firstData + i];
                //        _data[_firstData + i] = null;
                //    }
                //    else
                //    {
                //        i = 0;
                //    }
                //}
                //_firstData += INCREMENT;
                //_endData += INCREMENT;
                /*for (int i = _firstData; i + INCREMENT < _data.Length; i++)
                {
                    _data[i + INCREMENT] = _data[i];
                    _data[i] = null;
                }
                _firstData += INCREMENT;*/
            }

            if(_endData == _size - 1)
            {
                _endData = -1;
            }

            _endData++;
            _data[_endData] = data;
            _countObject++;
        }

        public object GetData()
        {
            if(_countObject == 0)
            {
                throw new Exception(); //TODO: создать собственное исключение
            }

            object data = _data[_firstData];
            _data[_firstData] = null;
            _firstData++;
            _countObject--;

            if (_firstData == _size)
            {
                _firstData = 0;
            }

            return data;
        }

        public IEnumerator GetEnumerator()
        {
            return new QueueEnumerator(_data, _firstData, _endData);
        }

        /*public object this[int index]
        {
            get
            {
                return _data[index];
            }
            set
            {
                _data[index] = value;
            }
        }*/
    }
}
