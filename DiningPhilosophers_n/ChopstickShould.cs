using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace DiningPhilosophers_n {
    [TestFixture]
    public class ChopstickShould {

        [Test]
        public void lock_when_picked_up() {
            Chopstick chopstick = new Chopstick();
            chopstick.Pickup();
            Assert.That(!chopstick.Pickup());
        }
    }
}
