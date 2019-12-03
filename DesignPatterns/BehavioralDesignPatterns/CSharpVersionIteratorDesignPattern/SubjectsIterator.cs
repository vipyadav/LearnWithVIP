using System;
using System.Collections;

namespace CSharpVersionIteratorDesignPattern
{
    public class SubjectsIterator : IEnumerator
    {
        private string[] subjects;
        int currentIndex = -1;

        public SubjectsIterator(string[] _subjects)
        {
            subjects = _subjects;
        }

        public object Current
        {
            get
            {
                try
                {
                    return subjects[currentIndex];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public bool MoveNext()
        {
            currentIndex++;
            return (currentIndex < subjects.Length);
        }

        public void Reset()
        {
            currentIndex = -1;
        }

        public void Dispose()
        {
            subjects=null;
        }
    }
}