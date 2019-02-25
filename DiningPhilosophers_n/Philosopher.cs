using System;

namespace DiningPhilosophers_n {
    internal class Philosopher {
        public Chopstick LeftChopstick { get; internal set; }
        public Chopstick RightChopstick { get; internal set; }
        internal bool HoldsBothChopsticks => LeftChopstick.IsHeld && RightChopstick.IsHeld;
        internal bool IsNotHoldingChopsticks => !LeftChopstick.IsHeld && !RightChopstick.IsHeld;

        public Philosopher() {
            LeftChopstick = new Chopstick();
            RightChopstick = new Chopstick();
        }

        internal bool Eat() {
            if(HoldsBothChopsticks) {
                ReturnBothChopsticks();
                return true;
            }
            return false;
        }

        private void ReturnBothChopsticks() {
            LeftChopstick.Putdown();
            RightChopstick.Putdown();
        }

        internal void EatDinner() {
            if(PickupBothChopsticks()) {
                Eat();
            } else {
                ReturnBothChopsticks();
            }
        }

        private bool PickupBothChopsticks() {
            if (LeftChopstick.Pickup()) {
                if (RightChopstick.Pickup()) {
                    return true;
                }
            }
            return false;
        }
    }
}