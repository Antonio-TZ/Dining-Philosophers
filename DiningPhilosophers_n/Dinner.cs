using System.Collections.Generic;
using System.Threading.Tasks;

namespace DiningPhilosophers_n {
    public class Dinner {
        internal List<Philosopher> Philosophers;

        public Dinner(int noOfPhilosophers) {
            Philosophers = PhilosopherRange.Of(noOfPhilosophers);
        }

        public void Start() {
            Task.Factory.StartNew(() => Parallel.ForEach(Philosophers, philosopherIn => philosopherIn.EatDinner())).Wait();
        }
    }
}
