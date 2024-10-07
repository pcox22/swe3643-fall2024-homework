namespace homework_2;
using homework_2;

public class Computations
{
    public static double COMPUTE_MEAN(int [] valuesList)
    {
        if (valuesList.Equals(null))
        {
            throw new Exception("valuesList parameter cannot be null or empty");
        }


        double sumAccumulator = 0;
        foreach (int value in valuesList)
        {
            sumAccumulator += value;
        }
        return sumAccumulator / valuesList.Length;
    }

    public static double COMPUTE_SQUARE_OF_DIFFERENCES(int[] valuesList, double mean)
    {
        if (valuesList.Equals(null))
        {
            throw new Exception("valuesList parameter cannot be null or empty");
        }

        double squareAccumulator = 0;
        foreach (int value in valuesList)
        { 
            double difference = value - mean;
            double squareOfDifference = difference * difference;
            squareAccumulator += squareOfDifference;
        }

        return squareAccumulator;
    }

    public static double COMPUTE_VARIANCE(double squareOfDifferences, int numValues, bool isPopulation)
    {
        if (!isPopulation)
        {
            numValues = numValues - 1;
        }

        if (numValues < 1)
        {
            throw new Exception("numValues is too low (sample size must be >= 2, population size must be >= 1)");
        }

        return squareOfDifferences / numValues;
    }

    public static double COMPUTE_STANDARD_DEVIATION(int[] valuesList, bool isPopulation)
    {
        if (valuesList.Equals(null))
        {
            throw new Exception("valuesList parameter cannot be null or empty");
        }

        double mean = COMPUTE_MEAN(valuesList);
        double squareOfDifferences = COMPUTE_SQUARE_OF_DIFFERENCES(valuesList, mean);
        double variance = COMPUTE_VARIANCE(squareOfDifferences, valuesList.Length, isPopulation);

        return Math.Sqrt(variance);
    }

    public static double COMPUTE_SAMPLE_STANDARD_DEVIATION(int[] valuesList)
    {
        return COMPUTE_STANDARD_DEVIATION(valuesList, false);
    }

    public static double COMPUTE_POPULATION_STANDARD_DEVIATION(int[] valuesList)
    {
        return COMPUTE_STANDARD_DEVIATION(valuesList, true);
    }
}