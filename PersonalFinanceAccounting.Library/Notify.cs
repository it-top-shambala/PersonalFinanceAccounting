using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PersonalFinanceAccounting.Library
{
    public abstract class Notify : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? name = null)
        {
            if (EqualityComparer<T>.Default.Equals(value, field)) return false;
            field = value;
            OnPropertyChanged(name);
            return true;
        }
    }
}
