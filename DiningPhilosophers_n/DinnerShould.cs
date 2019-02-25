using System.Linq;
using NUnit.Framework;

namespace DiningPhilosophers_n {
    public class DinnerShould {

        [Test]
        public void end_with_all_philosophers_having_eaten() {
            Dinner dinner = new Dinner(5);
            dinner.Start();
            Assert.That(dinner.Philosophers.All(philosopher => philosopher.Eaten));
        }
    }
}
