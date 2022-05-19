using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeIteratorHints.Interfaces
{
    public interface IComponent
    {
        List<IComponent> Children { get; }

        void Add(IComponent child);
        
        IIterator GetIterator();
        
        string GetQuestionText();
        
        List<string> GetAnswerList();

        bool CheckAnswer(string selected);
    }
}
