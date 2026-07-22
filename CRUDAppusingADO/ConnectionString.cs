namespace CRUDAppusingADO
{
    public  static class ConnectionString
    {
        private static string cs = "Server=DESKTOP-L36IGHI\\SQLEXPRESS;Database=CrudADOdb;Trusted_Connection=True;TrustServerCertificate=True;";
        public static string dbcs { get => cs; }
    }
}
