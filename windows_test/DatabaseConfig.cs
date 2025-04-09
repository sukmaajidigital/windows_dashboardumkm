namespace windows_test
{
    public static class DatabaseHelper
    {
        public static string GetConnectionString()
        {
            var server = Environment.GetEnvironmentVariable("DB_SERVER");
            var port = Environment.GetEnvironmentVariable("DB_PORT");
            var uid = Environment.GetEnvironmentVariable("DB_USER");
            var pwd = Environment.GetEnvironmentVariable("DB_PASSWORD");
            var database = Environment.GetEnvironmentVariable("DB_NAME");

            return $"server={server};port={port};uid={uid};pwd={pwd};database={database};";
        }
    }
}
