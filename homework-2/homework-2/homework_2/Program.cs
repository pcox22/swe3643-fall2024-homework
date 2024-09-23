using System.Threading.Channels;
using homework_2;


int[] sampleValuesList = new int[5] {9, 6, 8, 5, 7};
double sampleStdDev = Computations.COMPUTE_SAMPLE_STANDARD_DEVIATION(sampleValuesList);
Console.WriteLine("Sample StdDev =" + sampleStdDev);


int[] populationValuesList = new int[] { 9, 2, 5, 4, 12, 7, 8, 11, 9, 3, 7, 4, 12, 5, 4, 10, 9, 6, 9, 4 };
double popStdDev = Computations.COMPUTE_POPULATION_STANDARD_DEVIATION(populationValuesList);
Console.WriteLine("Population StdDev =" + popStdDev);





