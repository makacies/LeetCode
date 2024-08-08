// 1116. Print Zero Even Odd

namespace LeetCode.concurrency
{
    internal class PrintZeroEvenOdd
    {
        private int n;
        private SemaphoreSlim _semaphoreZero;
        private SemaphoreSlim _semaphoreEven;
        private SemaphoreSlim _semaphoreOdd;

        internal PrintZeroEvenOdd(int n)
        {
            this.n = n;
            _semaphoreZero = new SemaphoreSlim(1, 1);
            _semaphoreEven = new SemaphoreSlim(0, 1);
            _semaphoreOdd = new SemaphoreSlim(0, 1);
        }

        // printNumber(x) outputs "x", where x is an integer.
        public void Zero(Action<int> printNumber)
        {
            for (int i = 1; i <= n; i++)
            {
                _semaphoreZero.Wait();
                printNumber(0);
                if (i % 2 == 1) _semaphoreOdd.Release();
                else _semaphoreEven.Release();
            }
        }

        public void Even(Action<int> printNumber)
        {
            for (int i = 2; i <= n; i += 2)
            {
                _semaphoreEven.Wait();
                printNumber(i);
                _semaphoreZero.Release();
            }
        }

        public void Odd(Action<int> printNumber)
        {
            for (int i = 1; i <= n; i += 2)
            {
                _semaphoreOdd.Wait();
                printNumber(i);
                _semaphoreZero.Release();
            }
        }
    }
}
