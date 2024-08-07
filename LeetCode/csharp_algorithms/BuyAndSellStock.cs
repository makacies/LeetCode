// 121. Best Time to Buy and Sell Stock

namespace LeetCode.csharp_algorithms
{
    internal class BuyAndSellStock
    {
        int MaxProfit(int[] prices)
        {
            var min = int.MaxValue;
            var diffMax = 0;

            foreach (var price in prices)
            {
                if (price < min)
                {
                    min = price;
                }
                else
                {
                    var diff = price - min;
                    if (diff > diffMax)
                    {
                        diffMax = diff;
                    }
                }
            }

            return diffMax;
        }
    }
}
