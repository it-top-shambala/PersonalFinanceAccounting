
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
        public IEnumerable<Wallet> GetWallets()
        {
            using var connection = new SqliteConnection(connectionString);
            return connection.Query<Wallet>("SELECT * FROM tab_wallets");
        }
        public IEnumerable<Currency> GetCurrencies()
        {
            using var connection = new SqliteConnection(connectionString);
            return connection.Query<Currency>("SELECT * FROM tab_currency");
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
        public Wallet GetWallet(int id)
        {
            var query = "SELECT * FROM tab_wallets WHERE wallet_id=" + $"{id}";
            using var connection = new SqliteConnection(connectionString);
            return connection.QuerySingle<Wallet>(query);

        }
        public CategoryExpense GetCategoryExpense(int id)
        {
            var query = "SELECT * FROM tab_category_expense WHERE category_expense_id=" + $"{id}";
            using var connection = new SqliteConnection(connectionString);
            return connection.QuerySingle<CategoryExpense>(query);

        }
        public CategoryIncoming GetCategoryIncoming(int id)
        {
            var query = "SELECT * FROM tab_category_income WHERE category_income_id=" + $"{id}";
            using var connection = new SqliteConnection(connectionString);
            return connection.QuerySingle<CategoryIncoming>(query);

        }


        /// <summary>
        /// Методы добавления данных в бд
        /// </summary>
        /// <returns></returns>
        public int CreateWallet(Wallet wallet)
        {
            using var connection = new SqliteConnection(connectionString);
            var nameWallet = wallet.Name;
            var query = "SELECT EXISTS(SELECT * FROM tab_wallets WHERE name = " + $"{nameWallet})";
            var result = connection.QueryFirstOrDefault<string>(query);
            if (result == "true")
            {
                return -1;
            }
            else
            {
                query = "INSERT INTO tab_wallets (name,balance,currency_id) VALUES (@Name,@Balance,@IdCurrancy); SELECT CAST(SCOPE_IDENTITY() as int)";
                return connection.Query<int>(query, wallet).FirstOrDefault();
            }
        }
        public int CreateCategoryExpenses(CategoryExpense category)
        {
            using var connection = new SqliteConnection(connectionString);
            var nameCategory = category.Category;
            var query = "SELECT EXISTS(SELECT * FROM tab_category_expense WHERE name = " + $"{nameCategory})";
            var result = connection.QueryFirstOrDefault<string>(query);
            if (result == "true")
            {
                return -1;
            }
            else
            {
                query = "INSERT INTO tab_category_expense (name) VALUES (@Category); SELECT CAST(SCOPE_IDENTITY() as int)";
                return connection.Query<int>(query, category).FirstOrDefault();
            }
        }
        public int CreateCategoryIncomings(CategoryIncoming category)
        {
            using var connection = new SqliteConnection(connectionString);
            var nameCategory = category.Category;
            var query = "SELECT EXISTS(SELECT * FROM tab_category_income WHERE name = " + $"{nameCategory})";
            var result = connection.QueryFirstOrDefault<string>(query);
            if (result == "true")
            {
                return -1;
            }
            else
            {
                query = "INSERT INTO tab_category_income (name) VALUES (@Category); SELECT CAST(SCOPE_IDENTITY() as int)";
                return connection.Query<int>(query, category).FirstOrDefault();
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
        /// Методы измения данных
        /// </summary>
        public bool UpdateWallet(int id, string newName)
        {
            using var connection = new SqliteConnection(connectionString);
            var check = "SELECT EXISTS(SELECT * FROM tab_wallets WHERE name =" + $"{newName})";
            var result = connection.QueryFirstOrDefault<string>(check);
            if (result == "true")
            {
                return false;
            }
            else
            {
                var query = "UPDATE tab_wallets SET name = " + $"{newName} WHERE wallet_id = " + $"{id}";
                var res = connection.Execute(query);
                return res != 0;
            }
        }
        public bool UpdateCategoryExpense(int id, string newName)
        {
            using var connection = new SqliteConnection(connectionString);
            var check = "SELECT EXISTS(SELECT * FROM tab_category_expense WHERE name =" + $"{newName})";
            var result = connection.QueryFirstOrDefault<string>(check);
            if (result == "true")
            {
                return false;
            }
            else
            {
                var query = "UPDATE tab_category_expense SET name = " + $"{newName} WHERE category_expense_id = " + $"{id}";
                var res = connection.Execute(query);
                return res != 0;
            }
        }
        public bool UpdateCategoryIncoming(int id, string newName)
        {
            using var connection = new SqliteConnection(connectionString);
            var check = "SELECT EXISTS(SELECT * FROM tab_category_income WHERE name =" + $"{newName})";
            var result = connection.QueryFirstOrDefault<string>(check);
            if (result == "true")
            {
                return false;
            }
            else
            {
                var query = "UPDATE tab_category_income SET name = " + $"{newName} WHERE category_income_id = " + $"{id}";
                var res = connection.Execute(query);
                return res != 0;
            }
        }

        /// <summary>
        /// Методы транзакций
        /// </summary>
        public bool Income(int walletId, int categoryIncomeId, float summa)
        {
            using var connection = new SqliteConnection(connectionString);
            var queryInsert = "INSERT INTO tab_incoming (date_time,wallet_id,category_income_id,summa)" +
                "VALUES (datetime('now'),@WalletId,@category_income_id,@Summa)";
            var result = connection.Execute(queryInsert, new { WalletId = walletId, category_income_id = categoryIncomeId, Summa = summa });
            if (result == 0)
            {
                return false;
            }
            else
            {
                var queryUpdate = "UPDATE tab_wallets SET balance=balance+@Summa WHERE wallet_id=@WalletId";
                var res = connection.Execute(queryUpdate, new { Summa = summa, WalletId = walletId });
                return res != 0;
            }
        }
        public bool Expense(int walletId, int categoryExpensesId, float summa)
        {
            using var connection = new SqliteConnection(connectionString);
            var queryInsert = "INSERT INTO tab_expensing (date_time,wallet_id,category_expense_id,summa)" +
                "VALUES (datetime('now'),@WalletId,@category_expense_id,@Summa)";
            var result = connection.Execute(queryInsert, new { WalletId = walletId, category_expense_id = categoryExpensesId, Summa = summa });
            if (result == 0)
            {
                return false;
            }
            else
            {
                var queryUpdate = "UPDATE tab_wallets SET balance=balance-@Summa WHERE wallet_id=@WalletId";
                var res = connection.Execute(queryUpdate, new { Summa = summa, WalletId = walletId });
                return res != 0;
            }


        }

    }
}
