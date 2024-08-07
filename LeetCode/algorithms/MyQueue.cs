// 232. Implement Queue using Stacks

namespace LeetCode.csharp_algorithms
{
    internal class MyQueue
    {
        private readonly Stack<int> _stack;
        private readonly Stack<int> _stackReversed;
        private const int Capacity = 9;

        public MyQueue()
        {
            _stack = new Stack<int>(Capacity);
            _stackReversed = new Stack<int>(Capacity);
        }

        public void Push(int x)
        {
            _stack.Push(x);
        }

        public int Pop()
        {
            if (_stackReversed.Count == 0)
            {
                while (_stack.Count != 0) _stackReversed.Push(_stack.Pop());
            }
            return _stackReversed.Pop();
        }

        public int Peek()
        {
            if (_stackReversed.Count == 0)
            {
                while (_stack.Count != 0) _stackReversed.Push(_stack.Pop());
            }
            return _stackReversed.Peek();
        }

        public bool Empty()
        {
            return _stack.Count == 0 && _stackReversed.Count == 0;
        }
    }
}
