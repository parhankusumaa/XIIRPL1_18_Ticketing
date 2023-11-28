using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql

namespace XIIRPL1_18_Ticketing
{
    internal class ComboBoxFunction
    {
        static NpgsqlConnection conn;
        static NpgsqlDataReader reader;

        public static void Set_ComboBox(string Query, string row, ComboBox box)
        {
            try
            {
                conn = koneksi.conn;
                conn.Open();
                NpgsqlCommand Command = new NpgsqlCommand(Query, conn);
                reader = Command.ExecuteReader();
                box.Items.Clear();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        box.Items.Add(reader[row]);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (reader != null) 
                 reader.Close();
                conn.Close();
            }
        }
    }
}
