using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDOCraftingCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Check if Blank
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("No Crafting Item Selected");
            }
            int cereals;
            cereals = Convert.ToInt32(textBox1.Text);
            cereals = int.Parse(textBox1.Text);
            //How many can you make
            int quikmafs = cereals / 5;
            //How many mineral loads
            int quikMineralMafs = quikmafs * 6;
            //How many sugar loads
            int quikSugarMafs = quikmafs * 1;
            //How many Leavaning agent
            int quickLeavaningAgentMafs = quikmafs * 2;
            //How many cereals
            int quikCerealMafs = quikmafs * 5;
            MessageBox.Show("You can make: " + quikmafs + Environment.NewLine + "You need: " + Environment.NewLine + "Cereals: " + quikCerealMafs + Environment.NewLine + "Mineral Waters: " + quikMineralMafs + Environment.NewLine + "Sugar: " + quikSugarMafs + Environment.NewLine + "Leavaning Agent: " + quickLeavaningAgentMafs);
        }
    }
}
