using PersonalFinanceAccounting.Library.Models;

namespace PersonalFinanceAccounting.Library.Db
{
    public interface IPersonalFinance
    {
        IEnumerable<Wallet> GetWallets();
        IEnumerable<Currency> GetCurrencies();
        IEnumerable<CategoryExpense> GetCategoryExpenses();
        IEnumerable<CategoryIncoming> GetCategoryIncomings();
        Wallet GetWallet(int id);
        CategoryExpense GetCategoryExpense(int id);
        CategoryIncoming GetCategoryIncoming(int id);
        List<LogOperation> GetLog(int idWallet);

        int CreateWallet(Wallet wallet);
        int CreateCategoryExpenses(CategoryExpense category);
        int CreateCategoryIncomings(CategoryIncoming category);

        void DeleteWallet(int id);
        void DeleteCategoryExpenses(int id);
        void DeleteCategoryIncomings(int id);

        bool UpdateWallet(int id, string newName);
        bool UpdateCategoryExpense(int id, string newName);
        bool UpdateCategoryIncoming(int id, string newName);

        bool Income(int walletId, int categoryIncomeId, float summa);
        bool Expense(int walletId, int categoryExpensesId, float summa);
    }
}
