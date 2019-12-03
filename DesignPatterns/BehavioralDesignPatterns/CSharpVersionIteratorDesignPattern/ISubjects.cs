

using System.Collections;

namespace CSharpVersionIteratorDesignPattern
{
    public interface ISubjects : IEnumerable
    {
        string[] Subjects { get; }
    }
}
