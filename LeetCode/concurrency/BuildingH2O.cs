// 1117. Building H2O

namespace LeetCode.concurrency
{
    internal class BuildingH2O
    {
        private Semaphore _hydrogen;
        private Semaphore _oxygen;
        private Barrier _barrier;

        public BuildingH2O()
        {
            _hydrogen = new Semaphore(2, 2);
            _oxygen = new Semaphore(1, 1);
            _barrier = new Barrier(3);
        }

        public void Hydrogen(Action releaseHydrogen)
        {
            _hydrogen.WaitOne();
            releaseHydrogen();
            _barrier.SignalAndWait();
            _oxygen.Release();
        }

        public void Oxygen(Action releaseOxygen)
        {
            _oxygen.WaitOne();
            releaseOxygen();
            _barrier.SignalAndWait();
            _hydrogen.Release();
        }
    }
}
