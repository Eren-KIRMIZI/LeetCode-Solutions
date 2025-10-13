public class Solution {
    public string IntToRoman(int num) {
        // Tüm semboller ve karşılık gelen değerleri (büyükten küçüğe)
        int[] values = {1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1};
        string[] symbols = {"M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"};

        string result = "";

        for (int i = 0; i < values.Length && num > 0; i++) {
            while (num >= values[i]) {
                num -= values[i];      // Değer kadar çıkar
                result += symbols[i];  // Sembolu ekle
            }
        }

        return result;
    }
}
