CREATE TABLE tab_valuta(
    id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
    name TEXT,
    code TEXT
);

CREATE TABLE tab_category_refill(
    id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
    name TEXT
);

CREATE TABLE tab_category_expence(
    id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
    name TEXT
);

CREATE TABLE tab_wallets(
    id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
    name TEXT,
    amount REAL,
    id_valuta INTEGER,
    FOREIGN KEY (id_valuta)  REFERENCES tab_valuta (id)
);

CREATE TABLE tab_reffiling(
    id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
    date_Time TEXT,
    id_wallet INTEGER,
    id_category_refill INTEGER,
    sum INTEGER,
    FOREIGN KEY (id_category_refill)  REFERENCES tab_category_refill (id),
    FOREIGN KEY (id_wallet)  REFERENCES tab_wallets (id)
);

