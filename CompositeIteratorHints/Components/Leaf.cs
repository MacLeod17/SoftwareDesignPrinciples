using CompositeIteratorHints.Interfaces;
using CompositeIteratorHints.Iterators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeIteratorHints.Components
{
    public class Leaf : IComponent
    {
        public List<IComponent> Children => throw new NotImplementedException();

        private string question;
        private List<string> answers;
        private string correctAnswer;

        public Leaf(string question, List<string> answers, string correctAnswer)
        {
            this.question = question;
            this.answers = answers;
            this.correctAnswer = correctAnswer;
        }

        public void Add(IComponent child)
        {
            throw new NotImplementedException();
        }

        public bool CheckAnswer(string selected)
        {
            if (selected.ToLower().Equals(correctAnswer.ToLower()))
            {
                return true;
            }

            return false;
        }

        public List<string> GetAnswerList()
        {
            return answers;
        }

        public IIterator GetIterator()
        {
            return new LeafIterator();
        }

        public string GetQuestionText()
        {
            return question;
        }
    }
}
