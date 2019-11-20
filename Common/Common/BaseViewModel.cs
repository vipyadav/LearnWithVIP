using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class BaseViewModel : INotifyPropertyChanged
    {

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        // Simple implementation
        public void OnPropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // with .NET 4.5 CallerMemberNameAttribute provides us information about caller of given method.
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        // By Using Lambda Expressions we can get rid of so called “magic” strings 
        protected virtual void RaisePropertyChanged<T>(Expression<Func<T>> propertyExpression)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(GetPropertyName(propertyExpression)));
            }
        }

        private string GetPropertyName<T>(Expression<Func<T>> propertyExpression)
        {
            var unaryExpression = propertyExpression.Body as UnaryExpression;
            var memberExpression = unaryExpression == null ? (MemberExpression)propertyExpression.Body : (MemberExpression)unaryExpression.Operand;
            var propertyName = memberExpression.Member.Name;
            return propertyName;
        }

        #endregion
    }
}
