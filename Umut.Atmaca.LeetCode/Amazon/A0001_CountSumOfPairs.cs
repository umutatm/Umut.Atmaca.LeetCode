namespace Umut.Atmaca.LeetCode.Amazon {

    /// <summary>
    /// Given an array of numbers in sorted order, count the paris of numbers whose sum is less than X
    /// </summary>
    public class A0001_CountSumOfPairs {

        public int CountSumOfPairs(int[] numbers, int maxCountOfPairs) {
            int numOfPairs = 0;
            int numberOfLoop = 0;
            for (int i = 0; i < numbers.Length; i++) {
                for (int k = i + 1; k < numbers.Length; k++) {
                    numberOfLoop++;
                    if (numbers[k] + numbers[i] < maxCountOfPairs) {
                        numOfPairs++;
                    }
                }
            }

            return numOfPairs;
        }

        public int CountSumOfPairsV2(int[] numbers, int maxCountOfPairs) {
            int numOfPairs = 0;
            int numberOfLoop = 0;
            for (int i = 0; i < numbers.Length; i++) {
                for (int k = numbers.Length-1; k > i; k--) {
                    numberOfLoop++;
                    if (numbers[k] + numbers[i] < maxCountOfPairs) {
                        numOfPairs += k - i;
                        break;
                    }
                }
            }

            return numOfPairs;
        }
    }
}
