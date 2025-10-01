public class Solution {
    public int[] PlusOne(int[] digits) {
        // 1. digits -> string
        string number = "";
        foreach (int d in digits) {
            number += d.ToString();
        }

        // 2. string -> BigInteger (çok büyük sayıları da tutar)
        System.Numerics.BigInteger bigInt = System.Numerics.BigInteger.Parse(number);

        // 3. +1 ekle
        bigInt += 1;

        // 4. tekrar string'e çevir
        string result = bigInt.ToString();

        // 5. string -> int array
        int[] output = new int[result.Length];
        for (int i = 0; i < result.Length; i++) {
            output[i] = result[i] - '0'; // char -> int
        }

        return output;
    }
}
