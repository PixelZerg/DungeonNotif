using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonNotif
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Class1.autotp = !Class1.autotp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (comboBox1.SelectedIndex == 0)
            {
                List<UserControl1> u = new List<UserControl1>();
                //all
                int no = 0;
                foreach (var item in Data.Entries.ToArray())
                {
                    u.Add(new UserControl1());
                    u.Last().Set(no);
                    
                    no++;
                }
                flowLayoutPanel1.Controls.AddRange(u.ToArray());
            }
            if (comboBox1.SelectedIndex == 1)
            {
                int no = 0;
                foreach (var item in Data.Entries.ToArray())
                {
                    if (item.Difficulty == 1)
                    {
                        UserControl1 u = new UserControl1();
                        u.Set(no);
                        flowLayoutPanel1.Controls.Add(u);
                    }
                    no++;
                }
            }
            if (comboBox1.SelectedIndex == 2)
            {
                int no = 0;
                foreach (var item in Data.Entries.ToArray())
                {
                    if (item.Difficulty == 2)
                    {
                        UserControl1 u = new UserControl1();
                        u.Set(no);
                        flowLayoutPanel1.Controls.Add(u);
                    }
                    no++;
                }
            }
            if (comboBox1.SelectedIndex == 3)
            {
                int no = 0;
                foreach (var item in Data.Entries.ToArray())
                {
                    if (item.Difficulty == 3)
                    {
                        UserControl1 u = new UserControl1();
                        u.Set(no);
                        flowLayoutPanel1.Controls.Add(u);
                    }
                    no++;
                }
            }
            if (comboBox1.SelectedIndex == 4)
            {
                int no = 0;
                foreach (var item in Data.Entries.ToArray())
                {
                    if (item.Difficulty == 4)
                    {
                        UserControl1 u = new UserControl1();
                        u.Set(no);
                        flowLayoutPanel1.Controls.Add(u);
                    }
                    no++;
                }
            }
            if (comboBox1.SelectedIndex == 5)
            {
                int no = 0;
                foreach (var item in Data.Entries.ToArray())
                {
                    if (item.Difficulty == 5)
                    {
                        UserControl1 u = new UserControl1();
                        u.Set(no);
                        flowLayoutPanel1.Controls.Add(u);
                    }
                    no++;
                }
            }
        }
    }
}
