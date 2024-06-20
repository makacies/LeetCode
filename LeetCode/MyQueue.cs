// 232. Implement Queue using Stacks

namespace LeetCode
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
            RewriteStacks(_stack, _stackReversed);
        }

        public int Pop()
        {
            var returnValue = _stackReversed.Pop();
            RewriteStacks(_stackReversed, _stack);
            return returnValue;
        }

        public int Peek()
        {
            return _stackReversed.Peek();
        }

        public bool Empty()
        {
            return _stack.Count == 0;
        }

        private void RewriteStacks(Stack<int> original, Stack<int> reversed)
        {
            reversed.Clear();
            foreach (var value in original)
            {
                reversed.Push(value);
            }
        }
    }
}
