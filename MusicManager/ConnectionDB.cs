using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicManager
{
    public class ConnectionDB
    {
        public ConnectionDB() { }

        private MySqlConnection openConnection()
        {
            string connectionString = "SERVER=localhost; PORT=3306; DATABASE=music; UID=music_viewer; PASSWORD=Pa$$w0rd";
            return new MySqlConnection(connectionString);
        }

        public List<Album> getAlbums()
        {
            List<Album> list = new List<Album>();

            using(MySqlConnection connection = openConnection())
            {
                try
                {
                    string cmdText = "SELECT * FROM albums";
                    MySqlCommand cmd = new MySqlCommand(cmdText, connection); ;
                    
                    connection.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["ID"]);
                            string title = reader["TITLE"].ToString();
                            string artist = reader["ARTIST"].ToString();
                            string imageLink = reader["IMAGE_LINK"].ToString();
                            int year = Convert.ToInt32(reader["YEAR"]);

                            Album album = new Album(id, title, artist, imageLink, year);

                            album.Tracks = getTracks(album);

                            list.Add(album);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return list;
        }

        public List<Track> getTracks(Album album)
        {
            List<Track> list = new List<Track>();

            using (MySqlConnection connection = openConnection())
            {
                try
                {
                    string cmdText = $"SELECT * FROM tracks WHERE ALBUM_ID = {album.Id}";
                    MySqlCommand cmd = new MySqlCommand(cmdText, connection); ;

                    connection.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["ID"]);
                            string title = reader["TITLE"].ToString();
                            string link = reader["LINK"].ToString();

                            list.Add(new Track(id, title, link));
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return list;
        }
    }
}
