using System;
using System.Threading;

namespace DiningPhilosophers_n {
    internal class Chopstick {
        public bool IsHeld { get; private set; }
        public event Action Unlocked;

        internal bool Pickup() {
            if (IsHeld) return false;
            if (Monitor.TryEnter(this, 500)) {
                IsHeld = true;
                return true;
            }
            return false;
        }

        internal bool Putdown() {
            lock (this) {
                if (IsHeld) {
                    Monitor.Exit(this);
                    IsHeld = false;
                    Unlocked?.Invoke();
                    return true;
                }
                return false;
            }
        }
    }
}