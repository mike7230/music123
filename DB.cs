using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using log4net;

namespace music
{
    public static class DB
    {
        private static String DBHost = "mysyu.ddns.net";
        private static String DBUser = "music";
        private static String DBPassword = "music";
        private static String DBName = "music";
        private static String DBCharSet = "utf8";
        private static String DBTimeout = "1";
        private static MySqlConnection DBConnection = null;
        public static ILog Log = LogManager.GetLogger( "" );
        public static bool Connect = false;

        static DB()
        {
            try
            {
                if ( DBConnection == null )
                {
                    DBConnection = new MySqlConnection( String.Format( "server={0};uid={1};pwd={2};database={3};charset={4};Connection Timeout={5}" , DBHost , DBUser , DBPassword , DBName , DBCharSet , DBTimeout ) );
                    DBConnection.Open();
                    Connect = true;
                }
                Log.Debug( String.Format( "server={0};uid={1};pwd={2};database={3};charset={4}" , DBHost , DBUser , DBPassword , DBName , DBCharSet ) );
            }
            catch ( Exception e )
            {
                Log.Error( e.StackTrace );
            }
        }

        public static DataTable Select( String command )
        {
            DataTable result = new DataTable();
            try
            {
                result.Load( new MySqlCommand( command , DBConnection ).ExecuteReader() );
            }
            catch ( Exception e )
            {
                Log.Error( e.StackTrace );
            }
            return result;
        }

        public static int SQL( String command )
        {
            int result = -1;
            try
            {
                result = new MySqlCommand( command , DBConnection ).ExecuteNonQuery();
            }
            catch ( Exception e )
            {
                Log.Error( e.StackTrace );
            }
            return result;
        }

        public static void Close()
        {
            try
            {
                if ( DBConnection != null )
                {
                    DBConnection.Close();
                }
            }
            catch ( Exception e )
            {
                Log.Error( e.StackTrace );
            }
        }
    }
}
