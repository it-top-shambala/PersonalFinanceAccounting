using System;

namespace PersonalFinanceAccounting.GuiApp.ViewModels.TopPanelOperations
{
    public class OperationCreateExpenseCategory : OperationAbstract
    {
        public OperationCreateExpenseCategory(Action action) : base(action) { }

        public override void Create()
        {
            Clear();
            //используем метод для создания(добавления) новой категории
        }
    }
}
