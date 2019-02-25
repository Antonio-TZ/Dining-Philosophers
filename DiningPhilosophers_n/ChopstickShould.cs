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

        [Test]
        public void ignore_requests_to_lock_when_held() {
            Chopstick chopstick = new Chopstick();
            chopstick.Pickup();
            Assert.That(!chopstick.Pickup());
        }

        [Test]
        public void signal_event_when_it_unlocks() {
            Chopstick chopstick = new Chopstick();
            int callCount = 0;
            chopstick.Unlocked += () => callCount++;
            chopstick.Pickup();
            chopstick.Putdown();
            Assert.That(callCount == 1);
        }
    }
}
