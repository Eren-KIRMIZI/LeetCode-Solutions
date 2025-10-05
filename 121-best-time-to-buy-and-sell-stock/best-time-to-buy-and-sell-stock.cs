public class Solution {
    public int MaxProfit(int[] prices) {
        int minPrice = int.MaxValue; // Şimdiye kadar görülen en düşük alış fiyatı
        int maxProfit = 0;           // En yüksek kâr

        foreach (int price in prices) {
            if (price < minPrice) {
                minPrice = price; // Yeni minimum bulunduysa güncelle
            } else if (price - minPrice > maxProfit) {
                maxProfit = price - minPrice; // Daha iyi kâr bulunduysa güncelle
            }
        }

        return maxProfit;
    }
}
