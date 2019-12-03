using System;
using System.Collections;

namespace CSharpVersionIteratorDesignPattern
{
    public class Arts : ISubjects
    {
        public Arts()
        {
            Subjects = new[] { "History", "Political Science", "Sociology" };
        }

        public string[] Subjects { get; }

        public IEnumerator GetEnumerator()
        {
            return new SubjectsIterator(Subjects);
        }        
    }
}
