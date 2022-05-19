using CompositeIteratorHints.Interfaces;
using CompositeIteratorHints.Iterators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeIteratorHints.Components
{
    public class Component : IComponent
    {
        public List<IComponent> children = new List<IComponent>();
        public List<IComponent> Children
        {
            get { return this.children; }
        }

        public void Add(IComponent child)
        {
            children.Add(child);
        }

        public bool CheckAnswer(string selected)
        {
            throw new NotImplementedException();
        }

        public List<string> GetAnswerList()
        {
            throw new NotImplementedException();
        }

        public IIterator GetIterator()
        {
            return new CompositeIterator(children);
        }

        public string GetQuestionText()
        {
            throw new NotImplementedException();
        }
    }
}
