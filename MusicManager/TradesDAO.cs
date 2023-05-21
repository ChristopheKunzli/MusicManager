using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace MusicManager
{
    public class TradesDAO
    {
        public TradesDAO() { }

        public MySqlConnection openConnection()
        {
            string connectionString = "SERVER=127.0.0.1; PORT=3306; DATABASE=stats; UID=stats; PASSWORD=Pa$$w0rd";
            return new MySqlConnection(connectionString);
        }

        public List<Trade> getTradeList()
        {
            List<Trade> list = new List<Trade>();

            try
            {
                using(MySqlConnection connection = openConnection())
                {
                    connection.Open();

                    string txt = 
                        "SELECT * " +
                        "FROM trades " +
                        "WHERE YEAR(date) >= YEAR(curdate()) - 5 " +
                        //"AND amount <= 50 " +
                        "ORDER BY date";
                    MySqlCommand cmd = new MySqlCommand(txt, connection);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["id"]);
                            double amount = Convert.ToDouble(reader["amount"]);
                            DateTime date = Convert.ToDateTime(reader["date"]);

                            list.Add(new Trade(id, amount, date));
                        }
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return list;
        }
    }
}
