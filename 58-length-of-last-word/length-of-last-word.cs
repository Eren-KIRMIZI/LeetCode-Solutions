public class Solution {
    public int LengthOfLastWord(string s) {
        // Baştaki ve sondaki boşlukları sil
        s = s.Trim();

        // Boşluklardan ayır
        string[] words = s.Split(' ');

        // Son kelimeyi al
        string lastWord = words[words.Length - 1];

        // Son kelimenin uzunluğu
        return lastWord.Length;
    }
}
