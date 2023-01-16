CREATE TABLE tab_currency(
    currency_id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
    name TEXT NOT NULL,
    code TEXT NOT NULL
);

CREATE TABLE tab_category_income(
    category_income_id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
    name TEXT NOT NULL
);

CREATE TABLE tab_category_expense(
    category_expense_id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
    name TEXT NOT NULL
);

CREATE TABLE tab_wallets(
    wallet_id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
    name TEXT NOT NULL,
    balance REAL NULL,
    currency_id INTEGER NOT NULL,
    FOREIGN KEY (currency_id) REFERENCES tab_currency (currency_id)
        ON DELETE NO ACTION
        ON UPDATE NO ACTION
);

CREATE TABLE tab_incoming(
    income_id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
    date_Time TEXT NOT NULL,
    wallet_id INTEGER NOT NULL,
    category_income_id INTEGER NOT NULL,
    summa REAL NOT NULL,
    FOREIGN KEY (income_id)  REFERENCES tab_category_income (category_income_id)
        ON DELETE NO ACTION
        ON UPDATE NO ACTION,
    FOREIGN KEY (wallet_id)  REFERENCES tab_wallets (wallet_id)
        ON DELETE NO ACTION
        ON UPDATE NO ACTION
);

CREATE TABLE tab_expensing(
    expense_id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
    date_time TEXT NOT NULL,
    wallet_id INTEGER NOT NULL,
    category_expense_id INTEGER NOT NULL,
    summa INTEGER NOT NULL,
    FOREIGN KEY (category_expense_id)  REFERENCES tab_category_expense (category_expense_id)
        ON DELETE NO ACTION
        ON UPDATE NO ACTION,
    FOREIGN KEY (wallet_id)  REFERENCES tab_wallets (wallet_id)
        ON DELETE NO ACTION
        ON UPDATE NO ACTION
);

