using PersonalFinanceAccounting.Library.Models;

namespace PersonalFinanceAccounting.Library.Db
{
    public interface IPersonalFinance
    {
        List<Wallet> GetWallets();
        List<Currancy> GetCurrancies();
        List<CategoryExpense> GetCategoryExpenses();
        List<CategoryIncoming> GetCategoryIncomings();

        bool CreateWallet(Wallet wallet);
        bool CreateCategoryExpenses(CategoryExpense category);
        bool CreateCategoryIncomings(CategoryIncoming category);

        void DeleteWallet(int id);
        void DeleteCategoryExpenses(int id);
        void DeleteCategoryIncomings(int id);

        void Income(int walletId, int categoryIncomeId, float summa);
        void Expense(int walletId, int categoryExpensesId, float summa);
    }
}
