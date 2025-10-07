public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int maxLength = 0;

        // Tüm olası başlangıç ve bitiş noktalarını deniyoruz
        for (int i = 0; i < s.Length; i++) {
            // Her yeni başlangıç noktası için bir HashSet oluşturuyoruz
            // Bu set, sadece benzersiz karakterleri tutacak
            HashSet<char> charSet = new HashSet<char>();

            // Substring'in sonunu arttırarak ilerliyoruz
            for (int j = i; j < s.Length; j++) {
                // Eğer karakter zaten HashSet'te varsa, tekrar eklemiyoruz
                // Bu durumda substring içinde tekrarlayan karakter var demektir
                if (!charSet.Add(s[j])) {
                    break; // Eğer tekrarlayan karakter varsa, bu substring'i kesip çıkıyoruz
                }

                // Eğer yeni karakter ekleyebildiysek, maxLength'ı güncelliyoruz
                maxLength = Math.Max(maxLength, j - i + 1);
            }
        }

        return maxLength; // En uzun tekrarsız substring'in uzunluğunu döndürüyoruz
    }
}
