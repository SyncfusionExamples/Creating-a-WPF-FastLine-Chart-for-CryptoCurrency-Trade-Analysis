using System;
using System.Collections.Generic;

namespace BitCoinTradeAnalysisDemo
{
    public class BitCoinModel
    {
        public DateTime Date { get; set; }
        public double BitCoinPrice { get; set; }
        public double Volume { get; set; }

        public BitCoinModel(DateTime dateTime, double bitCoinPrice, double volume)
        {
            Date = dateTime;
            BitCoinPrice = bitCoinPrice;
            Volume = volume;
        }
    }
}
