using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompositeIteratorHints.Interfaces;
using CompositeIteratorHints.Components;

namespace CompositeIteratorHints.Iterators
{
    public class CompositeIterator : IIterator
    {
        List<IComponent> components;
        int index = 0;
        Stack<IIterator> iterators = new Stack<IIterator>();

        public CompositeIterator(List<IComponent> comps)
        {
            this.components = comps;
            //iterators.Push(inComponent.GetIterator());
        }

        public IComponent GetNext()
        {
            if (HasNext())
            {
                //IIterator iterator = iterators.Peek();
                IComponent component;

                if (iterators.Count != 0)
                {
                    IIterator iterator = iterators.Peek();
                    component = iterator.GetNext();
                }
                else
                {
                    component = this.components[index++];
                }
                if (component is Component) 
                {
                    iterators.Push(((Component)component).GetIterator());
                }
                return component;
            }
            else
            {
                return null;
            }
        }

        public bool HasNext()
        {
            if (iterators.Count == 0)
            {
                return index < components.Count;
            }
            else
            {
                IIterator iterator = iterators.Peek();
                if (!iterator.HasNext())
                {
                    iterators.Pop();
                    return HasNext();
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
