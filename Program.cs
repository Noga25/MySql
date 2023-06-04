using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;

namespace MySQL
{
    class Program
    {
        private MySqlConnection Connection;

        static void Main(string[] args)
        {
            string connstring = "Server=localhost; database=game; UID=root; password=noga0000";
            MySqlConnection connection = new MySqlConnection(connstring);
            connection.Open();
            Console.WriteLine(connection.State);

            string query = "SELECT Name,Health FROM players";
            var cmd = new MySqlCommand(query, connection);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string someStringFromColumnZero = reader.GetString(0);
                string someStringFromColumnOne = reader.GetString(1);
                Console.WriteLine(someStringFromColumnZero + "," + someStringFromColumnOne);
            }
            connection.Close();
        }
    }
}
