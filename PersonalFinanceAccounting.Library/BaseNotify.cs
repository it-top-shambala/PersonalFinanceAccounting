using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PersonalFinanceAccounting.Library
{
    /// <summary>
    /// Абстрактный класс оповещения изменения свойсв классов
    /// </summary>
    public abstract class BaseNotify : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
