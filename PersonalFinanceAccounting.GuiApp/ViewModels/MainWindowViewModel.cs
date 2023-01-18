using System.Collections.ObjectModel;
using PersonalFinanceAccounting.GuiApp.ViewModels.TopPanelOperations;
using PersonalFinanceAccounting.Library.Models;

namespace PersonalFinanceAccounting.GuiApp.ViewModels
{
    public class MainWindowViewModel : Notifier
    {
        public TopPanel TopPanel { get; set; }

        public ObservableCollection<Wallet> Wallets { get; set; }

        public MainWindowViewModel()
        {
            TopPanel = new();
            Wallets = new ObservableCollection<Wallet> { new Wallet { Id = 1, Balance = 1000000, IdCurrancy = 1, Name = "Wallet" } };
            //используем метод получения кошельков
        }

    }
}
