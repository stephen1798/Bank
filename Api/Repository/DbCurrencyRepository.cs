using System;

namespace Api.Repository
{
    public class DbCurrencyRepository
    {
        private CurrencyDBContext _db;
        public DbCurrencyRepository() => _db = new CurrencyDBContext();

        public void SaveCurrencyRate(Rate r)
        {
            var c = new CurrencyDbModel();
                c.currency = "USD";
                c.price = r.mid;
                c.rateDateTime = DateTime.Parse( r.effectiveDate);

            _db.CurrencyDbModels.Add(c);
            _db.SaveChanges();
            
        }

    }
}