public class Solution {
    public bool IsValid(string s) {
        // Eğer uzunluk tekse zaten geçersiz
        if (s.Length % 2 != 0) return false;

        bool changed = true;

        while (changed) {
            int before = s.Length;

            s = s.Replace("()", "")
                 .Replace("{}", "")
                 .Replace("[]", "");

            // Eğer boyut değişmediyse daha fazla azaltılamaz
            changed = before != s.Length;
        }

        // Eğer tamamen boşaldıysa valid
        return s.Length == 0;
    }
}
