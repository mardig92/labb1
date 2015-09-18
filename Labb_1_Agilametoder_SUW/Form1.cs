using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labb_1_Agilametoder_SUW
{
    public partial class Form1 : Form
    {
        List<String> Addfrends = new List<string>();
        public Form1()
        {
            InitializeComponent();
            Addfrends.Add("Namn     Mejl     Nummer");
            Addfrends.Add("Bengt     benga55@gmail.com     0701234567");
            Addfrends.Add("Peter     ptr@hotspot.com     0701234576");
            Addfrends.Add("Lina     lina_w@gmail.com     0701239654");
            Addfrends.Add("Ahmed     ahmed_ahmed@gmail.com     0707654321");
            Addfrends.Add("Angelica     angelangelica@gmail.com     0701212125");
            Addfrends.Add("Olof     olof_olofsson5@gmail.com     0702223336");
            Addfrends.Add("Clara     stensson_c@gmail.com     0730456789");
            Addfrends.Add("Stina     stinastinastinastina@hotmail.com     0700554412");
            Addfrends.Add("Bertil     beritochbertil@telia.com     0700000258");
            Addfrends.Add("annita     xyx@yahoo.com     070567890");
            Addfrends.Add("mardig     hfdygfu@.com     0864667654");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Addfrends.Add(textBox1.Text + "     " + textBox2.Text + "     " + textBox3.Text);
            Stuff();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Addfrends.Add(textBox1.Text + "     " + textBox2.Text + "     " + textBox3.Text);
            Stuff();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0; while (i < Addfrends.Count)
            {
                listBox1.Items.Add(Addfrends.ElementAt(i)); i++;
            }
            Stuff();
        }
        private void Stuff()
        {
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string str = textBox4.Text;int i = 0;
            while (i < Addfrends.Count)
            {
                if (Addfrends.ElementAt(i).Contains(str)) { MessageBox.Show("Hittade: " + Addfrends.ElementAt(i)); i++; }
                else
                {MessageBox.Show("Nope"); i++;}}
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
