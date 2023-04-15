using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicManager
{
    public class Track
    {
        private int id;
        private string title;
        private string link;

        public int Id { get { return id; } }
        public string Title { get { return title; } }
        public string Link { get { return link; } }

        public Track(int id, string title, string link)
        {
            this.id = id;
            this.title = title;
            this.link = link;
        }

        public override string ToString()
        {
            return title;
        }
    }
}
