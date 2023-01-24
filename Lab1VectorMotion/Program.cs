using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length != 7)
        {
            Console.WriteLine("Invalid number of arguments. Correct usage: dotnet run startX startY startYZ finalX finalY finalZ time");
            return;
        }

        int[] inputs = args.Select(int.Parse).ToArray();
        int startX = inputs[0];
        int startY = inputs[1];
        int startZ = inputs[2]; 
        int finalX = inputs[3];
        int finalY = inputs[4];
        int finalZ = inputs[5];
        int time = inputs[6];
        // int newX = startX + finalX;
        // int newY = startY + finalY;
        // int newZ = startZ + finalZ;

        double distance = Math.Sqrt(Math.Pow(finalX - startX, 2) + Math.Pow(finalY - startY, 2) + Math.Pow(finalZ - startZ, 2));
        double velocity = distance / time;

        
        Console.WriteLine("start position: " + startX + " " + startY + " " + startZ);
        Console.WriteLine("final position: " + finalX + " " + finalY + " " + finalZ);
        Console.WriteLine("time: " + time);

        Console.WriteLine("distance: " + distance);
        Console.WriteLine("Speed: " + velocity);

        double trackX = (double)(finalX - startX)/10;
        double trackY = (double)(finalY - startY)/10;
        double trackZ = (double)(finalZ - startZ)/10;

        double t = 0.0;
        double[] currentPosition = new double[] { startX, startY, startZ };
        double distanceTraveled = 0.0;
        double timeIncrement = (double)time/10;
        int iteration = 0;

        for (iteration = 1; iteration <= 10; iteration++) {
            // Calculate distance traveled
            distanceTraveled = Math.Sqrt(Math.Pow(trackX * iteration, 2) + Math.Pow(trackY * iteration, 2) + Math.Pow(trackZ * iteration, 2));

            // Calculate current position
            currentPosition[0] = currentPosition[0] + trackX;
            currentPosition[1] = currentPosition[1] + trackY;
            currentPosition[2] = currentPosition[2] + trackZ;

            // Calculate time
            t += timeIncrement;

            // Print iteration information
            Console.WriteLine("iteration {0}:", iteration);
            Console.WriteLine("distance traveled {0}", Math.Round(distanceTraveled, 2));
            Console.WriteLine("current position: [{0}, {1}, {2}]", Math.Round(currentPosition[0],2), Math.Round(currentPosition[1],2), Math.Round(currentPosition[2],2));
            Console.WriteLine("time: {0}", t);
        }
        
    }

        
}

