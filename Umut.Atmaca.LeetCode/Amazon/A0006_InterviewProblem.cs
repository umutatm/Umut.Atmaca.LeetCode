using System;
using System.Collections.Generic;
using System.Linq;

namespace Umut.Atmaca.LeetCode.Amazon {


    public class A0006_InterviewProblem {

        public List<List<int>> optimalUtilization(int deviceCapacity,
                                             List<List<int>> foregroundAppList,
                                             List<List<int>> backgroundAppList) {
            // WRITE YOUR CODE HERE


            Dictionary<string, int> costs = new Dictionary<string, int>();
            if (foregroundAppList != null && backgroundAppList != null) {
                for (int f = 0; f < foregroundAppList.Count; f++) {
                    for (int b = 0; b < backgroundAppList.Count; b++) {
                        var pairKey = f + "-" + b;
                        if (!costs.ContainsKey(pairKey)) {
                            costs.Add(pairKey, foregroundAppList[f][1] + backgroundAppList[b][1]);
                        }
                    }
                }
            }

            List<List<int>> optimal = new List<List<int>>();
            var sorted = costs.Where(x => x.Value <= deviceCapacity).ToList();
            if (sorted.Count > 0) {
                sorted = sorted.OrderByDescending(x => x.Value).ToList();
            }

            int cost = 0;
            foreach (var pair in sorted) {

                var apps = pair.Key.Split('-');
                if (cost == 0 || cost == pair.Value) {
                    optimal.Add(new List<int> { Convert.ToInt32(apps[0]) + 1, Convert.ToInt32(apps[1]) + 1 });
                    cost = pair.Value;
                }
            }

            return optimal;
        }
    }
}
