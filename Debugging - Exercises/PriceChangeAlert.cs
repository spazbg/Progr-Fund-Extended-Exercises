using System;

class PriceChangeAlert
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        double threshold = double.Parse(Console.ReadLine());

        double lastPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());
            double difference = PercentDifference(lastPrice, currentPrice);

            bool isSignificantDifference = checkDifference(difference, threshold);
            
            string message = GetMessage(currentPrice, lastPrice, difference, isSignificantDifference);
            lastPrice = currentPrice;

            Console.WriteLine(message);
        }
    }

    private static string GetMessage(double currentPrice, double lastPrice, double difference, bool hasSignificantDifference)        
    {
        string message = string.Empty;
        if (difference == 0)
        {
            message = string.Format("NO CHANGE: {0}", currentPrice);
        }

        else if (!hasSignificantDifference)
        {
            message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference*100);
        }

        else if (hasSignificantDifference && (difference > 0))
        {
            message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference*100);
        }

        else if (hasSignificantDifference && (difference < 0))
        {
            message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference*100);
        }

        return message;
    }

    private static bool checkDifference(double difference, double threshold)
    {
        if (Math.Abs(difference) >= threshold)
        {
            return true;
        }

        return false;
    }

    private static double PercentDifference(double lastPrice, double currentPrice)
    {
        double differencer = (currentPrice - lastPrice) / lastPrice;
        return differencer;
    }
}
