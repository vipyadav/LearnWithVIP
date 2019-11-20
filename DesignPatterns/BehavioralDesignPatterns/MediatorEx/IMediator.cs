using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorEx
{
    public interface IMediator<T>
    {
                 
        void Register(string id, Action<object> callback);
        void Unregister(string id, Action<object> callback);
        void SendMessage(string id, T message);

    }

}
