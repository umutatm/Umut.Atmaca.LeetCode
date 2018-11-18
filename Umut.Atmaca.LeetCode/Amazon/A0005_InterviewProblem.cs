using System;
using System.Collections.Generic;
using System.Linq;

namespace Umut.Atmaca.LeetCode.Amazon {


    public class A0005_InterviewProblem {

        public List<List<int>> nearestXsteakHouses(int totalSteakhouses, int[,] allLocations, int numSteakhouses) {
            // WRITE YOUR CODE HERE
            List<List<int>> nearest = new List<List<int>>();

            var sortedDistances = GetSortedDistances(allLocations).Take(Math.Min(numSteakhouses, totalSteakhouses)).ToList();
            foreach(var location in sortedDistances) {
                nearest.Add(new List<int> { allLocations[location.Key, 0], allLocations[location.Key, 1] });
            }

            return nearest;
        }

        private Dictionary<int, double> GetSortedDistances(int[,] allLocations) {
            Dictionary<int, double> distances = new Dictionary<int, double>();
            for (int i = 0; i < allLocations.Length/2; i++) {
                int xCoord = allLocations[i, 0];
                int yCoord = allLocations[i, 1];
                double distance = Math.Sqrt(Math.Pow(xCoord, 2) + Math.Pow(yCoord, 2));
                distances.Add(i, distance);
            }

            return distances.OrderBy(x => x.Value).ToDictionary(x=>x.Key,x=>x.Value);
        }
    }
}
