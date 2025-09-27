public class Solution {
    private int GetValue(char c) {
        switch (c) {
            case 'I': return 1;
            case 'V': return 5;
            case 'X': return 10;
            case 'L': return 50;
            case 'C': return 100;
            case 'D': return 500;
            case 'M': return 1000;
            default: return 0;
        }
    }

    public int RomanToInt(string s) {
        int total = 0;
        for (int i = 0; i < s.Length; i++) {
            int current = GetValue(s[i]);

            if (i + 1 < s.Length && current < GetValue(s[i + 1])) {
                total -= current;
            } else {
                total += current;
            }
        }
        return total;
    }
}
