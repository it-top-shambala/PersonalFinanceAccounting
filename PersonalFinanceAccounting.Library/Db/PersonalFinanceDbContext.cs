
using System.Configuration;
using Dapper;
using Microsoft.Data.Sqlite;
using PersonalFinanceAccounting.Library.Models;

namespace PersonalFinanceAccounting.Library.Db
{
    public class PersonalFinanceDbContext : IPersonalFinance
    {
        private readonly string connectionString;
        public PersonalFinanceDbContext()
        {
            connectionString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
        }
        /// <summary>
        /// Методы полуения данных из бд
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Wallet> GetWallets()
        {
            using var connection = new SqliteConnection(connectionString);
            return connection.Query<Wallet>("SELECT * FROM tab_wallets");
        }
        public IEnumerable<Currancy> GetCurrancies()
        {
            using var connection = new SqliteConnection(connectionString);
            return connection.Query<Currancy>("SELECT * FROM tab_currency");
        }
        public IEnumerable<CategoryExpense> GetCategoryExpenses()
        {
            using var connection = new SqliteConnection(connectionString);
            return connection.Query<CategoryExpense>("SELECT * FROM tab_category_expense");
        }
        public IEnumerable<CategoryIncoming> GetCategoryIncomings()
        {
            using var connection = new SqliteConnection(connectionString);
            return connection.Query<CategoryIncoming>("SELECT * FROM tab_category_income");
        }


        /// <summary>
        /// Методы добавления данных в бд
        /// </summary>
        /// <returns></returns>
        public bool CreateWallet(Wallet wallet)
        {
            using var connection = new SqliteConnection(connectionString);
            var nameWallet = wallet.Name;
            var query = "SELECT EXISTS(SELECT * FROM tab_wallets WHERE name = )" + $"{nameWallet}";
            var result = connection.QueryFirstOrDefault<string>(query);
            if (result == "1")
            {
                return false;
            }
            else
            {
                query = "INSERT INTO tab_wallets (name,balance,currency_id) VALUES (@Name,@Balance,@IdCurrancy)";
                _ = connection.Execute(query, wallet);
                return true;
            }
        }
        public bool CreateCategoryExpenses(CategoryExpense category)
        {
            using var connection = new SqliteConnection(connectionString);
            var nameCategory = category.Category;
            var query = "SELECT EXISTS(SELECT * FROM tab_category_expense WHERE name = )" + $"{nameCategory}";
            var result = connection.QueryFirstOrDefault<string>(query);
            if (result == "1")
            {
                return false;
            }
            else
            {
                query = "INSERT INTO tab_category_expense (name) VALUES (@Category)";
                _ = connection.Execute(query, category);
                return true;
            }
        }
        public bool CreateCategoryIncomings(CategoryIncoming category)
        {
            using var connection = new SqliteConnection(connectionString);
            var nameCategory = category.Category;
            var query = "SELECT EXISTS(SELECT * FROM tab_category_income WHERE name = )" + $"{nameCategory}";
            var result = connection.QueryFirstOrDefault<string>(query);
            if (result == "1")
            {
                return false;
            }
            else
            {
                query = "INSERT INTO tab_category_income (name) VALUES (@Category)";
                _ = connection.Execute(query, category);
                return true;
            }
        }

        /// <summary>
        /// Методы удаления данных из бд
        /// </summary>
        public void DeleteWallet(int id)
        {
            using var connection = new SqliteConnection(connectionString);
            var query = "DELETE FROM tab_wallets WHERE wallet_id= @Id";
            _ = connection.Execute(query, new { Id = id });
        }
        public void DeleteCategoryExpenses(int id)
        {
            using var connection = new SqliteConnection(connectionString);
            var query = "DELETE FROM tab_category_expense WHERE category_expense_id= @Id";
            _ = connection.Execute(query, new { Id = id });
        }
        public void DeleteCategoryIncomings(int id)
        {
            using var connection = new SqliteConnection(connectionString);
            var query = "DELETE FROM tab_category_income WHERE category_income_id= @Id";
            _ = connection.Execute(query, new { Id = id });
        }

        /// <summary>
        /// Методы транзакций
        /// </summary>
        public void Income(int walletId, int categoryIncomeId, float summa)
        {
            using var connection = new SqliteConnection(connectionString);
            var queryUpdate = "UPDATE tab_wallets SET balance=balance+@Summa WHERE wallet_id=@WalletId";
            _ = connection.Execute(queryUpdate, new { Summa = summa, WalletId = walletId });

            var queryInsert = "INSERT INTO tab_incoming (date_time,wallet_id,category_income_id,summa)" +
                "VALUES (date('now'),@WalletId,@category_income_id,@Summa)";
            _ = connection.Execute(queryInsert, new { WalletId = walletId, category_income_id = categoryIncomeId, Summa = summa });

        }
        public void Expense(int walletId, int categoryExpensesId, float summa)
        {
            using var connection = new SqliteConnection(connectionString);
            var queryUpdate = "UPDATE tab_wallets SET balance=balance-@Summa WHERE wallet_id=@WalletId";
            _ = connection.Execute(queryUpdate, new { Summa = summa, WalletId = walletId });

            var queryInsert = "INSERT INTO tab_expensing (date_time,wallet_id,category_expense_id,summa)" +
                "VALUES (date('now'),@WalletId,@category_expense_id,@Summa)";
            _ = connection.Execute(queryInsert, new { WalletId = walletId, category_expense_id = categoryExpensesId, Summa = summa });
        }
       
    }
}
