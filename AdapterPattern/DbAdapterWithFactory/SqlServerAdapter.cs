namespace DbAdapterWithFactory
{
    public class SqlServerAdapter : IDatabaseAdapter
    {
        private SqlServerDatabase adaptee = new SqlServerDatabase();
        public string ProviderName => adaptee.DbName;
    }
}
