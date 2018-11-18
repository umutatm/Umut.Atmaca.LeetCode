namespace Umut.Atmaca.LeetCode.Amazon {


    public class A0003_InterviewProblem {

        public int[] cellCompete(int[] states, int days) {

            int[] resultStates = new int[states.Length];
            states.CopyTo(resultStates, 0);
            for (int i = 0; i < days; i++) {
                int[] newStates = new int[states.Length];
                for (int k = 0; k < resultStates.Length; k++) {
                    var prevCellStatus = k == 0 ? 0 : resultStates[k - 1];
                    var nextCellStatus = k == resultStates.Length - 1 ? 0 : resultStates[k + 1];
                    newStates[k] = prevCellStatus ^ nextCellStatus;
                }
                newStates.CopyTo(resultStates, 0);
            }

            return resultStates;
        }
    }
}
