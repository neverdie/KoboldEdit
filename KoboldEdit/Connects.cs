using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;



public class MysqlConnect
{
    public static void ConnectDB()
    {
        string connStr = "server=wow.game.kr.ua;user=test;database=kobold;port=3306;password=zxcv;";
        MySqlConnection conn = new MySqlConnection(connStr);
        try
        {
            Console.WriteLine("Connecting to MySQL...");
            conn.Open();
            // Perform databse operations
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        conn.Close();
        MessageBox.Show("Главное меню добавлено в окно " +
            "Испытайте его после нажатия OK.");
    }
}