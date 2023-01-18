namespace PersonalFinanceAccounting.GuiApp.ViewModels
{
    public class MainWindowViewModel : Notifier
    {
        private int topPanelHeight;
        public int TopPanelHeight
        {
            get => topPanelHeight;
            set => SetField(ref topPanelHeight, value);
        }
    }
}
