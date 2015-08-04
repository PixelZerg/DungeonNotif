using Lib_K_Relay;
using Lib_K_Relay.Interface;
using Lib_K_Relay.Networking;
using Lib_K_Relay.Networking.Packets;
using Lib_K_Relay.Networking.Packets.Client;
using Lib_K_Relay.Networking.Packets.DataObjects;
using Lib_K_Relay.Networking.Packets.Server;
using Lib_K_Relay.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;
using System.Globalization;
namespace DungeonNotif{public class Class1 : IPlugin
{
        #region Define IPlugin
        public string GetAuthor(){ return "PixelZerg"; }public string GetName(){ return "Dungeon Notif"; }
        public string GetDescription(){ return "If someone says a dungeon name in the chat. You'll be sure to know!"; }
        public string[] GetCommands(){ return new string[] { "/dn (toggle on/off)", "/dn settings (access the dungeon notif settings)" }; }
        #endregion
        public static bool enabled = true;
        public static bool autotp = false;
        public void Initialize(Proxy proxy)
        {
            proxy.HookCommand("/dn", OnC);
            proxy.HookPacket(PacketType.TEXT, T);


            #region Code Generated With PixelZerg's WebScraper
            #region Pirate Cave
            Data.Entries.Add(new Data.Entry
            {
                Name = "Pirate Cave",
                Difficulty = 1,
                Enabled = true, //Default
                ImageURL = "https://i.imgur.com/mpQLemW.png",
                KeyWords = new string[] {
"pcave",
"pirate cave",
}
            });
            #endregion
            #region Forest Maze
            Data.Entries.Add(new Data.Entry
            {
                Name = "Forest Maze",
                Difficulty = 1,
                Enabled = true, //Default
                ImageURL = "https://i.imgur.com/sb8e4YJ.png",
                KeyWords = new string[] {
"maze",
}
            });
            #endregion
            #region Spider Den
            Data.Entries.Add(new Data.Entry
            {
                Name = "Spider Den",
                Difficulty = 1,
                Enabled = true, //Default
                ImageURL = "https://i.imgur.com/H88LAt4.png",
                KeyWords = new string[] {
"den",
}
            });
            #endregion
            #region Snake Pit
            Data.Entries.Add(new Data.Entry
            {
                Name = "Snake Pit",
                Difficulty = 1,
                Enabled = true, //Default
                ImageURL = "https://i.imgur.com/z7KMqgq.gif",
                KeyWords = new string[] {
"snack pot",
"pit",
}
            });
            #endregion
            #region Beachzone
            Data.Entries.Add(new Data.Entry
            {
                Name = "Beachzone",
                Difficulty = 1,
                Enabled = true, //Default
                ImageURL = "http://static.drips.pw/rotmg/wiki/Environment/Portals/Beachzone%20Portal.png",
                KeyWords = new string[] {
"beach",
}
            });
            #endregion
            #region Forbidden Jungle
            Data.Entries.Add(new Data.Entry
            {
                Name = "Forbidden Jungle",
                Difficulty = 2,
                Enabled = true, //Default
                ImageURL = "https://i.imgur.com/5NmNR0l.png",
                KeyWords = new string[] {
"jungle",
"forbidden",
}
            });
            #endregion
            #region Sprite World
            Data.Entries.Add(new Data.Entry
            {
                Name = "Sprite World",
                Difficulty = 2,
                Enabled = true, //Default
                ImageURL = "https://i.imgur.com/tvILM8B.png",
                KeyWords = new string[] {
"sprite",
"dex world",
}
            });
            #endregion
            #region Candyland Hunting Grounds
            Data.Entries.Add(new Data.Entry
            {
                Name = "Candyland Hunting Grounds",
                Difficulty = 3,
                Enabled = true, //Default
                ImageURL = "http://static.drips.pw/rotmg/wiki/Environment/Portals/Candyland%20Portal.png",
                KeyWords = new string[] {
"cland",
"candy land",
}
            });
            #endregion
            #region Haunted Cemetery
            Data.Entries.Add(new Data.Entry
            {
                Name = "Haunted Cemetery",
                Difficulty = 3,
                Enabled = true, //Default
                ImageURL = "https://i.imgur.com/8NcxYGb.png",
                KeyWords = new string[] {
"cem",
"cemetary",
"cemeterey",
}
            });
            #endregion
            #region Undead Lair
            Data.Entries.Add(new Data.Entry
            {
                Name = "Undead Lair",
                Difficulty = 3,
                Enabled = true, //Default
                ImageURL = "https://i.imgur.com/qim0En4.gif",
                KeyWords = new string[] {
"udl",
}
            });
            #endregion
            #region Abyss of Demons
            Data.Entries.Add(new Data.Entry
            {
                Name = "Abyss of Demons",
                Difficulty = 4,
                Enabled = true, //Default
                ImageURL = "https://i.imgur.com/EuIPzaA.png",
                KeyWords = new string[] {
"abby",
"aby",
"abyss",
"abbyss",
}
            });
            #endregion
            #region Davy Jones's Locker
            Data.Entries.Add(new Data.Entry
            {
                Name = "Davy Jones's Locker",
                Difficulty = 4,
                Enabled = true, //Default
                ImageURL = "http://static.drips.pw/rotmg/wiki/Environment/Portals/Davy%20Jones's%20Locker%20Portal.png",
                KeyWords = new string[] {
"davy",
}
            });
            #endregion
            #region Lair of Draconis
            Data.Entries.Add(new Data.Entry
            {
                Name = "Lair of Draconis",
                Difficulty = 4,
                Enabled = true, //Default
                ImageURL = "https://www.realmeye.com/s/a/img/wiki/Lair%20of%20Draconis%20Portal.gif",
                KeyWords = new string[] {
"lod",
}
            });
            #endregion
            #region Manor of the Immortals
            Data.Entries.Add(new Data.Entry
            {
                Name = "Manor of the Immortals",
                Difficulty = 4,
                Enabled = true, //Default
                ImageURL = "https://i.imgur.com/EopMddF.png",
                KeyWords = new string[] {
"manor",
}
            });
            #endregion
            #region The Puppet Master's Theatre
            Data.Entries.Add(new Data.Entry
            {
                Name = "The Puppet Master's Theatre",
                Difficulty = 4,
                Enabled = true, //Default
                ImageURL = "https://i.imgur.com/HYyyJo7.png",
                KeyWords = new string[] {
"puppet",
"theatre",
}
            });
            #endregion
            #region The Crawling Depths
            Data.Entries.Add(new Data.Entry
            {
                Name = "The Crawling Depths",
                Difficulty = 5,
                Enabled = true, //Default
                ImageURL = "https://i.imgur.com/WCgHcTj.png",
                KeyWords = new string[] {
"cdepths",
}
            });
            #endregion
            #region Deadwater Docks
            Data.Entries.Add(new Data.Entry
            {
                Name = "Deadwater Docks",
                Difficulty = 5,
                Enabled = true, //Default
                ImageURL = "https://i.imgur.com/FXZ8JKo.png",
                KeyWords = new string[] {
"docks",
"deadwater",
}
            });
            #endregion
            #region Ice Cave
            Data.Entries.Add(new Data.Entry
            {
                Name = "Ice Cave",
                Difficulty = 5,
                Enabled = true, //Default
                ImageURL = "http://static.drips.pw/rotmg/wiki/Environment/Portals/Ice%20Cave%20Portal.png",
                KeyWords = new string[] {
"ice cave",
"cave",
}
            });
            #endregion
            #region Mad Lab
            Data.Entries.Add(new Data.Entry
            {
                Name = "Mad Lab",
                Difficulty = 5,
                Enabled = true, //Default
                ImageURL = "https://i.imgur.com/KgEpI5j.gif",
                KeyWords = new string[] {
"lab",
}
            });
            #endregion
            #region Ocean Trench
            Data.Entries.Add(new Data.Entry
            {
                Name = "Ocean Trench",
                Difficulty = 5,
                Enabled = true, //Default
                ImageURL = "https://i.imgur.com/81QgQXX.png",
                KeyWords = new string[] {
"trench",
" ot",
}
            });
            #endregion
            #region The Shatters
            Data.Entries.Add(new Data.Entry
            {
                Name = "The Shatters",
                Difficulty = 5,
                Enabled = true, //Default
                ImageURL = "https://i.imgur.com/xsoxbc8.png",
                KeyWords = new string[] {
"shatters",
}
            });
            #endregion
            #region Tomb of the Ancients
            Data.Entries.Add(new Data.Entry
            {
                Name = "Tomb of the Ancients",
                Difficulty = 5,
                Enabled = true, //Default
                ImageURL = "https://i.imgur.com/9ovOSx3.png",
                KeyWords = new string[] {
"tomb",
}
            });
            #endregion
            #region Woodland Labyrinth
            Data.Entries.Add(new Data.Entry
            {
                Name = "Woodland Labyrinth",
                Difficulty = 5,
                Enabled = true, //Default
                ImageURL = "https://i.imgur.com/Quf5AqP.png",
                KeyWords = new string[] {
"woodland",
}
            });
            #endregion
            #region Oryx's Castle
            Data.Entries.Add(new Data.Entry
            {
                Name = "Oryx's Castle",
                Difficulty = 4,
                Enabled = true, //Default
                ImageURL = "http://s17.postimg.org/u6ujfpxu3/mp_QLem_W.png",
                KeyWords = new string[] {
"Castle",
"o1",
"oryx1",
}
            });
            #endregion
            #region Wine Cellar
            Data.Entries.Add(new Data.Entry
            {
                Name = "Wine Cellar",
                Difficulty = 5,
                Enabled = true, //Default
                ImageURL = "http://static.drips.pw/rotmg/wiki/Environment/Portals/Locked%20Wine%20Cellar%20Portal.png",
                KeyWords = new string[] {
"cellar",
"o2",
"oryx2",
"wc",
}
            });
            #endregion
            #region Lair of Shaitan
            Data.Entries.Add(new Data.Entry
            {
                Name = "Lair of Shaitan",
                Difficulty = 5,
                Enabled = true, //Default
                ImageURL = "https://i.imgur.com/pUgvoRm.png",
                KeyWords = new string[] {
"shaitan",
}
            });
            #endregion
            #endregion

        }

        public static void OnC(Client client, string command, string[] args)
        { try { if (args[0] == "settings") PluginUtils.ShowGUI(new Form1()); } 
        catch { enabled = !enabled; Console.WriteLine("[DungeonNotif] DungeonNotif is now " + enabled); } }

        public static int GetColor(int difficulty)
        {
            //99FF33
            //00FFFF
            //FFFF00
            //FF8000
            //FF0000
            if (difficulty > 0 && difficulty < 6)
            {
                if (difficulty == 1)
                {
                    return 0x99FF33;
                }
                if (difficulty == 2)
                {
                    return 0x00FFFF;
                }
                if (difficulty == 3)
                {
                    return 0xFFFF00;
                }
                if (difficulty == 4)
                {
                    return 0xFF8000;
                }
                if (difficulty == 5)
                {
                    return 0xFF0000;
                }
            }
            return 0;
        }
        private void T(Client client, Packet packet)
        {if (enabled == true) { 
            TextPacket t = (TextPacket)packet;
            bool found = false;
            string foundname = "NaN";
            int founddifficulty = 69;
            foreach (var Entry in Data.Entries.ToArray())
            {if (Entry.Enabled){
                foreach (var KeyWord in Entry.KeyWords)
                {
                    if (t.Text.ToLower().Contains(KeyWord.ToLower()) || t.Text.ToLower().Contains(Entry.Name))
                    while (foundname == "NaN") { foundname = Entry.Name; founddifficulty = Entry.Difficulty; } found = true;
                }
            }}
            if (found)
            {
                if (foundname != "NaN")
                {
                    client.SendToClient(PluginUtils.CreateNotification(client.ObjectId,GetColor(founddifficulty), foundname + " called!"));
                    client.SendToClient(PluginUtils.CreateOryxNotification(t.Name, t.Text)); found = true;
                    if (t.Name != client.PlayerData.Name) t.Send = false;
                    System.Media.SystemSounds.Exclamation.Play();
                    if (autotp)
                    {
                        PlayerTextPacket p = (PlayerTextPacket)Packet.Create(PacketType.PLAYERTEXT);
                        p.Text = "/teleport " + t.Name;
                        client.SendToServer(p);
                    }
                }
            }
        }}
}}
