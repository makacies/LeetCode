// 1115. Print FooBar Alternately

namespace LeetCode.concurrency
{
    internal class PrintFooBarAlternately
    {
        private int n;
        //private ManualResetEventSlim _eventSlimFoo;
        //private ManualResetEventSlim _eventSlimBar;
        private SemaphoreSlim _fooSem, _barSem;

        public PrintFooBarAlternately(int n)
        {
            this.n = n;
            _fooSem = new SemaphoreSlim(1, 1);
            _barSem = new SemaphoreSlim(0, 1);

            //_eventSlimFoo = new ManualResetEventSlim(true);
            //_eventSlimBar = new ManualResetEventSlim();
        }

        public void Foo(Action printFoo)
        {

            for (int i = 0; i < n; i++)
            {
                _fooSem.Wait();
                //_eventSlimFoo.Wait();
                //_eventSlimFoo.Reset();
                // printFoo() outputs "foo". Do not change or remove this line.
                printFoo();
                //_eventSlimBar.Set();
                _barSem.Release();
            }
        }

        public void Bar(Action printBar)
        {

            for (int i = 0; i < n; i++)
            {
                _barSem.Wait();
                //_eventSlimBar.Wait();
                //_eventSlimBar.Reset();
                // printBar() outputs "bar". Do not change or remove this line.
                printBar();
                //_eventSlimFoo.Set();
                _fooSem.Release();
            }
        }
    }
}
