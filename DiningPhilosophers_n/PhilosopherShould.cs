using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
