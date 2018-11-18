using System;

namespace Umut.Atmaca.LeetCode.Amazon {


    public class A0004_InterviewProblem {

        public int generalizedGCD(int num, int[] arr) {
            int commonDivisor = 0;

            Array.Sort(arr);
            for (int i = arr[0]; i > 0; i--) {
                commonDivisor = i;
                for (int k = 0; k < arr.Length; k++) {
                    if(arr[k]% i != 0) {
                        commonDivisor = 0;
                        break;
                    }
                }
                if(commonDivisor == i) {
                    break;
                }
            }

            return commonDivisor;
        }
    }
}
