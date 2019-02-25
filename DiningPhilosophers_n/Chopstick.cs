using System.Threading;

namespace DiningPhilosophers_n {
    internal class Chopstick {
        public bool IsHeld { get; private set; }

        internal bool Pickup() {
            if (IsHeld) return false;
            if (Monitor.TryEnter(this, 500)) {
                IsHeld = true;
                return true;
            }
            return false;
        }

        internal bool Putdown() {
            if (IsHeld) {
                Monitor.Exit(this);
                IsHeld = false;
                return true;
            }
            return false;
        }
    }
}