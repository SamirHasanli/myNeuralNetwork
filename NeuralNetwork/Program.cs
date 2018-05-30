using System;

namespace NeuralNetwork
{
    class Program
    {
        public static void Main(string[] args)
        {
            Neuron n = new Neuron();
            // learning   input1, input2, output, loop Length
            n.updateWeights(1, 0, 0, 2000);
            n.updateWeights(1, 0.1, 1, 2000);
            n.updateWeights(1, 0.2, 1, 2000);
            n.updateWeights(1, 0.3, 1, 2000);
            n.updateWeights(0.9, 0.1, 1, 2000);
            n.updateWeights(0.9, 0.2, 1, 2000);
            n.updateWeights(0.6, 0.1, 1, 2000);
            n.updateWeights(0.8, 0.2, 1, 2000);
            n.updateWeights(0.7, 0.3, 1, 2000);
            n.updateWeights(0.5, 0.1, 1, 2000);
            n.updateWeights(0.7, 0.1, 1, 2000);
            n.updateWeights(0.3, 0.5, 0.4, 2000);
            n.updateWeights(0.4, 0.3, 0.4, 2000);
            n.updateWeights(0.4, 0.5, 0.4, 2000);
            n.updateWeights(0.4, 1, 0.4, 2000);
            n.updateWeights(0.4, 0.7, 0.4, 2000);
            n.updateWeights(0.2, 0.3, 0.4, 2000);
            n.updateWeights(0.3, 0.5, 0.4, 2000);
            n.updateWeights(0.5, 0.5, 0.4, 2000);
            n.updateWeights(0.2, 0.3, 0.4, 2000);
            n.updateWeights(0.5, 0.5, 0.4, 2000);
            n.updateWeights(0.8, 0.5, 0.4, 2000);
            Console.WriteLine("\n\n" + n.result(0.2, 0.5));
        }

    }

    class sigmoid
    {
        public static double output(double x)
        {
            return 1.0 / (1.0 + Math.Exp(-x));
        }

        public static double derivative(double x)
        {
            return x * (1 - x);
        }
    }
    class Neuron
    {
        private double e = 0.005;
        private double Limit = 0;
        private double Rate = 0.1;
        private double weight1 = 0.02;
        private double weight2 = 0.01;
        public double result(double input1, double input2)
        {
            return sigmoid.output(weight1 * input1 + weight2 * input2);
        }
        public double Error(double input1, double input2)
        {
            double E = weight1 * input1 + weight2 * input2 - Limit;
            return E;
        }
        public void updateWeights(double input1, double input2, double output, int loopLength)
        {
            int l = 0;
            while (Error(input1, input2) > e && l < loopLength)
            {
                double d = (Error(input1, input2) + e) * Rate;
                if (result(input1, input2) > output)
                {
                    weight1 -= d;
                    weight2 -= d;
                }
                else
                {
                    weight1 += d;
                    weight2 += d;
                }
                Console.WriteLine(weight1 + "\t" + weight2 + "\t" + Error(input1, input2));
                l++;
            }


        }

    }
}
