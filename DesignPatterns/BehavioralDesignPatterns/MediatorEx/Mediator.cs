using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorEx
{
    public sealed class Mediator<T> : IMediator<T>
    {
        private static Mediator<T> instance = new Mediator<T>();

        private readonly Dictionary<string, List<Action<T>>> ColleagueList 
            = new Dictionary<string, List<Action<T>>>();

        private Mediator() { }

        public static Mediator<T> Instance
        {
            get
            {
                return instance;
            }
        }

        public void Register(string id, Action<T> callback)
        {
            if (!ColleagueList .ContainsKey(id))
            {
                ColleagueList [id] = new List<Action<T>>();
            }

            ColleagueList[id].Add(callback);
        }

        public void Unregister(string id, Action<T> callback)
        {
            ColleagueList [id].Remove(callback);

            if (ColleagueList [id].Count == 0)
            {
                ColleagueList.Remove(id);
            }
        }

        public void SendMessage(string id, T parameter)
        {
            ColleagueList [id].ForEach(action => action(parameter));
        }
    }
}
