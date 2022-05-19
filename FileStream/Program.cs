using System;
using System.IO;
using FileStream.Decorators;

namespace FileStream
{
    class Program
    {
        public static string filepath = "../../../../Output/";

        static void Main(string[] args)
        {
            // Signature Write
            WriterComponent writer = new SignatureDecorator(new StreamWriter($"{filepath}signature.txt"));
            writer.Write("All ur base \r\nare belong to us");
            writer.Close();

            // Shift Up Write
            writer = new ShiftUpDecorator(new StreamWriter($"{filepath}shiftUp.txt"));
            writer.Write("All ur base are belong to us");
            writer.Close();

            /*
            What happens in the written file when you wrap SignatureDecorator in ShiftUpDecorator?  Vise Versa?

            When wrapping SignatureDecorator in ShiftUpDecorator, a signature is added then the characters are shifted up, including the signature, resulting in signature also becoming gibberish.
            When wrapping the other way around, the characters are shifted up then the signature is added, resulting in gibberish followed by clean signature. 
            */

            // Shift Down Read
            ReaderComponent reader = new ShiftDownDecorator(new StreamReader($"{filepath}shiftUp.txt"));
            string output = reader.ReadToEnd();
            Console.WriteLine(output);

            // Line Ending Read
            reader = new LineEndingDecorator(new StreamReader($"{filepath}signature.txt"));
            output = reader.ReadToEnd();
            if (!output.Contains("\r\n")) Console.WriteLine("Line Endings Replaced");
        }
    }
}
