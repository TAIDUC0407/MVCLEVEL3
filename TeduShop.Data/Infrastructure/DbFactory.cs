namespace TeduShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private TeduShopDbContext dbcontext;

        public TeduShopDbContext Init()
        {
            return dbcontext ?? (dbcontext = new TeduShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbcontext != null)
            {
                dbcontext.Dispose();
            }
        }
    }
}