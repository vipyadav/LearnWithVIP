using System;
using System.Collections;

namespace CSharpVersionIteratorDesignPattern
{
    public class Science : ISubjects
    {
        public Science()
        {
            Subjects = new[] { "Physics", "Chemistry", "Math" };
        }

        public string[] Subjects { get; }

        public IEnumerator GetEnumerator()
        {
            return new SubjectsIterator(Subjects);
        }
    }
}
