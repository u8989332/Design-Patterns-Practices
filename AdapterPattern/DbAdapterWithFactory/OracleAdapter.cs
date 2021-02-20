namespace DbAdapterWithFactory
{
    public class OracleAdapter : IDatabaseAdapter
    {
        private OracleDatabase adaptee = new OracleDatabase();
        public string ProviderName => adaptee.GetDatabaseName();
    }
}
