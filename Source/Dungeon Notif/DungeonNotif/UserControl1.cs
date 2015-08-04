using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonNotif
{
    public partial class UserControl1 : UserControl
    {
        private static int indexx;
        public UserControl1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            #region commented out

           // Console.WriteLine(indexx);
           // Console.WriteLine(pictureBox1.ImageLocation == Data.Entries[indexx].ImageURL);
           // Console.WriteLine("======");
            int no = 0;
            foreach (var entry in Data.Entries.ToArray())
            {
                if (entry.ImageURL == pictureBox1.ImageLocation)
                {
                    indexx = no;
                }
                no++;
            }
          //  Console.WriteLine(indexx);
          //  Console.WriteLine(pictureBox1.ImageLocation == Data.Entries[indexx].ImageURL);
          //  Console.WriteLine("======");
            Data.Entries[indexx] = new Data.Entry
            {
                Name = Data.Entries[indexx].Name,
                Difficulty = Data.Entries[indexx].Difficulty,
                ImageURL = Data.Entries[indexx].ImageURL,
                KeyWords = Data.Entries[indexx].KeyWords,
                Enabled = !Data.Entries[indexx].Enabled
            };
            bool enabled = Data.Entries[indexx].Enabled;
          //  Console.Write(Data.Entries[indexx].Name + " is now ");
          //  if (Data.Entries[indexx].Enabled) { Console.WriteLine("enabled"); } else { Console.WriteLine("disabled"); }
            if (Data.Entries[indexx].Enabled)
            {
                panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            }
            else
            {
                panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            }
            
            #endregion
        }

        public void Set(int index)
        {
            indexx = index;
            pictureBox1.ImageLocation = Data.Entries[index].ImageURL;
            label1.Text = Data.Entries[index].Name;
            pictureBox1.Load();
            int tmp = Data.Entries[index].Difficulty;
            while (tmp != 0)
            {
                PictureBox p = new PictureBox();
                p.ImageLocation = "http://i.imgur.com/0hzGJrP.png";
                p.SizeMode = PictureBoxSizeMode.CenterImage;
                p.Anchor = AnchorStyles.None;
                Size size = new Size();
                size.Height = 10;
                size.Width = 8;
                p.Size = size;
                flowLayoutPanel1.Controls.Add(p);
                tmp--;
            }
            if (Data.Entries[index].Enabled)
            {
                panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            }
            else
            {
                panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            }
        }
    }
}
