public class Solution {
    public int ClimbStairs(int n) {
        int[] memo = new int[n + 1];
        return Helper(n, memo);
    }

    private int Helper(int n, int[] memo) {
        if (n <= 1)
            return 1;

        if (memo[n] != 0)
            return memo[n]; // daha önce hesaplandıysa direkt dön

        memo[n] = Helper(n - 1, memo) + Helper(n - 2, memo);
        return memo[n];
    }
}
