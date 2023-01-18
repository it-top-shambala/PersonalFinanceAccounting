using PersonalFinanceAccounting.GuiApp.ViewModels.Commands;
using PersonalFinanceAccounting.GuiApp.ViewModels.TopPanelOperations;

namespace PersonalFinanceAccounting.GuiApp.ViewModels
{
    public class MainWindowViewModel : Notifier
    {
        public OperationCreateWallet CreateWallet { get; set; }
        public MyCommand CommandOpenCloseCreateWallet { get; }
        public MyCommand CommandCreateWallet { get; }

        public OperationCreateIncomeCategory CreateIncomeCategory { get; set; }
        public MyCommand CommandOpenCloseCreateIncomeCategory { get; }
        public MyCommand CommandCreateIncomeCategory { get; }

        public OperationCreateExpenseCategory CreateExpenseCategory { get; set; }
        public MyCommand CommandOpenCloseCreateExpenseCategory { get; }
        public MyCommand CommandCreateExpenseCategory { get; }

        private int topPanelHeight;
        public int TopPanelHeight
        {
            get => topPanelHeight;
            set => SetField(ref topPanelHeight, value);
        }

        public MainWindowViewModel()
        {
            CreateWallet = new(() => { CommandCreateWallet?.OnCanExecuteChanged(); });
            CommandOpenCloseCreateWallet = new(_ =>
            {
                CreateIncomeCategory?.Hide();
                CreateExpenseCategory?.Hide();
                TopPanelHeight = CreateWallet.OpenClose();
            }, _ => true);
            CommandCreateWallet = new(_ =>
            {
                CreateWallet.Create();
            }, _ => CreateWallet.RefreshStates());


            CreateIncomeCategory = new(() => { CommandCreateIncomeCategory?.OnCanExecuteChanged(); });
            CommandOpenCloseCreateIncomeCategory = new(_ =>
            {
                CreateExpenseCategory?.Hide();
                CreateWallet?.Hide();
                TopPanelHeight = CreateIncomeCategory.OpenClose();
            }, _ => true);
            CommandCreateIncomeCategory = new(_ =>
            {
                CreateIncomeCategory.Create();
            }, _ => CreateIncomeCategory.RefreshStates());


            CreateExpenseCategory = new(() => { CommandCreateExpenseCategory?.OnCanExecuteChanged(); });
            CommandOpenCloseCreateExpenseCategory = new(_ =>
            {
                CreateIncomeCategory?.Hide();
                CreateWallet?.Hide();
                TopPanelHeight = CreateExpenseCategory.OpenClose();
            }, _ => true);
            CommandCreateExpenseCategory = new(_ =>
            {
                CreateExpenseCategory.Create();
            }, _ => CreateExpenseCategory.RefreshStates());


            TopPanelHeight = 47;
        }
    }
}
