using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicManager
{
    public class Album
    {
        private int id;
        private string title;
        private string artist;
        private string picture;
        private int year;
        private List<Track> tracks;

        public int Id { get { return id; } }
        public string Title { get { return title; } }
        public string Artist { get { return artist; } }
        public string Picture { get { return picture; } }
        public int Year { get { return year; } }
        public List<Track> Tracks { get { return tracks; } set { tracks = value; } }

        public Album(int id, string title, string artist, string picture, int year, List<Track> tracks = null)
        {
            this.id = id;
            this.title = title;
            this.artist = artist;
            this.picture = picture;
            this.year = year;
            this.tracks = tracks;
        }

        public override string ToString()
        {
            return title + " by " + artist;
        }
    }
}
