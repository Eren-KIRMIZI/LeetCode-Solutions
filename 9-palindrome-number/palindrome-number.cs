public class Solution {
    public bool IsPalindrome(int x) {
        // Negatif sayılar palindrom olamaz
        if (x < 0) return false;

        int original = x;
        long reversed = 0; // taşma ihtimaline karşı long

        while (x > 0) {
            int digit = x % 10;       // sondaki basamak
            reversed = reversed * 10 + digit;
            x /= 10;                  // sondaki basamağı at
        }

        return original == reversed;
    }
}
