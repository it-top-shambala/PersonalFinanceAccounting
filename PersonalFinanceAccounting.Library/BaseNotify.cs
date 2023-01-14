using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PersonalFinanceAccounting.Library
{
    public abstract class BaseNotify : INotifyPropertyChanged
    {
        public delegate void FinanceAccountingHandler(string message);
        public event FinanceAccountingHandler? Notify;
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        public void OnNotify(string mess)
        {
            Notify?.Invoke(mess);
        }

    }
}
