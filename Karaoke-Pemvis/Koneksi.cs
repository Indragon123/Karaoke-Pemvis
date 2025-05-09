
using MySql.Data.MySqlClient;

public class Koneksi
{
    public static MySqlConnection GetConnection()
    {
        return new MySqlConnection("server=localhost;database=KaraokeDB;user=root;password=;");
    }
}
