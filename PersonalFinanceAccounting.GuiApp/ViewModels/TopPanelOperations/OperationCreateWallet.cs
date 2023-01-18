using System;
using System.Collections.Generic;
using PersonalFinanceAccounting.Library.Models;

namespace PersonalFinanceAccounting.GuiApp.ViewModels.TopPanelOperations
{
    public class OperationCreateWallet : OperationAbstract
    {
        private string? _sum;
        public string? Sum
        {
            get => _sum;
            set
            {
                RemoveLettersOrSymbols(ref value!);
                Cut(ref value!);
                if (SetField(ref _sum, value))
                {
                    RefreshState?.Invoke();
                }
            }
        }

        private Currancy? _selectedCurrency;
        public Currancy? SelectedCurrency
        {
            get => _selectedCurrency;
            set
            {
                if (SetField(ref _selectedCurrency, value))
                {
                    RefreshState?.Invoke();
                }
            }
        }

        public List<Currancy> Currencies { get; set; }

        public OperationCreateWallet(Action action) : base(action)
        {
            Currencies = new List<Currancy>(); //используем метод получения валют
        }

        protected override void Clear()
        {
            Name = string.Empty;
            Sum = string.Empty;
            SelectedCurrency = null;
        }

        public override void Create()
        {
            Clear();
            //используем метод для создания(добавления) нового кошелька
            //...CreateWallet(Name, Sum, SelectedCurrency.Id)
        }

        public override bool RefreshStates()
        {
            return !string.IsNullOrWhiteSpace(Name) && SelectedCurrency is not null;
        }

        private static void RemoveLettersOrSymbols(ref string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                if (str[0] is ',' or '0')
                {
                    str = str.Remove(0, 1);
                }

                for (var i = 0; i < str.Length; i++)
                {
                    if (!char.IsDigit(str[i]) && str[i] != ',')
                    {
                        str = str.Remove(i, 1);
                    }
                }

                if (str.Contains(','))
                {
                    for (var i = str.IndexOf(',') + 1; i < str.Length; i++)
                    {
                        if (str[i] == ',')
                        {
                            str = str.Remove(i, 1);
                        }
                    }
                }
            }
        }

        private static void Cut(ref string str)
        {
            if (str.Contains(',') && str.IndexOf(',') + 3 == str.Length - 1)
            {
                str = str.Remove(str.IndexOf(',') + 3);
            }
        }
    }
}
