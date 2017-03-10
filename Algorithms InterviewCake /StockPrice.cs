using System;

namespace InterviewCake
{
    //buy low sell highs

    //getMaxProfit(stockPricesYesterday);
    // returns 6 (buying for $5 and selling for $11)

    public class StockPrice
    {
        // 10, 7        buy=10   sell=7
        // 10,7,5       buy=7    sell=5
        // 10,7,5,8     buy=5    sell=8
        int[] stockPricesYesterday = new int[]{ 10, 7, 5, 8, 11, 9 };

        public StockPrice()
        {
        }

        int  getMaxProfit(int[] stocks)
        {
            int low = stocks [0];
            int high = stocks [1];
            int profit = high - low;

            Console.WriteLine("low=" + low + "  high=" + high + "   profit=" + profit);

            for (int i = 2; i < stocks.Length - 1; i++)
            {
                if (stocks [i - 1] < low)
                    low = stocks [i - 1];
                
                    
                if (stocks [i] - low > profit)
                {
                    high = stocks [i];
                    profit = stocks [i] - low;
                }
                Console.WriteLine("low=" + low + "  high=" + high + "  profit=" + profit);

            }

            return 0;
        }


        public void test()
        {
            getMaxProfit(stockPricesYesterday);
        }
    }
}



