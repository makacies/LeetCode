// 1114. Print in Order

namespace LeetCode.concurrency
{
    internal class PrintInOrder
    {
        private ManualResetEventSlim _eventSlimFirst;
        private ManualResetEventSlim _eventSlimSecond;

        public PrintInOrder()
        {
            _eventSlimFirst = new ManualResetEventSlim(false);
            _eventSlimSecond = new ManualResetEventSlim(false);
        }

        public void First(Action printFirst)
        {
            // printFirst() outputs "first". Do not change or remove this line.
            printFirst();
            _eventSlimFirst.Set();
        }

        public void Second(Action printSecond)
        {
            _eventSlimFirst.Wait();
            // printSecond() outputs "second". Do not change or remove this line.
            printSecond();
            _eventSlimSecond.Set();
        }

        public void Third(Action printThird)
        {
            _eventSlimSecond.Wait();
            // printThird() outputs "third". Do not change or remove this line.
            printThird();
        }
    }
}
