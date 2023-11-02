using System.IO;
using System.Reflection;

namespace BitCoinTradeAnalysisDemo
{
    public class BitCoinViewModel
    {
        List<BitCoinModel> bitCoinCollection;
        public List<BitCoinModel> BitCoinCollection
        {
            get
            {
                return bitCoinCollection;
            }
            set
            {
                bitCoinCollection = value;
            }
        }
        public BitCoinViewModel()
        {
            BitCoinCollection = new List<BitCoinModel>();
            ReadCSV("BitCoinTradeAnalysisDemo.Resources.data.csv");
        }

        private void ReadCSV(string resourceStream)
        {
            Assembly executingAssembly = typeof(App).GetTypeInfo().Assembly;
            Stream? inputStream = executingAssembly.GetManifestResourceStream(resourceStream);

            string? line;
            List<string> lines = new List<string>();

            if (inputStream != null)
            {
                using StreamReader reader = new StreamReader(inputStream);
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }

                lines.RemoveAt(0);

                foreach (var dataPoint in lines)
                {
                    string[] data = dataPoint.Split(',');

                    //To get the date data
                    DateTime date = DateTime.Parse(data[0]);
                    //To get the price data in thousands(K)
                    var price = Convert.ToDouble(data[5]) / 1000;
                    //To get the volume data in billions(B)
                    var volume = Convert.ToDouble(data[6]) / 1000000000;
                    BitCoinCollection.Add(new BitCoinModel(date, Math.Round(price, 2), Math.Round(volume, 2)));
                }
            }
        }
    }
}
