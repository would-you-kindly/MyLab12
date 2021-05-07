namespace Custom.Collections.JavaStack
{
    public class CustomStack<T>
    {
        private int _capacity;
        private bool _isFixedSize;
        private T[] _stackArray;
        private int _top;

        public int Size
        {
            get
            {
                return _top + 1;
            }
        }

        public int Capacity
        {
            get
            {
                return _capacity;
            }
            set
            {
                if (value < _top + 1)
                    throw new ReallocateStackException(value, _top + 1);

                ReallocateArray(value);
            }
        }

        public bool IsFixedSize
        {
            get
            {
                return _isFixedSize;
            }
            set
            {
                _isFixedSize = value;
            }
        }

        public CustomStack()
        {
            _capacity = 32;
            _isFixedSize = true;
            _stackArray = new T[_capacity];
            _top = -1;
        }

        public CustomStack(int capacity)
        {
            _capacity = capacity;
            _isFixedSize = true;
            _stackArray = new T[capacity];
            _top = -1;
        }

        public CustomStack(int capacity, bool isFixedSize)
        {
            _capacity = capacity;
            _isFixedSize = isFixedSize;
            _stackArray = new T[capacity];
            _top = -1;
        }

        public void Push(T item)
        {
            if (!_isFixedSize && _top == _capacity - 1)
                ReallocateArray(_capacity * 2);

            if (_top == _capacity - 1)
                throw new StackIsFullException();

            _stackArray[++_top] = item;
        }

        public T Pop()
        {
            if (_top == -1)
                throw new StackIsEmptyException();

            return _stackArray[_top--];
        }

        public T Peek()
        {
            if (_top == -1)
                throw new StackIsEmptyException();

            return _stackArray[_top];
        }

        public bool IsEmpty()
        {
            return _top == -1;
        }

        public bool IsFull()
        {
            return _top == _capacity - 1;
        }

        public void ReallocateMemmory()
        {
            Capacity = Size;
        }

        private void ReallocateArray(int newCapacity)
        {
            T[] tempStackArray = new T[newCapacity];
            for (int i = 0; i < _top + 1; i++)
                tempStackArray[i] = _stackArray[i];
            _stackArray = tempStackArray;

            _capacity = newCapacity;
        }
    }
}
