public class Solution {
    public string AddBinary(string a, string b) {
        int i = a.Length - 1;  // a'nın son index'i
        int j = b.Length - 1;  // b'nin son index'i
        int carry = 0;         // elde
        string result = "";    // sonucu string olarak biriktireceğiz

        // iki string de bitene kadar döneriz
        while (i >= 0 || j >= 0 || carry > 0) {
            int sum = carry; // başta eldeyi ekle

            if (i >= 0) {
                sum += a[i] - '0'; // karakteri int'e çevir
                i--;
            }

            if (j >= 0) {
                sum += b[j] - '0';
                j--;
            }

            // toplam 2 veya daha büyükse elde var
            carry = sum / 2;
            result = (sum % 2) + result; // en sağa yaz
        }

        return result;
    }
}
