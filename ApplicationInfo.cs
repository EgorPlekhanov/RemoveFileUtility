using Microsoft.Extensions.Configuration;

namespace RemoveFileUtility
{
    internal class ApplicationInfo
    {
        static ApplicationInfo()
        {
            Unknown = new ApplicationInfo
            {
                TargetDBMS = "Unknown DBMS",
                ConnectionString = "Unknown connection string"
            };
        }
        public static ApplicationInfo Unknown { get; set; }

        /// <summary>
        /// Connection string to database
        /// </summary>
        public string ConnectionString { get; set; }

        /// <summary>
        /// Target DBMS
        /// </summary>
        /// <example>MSSQL, PostgreSQL</example>
        public string TargetDBMS { get; set; }
    }
}