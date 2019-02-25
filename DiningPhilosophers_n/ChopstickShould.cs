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

        [Test]
        public void unlock_when_put_down() {
            Chopstick chopstick = new Chopstick();
            chopstick.Pickup();
            Assert.That(chopstick.Putdown());
        }
    }
}
