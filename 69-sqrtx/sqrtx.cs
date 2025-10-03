public class Solution {
    public int MySqrt(int x) {
        if (x == 0 || x == 1) return x; // küçük sayılar için hızlı dönüş

        int ans = 0;
        for (int i = 1; i <= x; i++) {
            if ((long)i * i <= x) { // overflow önlemek için long kullandım
                ans = i;
            } else {
                break; // artık kare x’i geçtiyse çık
            }
        }
        return ans;
    }
}
