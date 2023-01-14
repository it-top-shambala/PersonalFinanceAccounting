# PersonalFinanceAccounting

## Словарь названий сущностей
валюта - currency

доход - income

расход - expense

кошелёк - wallet

остаток - balance

## Диаграмма модулей

```mermaid
graph
    Model --> ViewModel

    DataBase --> Model

    subgraph UI
        ViewModel --> View
    end

    subgraph Library
        extend_API
        Model --> intern_API
        Model --> db_API
    end
```

## Диаграмма таблиц БД

```mermaid
classDiagram
direction BT
class tab_category_expense {
   text name
   integer category_expense_id
}
class tab_category_income {
   text name
   integer category_income_id
}
class tab_currency {
   text name
   text code
   integer currency_id
}
class tab_expensing {
   text date_time
   integer wallet_id
   integer category_expense_id
   real summa
   integer income_id
}
class tab_incoming {
   text date_time
   integer wallet_id
   integer category_income_id
   real summa
   integer income_id
}
class tab_wallets {
   text name
   real balance
   integer currency_id
   integer wallet_id
}

tab_expensing  -->  tab_category_expense : category_expense_id
tab_expensing  -->  tab_wallets : wallet_id
tab_incoming  -->  tab_category_income : category_income_id
tab_incoming  -->  tab_wallets : wallet_id
tab_wallets  -->  tab_currency : currency_id
```
## Диаграмма классов модели данных

```mermaid
classDiagram 
    class Currency{
      +string Code
      +string Name
    }
    class Wallet{
        +string Name
        +Currency Currency
        +double Ballance
        +Incoming(double, CategoryIncome) void
        +Expensing(double, CategoryExpense) bool
    }
    Currency *-- Wallet

    class CategoryIncome{
        +string Name
    }
    CategoryIncome *-- Wallet

    class CategoryExpense{
        +string Name
    }
    CategoryExpense *-- Wallet
```
