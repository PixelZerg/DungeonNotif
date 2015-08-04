using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonNotif
{
    public class Data
    {
        public struct Entry
        {
            public string Name;
            public string[] KeyWords;
            public bool Enabled;
            public int Difficulty;
            public string ImageURL;
        }
        public static List<Entry> Entries = new List<Entry>();
    }
}
