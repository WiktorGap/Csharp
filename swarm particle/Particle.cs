using System;

namespace swarm_particle
{
    class Particle
    {
        public double x;
        public double y;
        private double bestX;
        private double bestY;
        public double speed;
        private double inertia;
        private int cognitive;
        private int social;
        private float fitness;
        private float bestFitness;
        private static Random rand = new Random();

        public Particle(int x_, int y_, int inertia_, int cognitive_, int social_)
        {
            x = x_;
            y = y_;
            bestX = x;
            bestY = y;
            speed = 0;
            inertia = inertia_;
            this.cognitive = cognitive_;
            this.social = social_;
            fitness = float.PositiveInfinity;
            bestFitness = float.PositiveInfinity;
        }

        public double calculateFitness(float x, float y)
        {
            double base_ = x + 2 * y + 7.2;
            double base__ = 2 * x + y - 5.2;
            double resPart1 = Math.Pow(base_, 2);
            double resPart2 = Math.Pow(base__, 2);
            return resPart1 + resPart2;
        }

        public (double newFitness, double newBestX, double newBestY) updateFitness(float x, float y)
        {
            this.fitness = (float)calculateFitness(x, y);
            if (this.fitness < bestFitness)
            {
                bestFitness = this.fitness;
                bestX = x;
                bestY = y;
            }
            return (bestFitness, bestX, bestY);
        }

        public Particle getBest(Particle[] swarm)
        {
            float lowestFitness = float.PositiveInfinity;
            Particle bestParticle = null;

            foreach (Particle particle in swarm)
            {
                if (particle.bestFitness < lowestFitness)
                {
                    lowestFitness = particle.bestFitness;
                    bestParticle = particle;
                }
            }

            return bestParticle;
        }

        public double calculateInertia(double inertiaRatio, double speed)
        {
            return inertiaRatio * speed;
        }

        public double calculateCognitiveAcceleration()
        {
            return this.cognitive * rand.NextDouble();
        }

        public double calculateSocialAcceleration()
        {
            return this.social * rand.NextDouble();
        }

        public double calculateDistance(double bestX, double bestY, double actualX, double actualY)
        {
            double part1 = bestX - actualX;
            double part2 = bestY - actualY;
            return Math.Sqrt(Math.Pow(part1, 2) + Math.Pow(part2, 2));
        }

        public double calculateCognitiveComponent(double bestX, double bestY, double actualX, double actualY)
        {
            return calculateCognitiveAcceleration() * calculateDistance(bestX, bestY, actualX, actualY);
        }

        public double caculateSocialComponent(double bestX, double bestY, double actualX, double actualY)
        {
            return calculateSocialAcceleration() * calculateDistance(bestX, bestY, actualX, actualY);
        }

        public void updateParticle(Particle particle, double inertiaRatio, double speed, double bestX, double bestY, double actualX, double actualY)
        {
            double inertion = calculateInertia(inertiaRatio, speed);
            double socialComponent = caculateSocialComponent(bestX, bestY, actualX, actualY);
            double cognitiveComponent = calculateCognitiveComponent(bestX, bestY, actualX, actualY);
            particle.speed = inertion + socialComponent + cognitiveComponent;
            particle.x += particle.speed;
            particle.y += particle.speed;
        }

        // ---------------- MAIN ----------------
        static void Main(string[] args)
        {
            Particle p1 = new Particle(1, 2, 1, 2, 2);
            Particle p2 = new Particle(3, 1, 1, 2, 2);
            Particle p3 = new Particle(0, 4, 1, 2, 2);

            Particle[] swarm = { p1, p2, p3 };

            int numberOfIterations = 100;

            for (int iteration = 0; iteration < numberOfIterations; iteration++)
            {
                Console.WriteLine($"\nITERATION {iteration + 1}");

                foreach (var p in swarm)
                {
                    var result = p.updateFitness((float)p.x, (float)p.y);
                    Console.WriteLine($"Particle Fitness: {result.newFitness:F4}, X: {p.x:F4}, Y: {p.y:F4}");
                }

                Particle globalBest = p1.getBest(swarm);
                var bestData = globalBest.updateFitness((float)globalBest.x, (float)globalBest.y);

                foreach (var p in swarm)
                {
                    p.updateParticle(p, 0.5, p.speed, bestData.newBestX, bestData.newBestY, p.x, p.y);
                }
            }

            Console.WriteLine("\n=== FINAL BEST PARTICLE ===");
            Particle finalBest = p1.getBest(swarm);
            Console.WriteLine($"Best Fitness: {finalBest.bestFitness}, X: {finalBest.bestX}, Y: {finalBest.bestY}");

            Console.WriteLine("\nNaciśnij dowolny klawisz...");
            Console.ReadKey();
        }
    }
}
