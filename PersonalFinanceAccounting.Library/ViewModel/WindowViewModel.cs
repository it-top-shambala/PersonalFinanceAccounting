using PersonalFinanceAccounting.Library.ObjectsDbSet;

namespace PersonalFinanceAccounting.Library.ViewModel
{
    internal class WindowViewModel
    {
        public Dictionary<int, string> _categoryExpense { get; set; }
        public Dictionary<int, string> _categoryRefill { get; set; }
        public Dictionary<int, string> _valuta { get; set; }
        public Dictionary<int, string> _user { get; set; }
        public Dictionary<int, int> _wallet { get; set; }

        public WindowViewModel()
        {
            using (ObjDbSet db = new ObjDbSet())
            {
                db.Database.EnsureCreated();

                var cat_exp = db.categoriesExpense.ToList();
                foreach (var e in cat_exp)
                {
                    _categoryExpense.Add(e.Id, e.CatExp);
                }
                var cat_ref = db.categoriesRefill.ToList();
                foreach (var r in cat_ref)
                {
                    _categoryRefill.Add(r.Id, r.CatRef);
                }
                var val = db.valutas.ToList();
                foreach (var v in val)
                {
                    _valuta.Add(v.Id, v.NameValuta);
                }
                var wal = db.wallets.ToList();
                foreach (var w in wal)
                {

                    _wallet.Add(w.IdUser, w.IdUser);
                }
                var us = db.users.ToList();
                foreach (var u in us)
                {
                    _user.Add(u.Id, u.NameUser);
                }
            }
        }
    }
}
