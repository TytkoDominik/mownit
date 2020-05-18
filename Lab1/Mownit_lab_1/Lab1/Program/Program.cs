using System;
using Lab1.Sequence.AlteredSequence;
using Lab1.Sequence.FirstSequence;

namespace Lab1.Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //1st task
            PrintFirstTask();
            
            //2nd task
            PrintSecondTaskFloat();
            PrintSecondTaskDouble();
            PrintSecondTaskCompare();
            
            //3rd task
            FindMachineEpsilon();
        }

        private static void PrintFirstTask()
        {
            var sequenceLength = 100;
            var floatSequence = new  FloatSequence(0.01f);
            var alteredFloatSequence = new AlteredFloatSequence(0.01f);
            var doubleSequence = new DoubleSequence(0.01d);
            var alteredDoubleSequence = new DoubleSequence(0.01d);
            
            floatSequence.SetNextResults(sequenceLength);
            doubleSequence.SetNextResults(sequenceLength);
            alteredFloatSequence.SetNextResults(sequenceLength);
            alteredDoubleSequence.SetNextResults(sequenceLength);

            var floatResults = floatSequence.GetResults();
            var doubleResults = doubleSequence.GetResults();

            Console.Out.WriteLine("Results:\n[Index]   [Float]    [Double]   [Difference]");

            for (int i = 0; i < sequenceLength; i++)
            {
                Console.Out.WriteLine(
                    $"{i}: {floatResults[i]}, {doubleResults[i]}, {floatResults[i] - doubleResults[i]}");
            }
        }

        private static void PrintSecondTaskFloat()
        {
            var sequenceLength = 100;
            var floatSequence = new  FloatSequence(0.01f);
            var alteredFloatSequence = new AlteredFloatSequence(0.01f);
            
            floatSequence.SetNextResults(sequenceLength);
            alteredFloatSequence.SetNextResults(sequenceLength);

            var floatResults = floatSequence.GetResults();
            var alteredFloatResults = alteredFloatSequence.GetResults();

            Console.Out.WriteLine("Results:\n[Index]   [Float]    [AlteredFloat]   [Difference]");

            for (int i = 0; i < sequenceLength; i++)
            {
                Console.Out.WriteLine(
                    $"{i}: {floatResults[i]}, {alteredFloatResults[i]}, {floatResults[i] - alteredFloatResults[i]}");
            }
        }
        
        private static void PrintSecondTaskDouble()
        {
            var sequenceLength = 100;
            var doubleSequence = new DoubleSequence(0.01d);
            var alteredDoubleSequence = new DoubleSequence(0.01d);
            
            doubleSequence.SetNextResults(sequenceLength);
            alteredDoubleSequence.SetNextResults(sequenceLength);

            var doubleResults = doubleSequence.GetResults();
            var alteredDoubleResults = alteredDoubleSequence.GetResults();

            Console.Out.WriteLine("Results:\n[Index]   [Double]    [AlteredDouble]   [Difference]");

            for (int i = 0; i < sequenceLength; i++)
            {
                Console.Out.WriteLine(
                    $"{i}: {doubleResults[i]}, {alteredDoubleResults[i]}, {doubleResults[i] - alteredDoubleResults[i]}");
            }
        }
        
        private static void PrintSecondTaskCompare()
        {
            var sequenceLength = 100;
            var alteredFloatSequence = new AlteredFloatSequence(0.01f);
            var alteredDoubleSequence = new DoubleSequence(0.01d);
            
            alteredFloatSequence.SetNextResults(sequenceLength);
            alteredDoubleSequence.SetNextResults(sequenceLength);

            var alteredFloatResults = alteredFloatSequence.GetResults();
            var alteredDoubleResults = alteredDoubleSequence.GetResults();

            Console.Out.WriteLine("Results:\n[Index]   [AlteredFloat]    [AlteredDouble]   [Difference]");

            for (int i = 0; i < sequenceLength; i++)
            {
                Console.Out.WriteLine(
                    $"{i}: {alteredFloatResults[i]}, {alteredDoubleResults[i]}, {alteredFloatResults[i] - alteredDoubleResults[i]}");
            }
        }

        private static void FindMachineEpsilon()
        {
            double value = 1.0d;

            while (value + 1.0d != 1.0d)
            {
                value /= 2.0d;
            }
            
            Console.Out.WriteLine($"Machine epsilon: {value}");
            
        }
    }
}