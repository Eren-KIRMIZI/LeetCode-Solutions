public class Solution {
    public int Reverse(int x) {
        // int.MinValue özel durumu
        if (x == int.MinValue)
            return 0;

        bool isNegative = x < 0;
        
        // Negatifse işareti kaldır (taşma yok artık)
        int absX = Math.Abs(x);
        
        // Sayıyı string olarak al ve ters çevir
        string str = absX.ToString();
        char[] arr = str.ToCharArray();
        Array.Reverse(arr);
        string reversedStr = new string(arr);

        // Ters çevrilen string'i int'e çevir
        try {
            int reversed = int.Parse(reversedStr);
            return isNegative ? -reversed : reversed;
        }
        catch (OverflowException) {
            return 0; // taşma durumunda
        }
    }
}
