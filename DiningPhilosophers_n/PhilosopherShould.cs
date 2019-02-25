using System.Collections.Generic;
using NUnit.Framework;

namespace DiningPhilosophers_n {
    public class PhilosopherShould {

        [Test]
        public void eat_when_holding_both_chopsticks() {
            Philosopher philosopher = new Philosopher();
            philosopher.LeftChopstick.Pickup();
            philosopher.RightChopstick.Pickup();
            Assert.That(philosopher.Eat());
        }

        [Test]
        public void return_both_chopsticks_when_done_eating() {
            Philosopher philosopher = new Philosopher();
            philosopher.EatDinner();
            Assert.That(philosopher.IsNotHoldingChopsticks);
        }

        [Test]
        public void return_chopsticks_if_unable_to_lock_both() {
            List<Philosopher> philosophers = PhilosopherRange.Of(2);
            philosophers[1].LeftChopstick.Pickup();
            philosophers[0].EatDinner();
            Assert.That(philosophers[0].IsNotHoldingChopsticks);
        }
    }
}
