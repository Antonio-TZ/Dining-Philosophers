using System.Collections.Generic;

namespace DiningPhilosophers_n {
    internal class PhilosopherRange {
        public static List<Philosopher> Of(int noOfPhilosophers) {
            List<Chopstick> chopsticks = ChopstickRangeOf(noOfPhilosophers);
            List<Philosopher> philosophers = new List<Philosopher>();
            for (int i = 0; i < noOfPhilosophers; i++) {
                Philosopher philosopher = new Philosopher() {
                    LeftChopstick = chopsticks[i],
                    RightChopstick = chopsticks[i == noOfPhilosophers - 1 ? 0 : i + 1]
                };
                philosophers.Add(philosopher);
            }
            return philosophers;
        }

        private static List<Chopstick> ChopstickRangeOf(int noOfPhilosophers) {
            List<Chopstick> chopsticks = new List<Chopstick>();
            for (int i = 0; i < noOfPhilosophers; i++) {
                chopsticks.Add(new Chopstick());
            }
            return chopsticks;
        }
    }
}
