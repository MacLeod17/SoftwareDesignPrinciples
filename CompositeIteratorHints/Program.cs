using System;
using System.Collections.Generic;
using CompositeIteratorHints.Components;
using CompositeIteratorHints.Interfaces;
using CompositeIteratorHints.Iterators;

namespace CompositeIteratorHints
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponent firstComposite = new Component();
            IComponent secondComposite = new Component();
            IComponent thirdComposite = new Component();

            thirdComposite.Add(new Leaf("What is the last day of the week?", new List<string> { "Monday", "Tuesday", "Friday", "Saturday" }, "Saturday"));
            secondComposite.Add(new Leaf("What is the healthiest drink?", new List<string> { "Coke", "Pepsi", "Water" }, "Water"));
            secondComposite.Add(thirdComposite);
            firstComposite.Add(new Leaf("Is this the last question?", new List<string> { "Yes", "No" }, "No"));
            firstComposite.Add(secondComposite);

            IIterator iterator = firstComposite.GetIterator();
            while (iterator.HasNext())
            {
                IComponent comp = iterator.GetNext();
                if (comp is Component) continue;
                Console.WriteLine(comp.GetQuestionText());
                foreach (string answer in comp.GetAnswerList())
                {
                    Console.WriteLine(answer);
                }
                bool correct = comp.CheckAnswer(Console.ReadLine());

                if (correct) Console.WriteLine("Correct!");
                else Console.WriteLine("Wrong!");
            }
        }
    }
}
