using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Projektuppgift2_Sekvensiell_Sökning
{
    public partial class Form1 : Form
    {
        int[] arList;
        List<int> shuffleList;
        bool kortlek = false;
        Card card = new Card();
        Graphics g;
        bool flip = false;
        int counter = 0;
        int xPostition = 80;
        int antal = 9;
     
        public Form1()
        {
            InitializeComponent();
            btnSekventiell.Enabled = false;
            tbxSöktValör.Enabled = true;
            txResultet.Text = "";
            txResultet.Visible = false;
            arList = new int[antal];
            for (int i = 1; i < antal + 1; i++)
            {
                arList[i - 1] = i+1;
            }
            shuffle(arList);
            kortlek = true;

        }

        private void btnSekventiell_Click(object sender, EventArgs e)
        {
            try
            {
                int checkNumber = int.Parse(tbxSöktValör.Text);
                if (checkNumber < 2 || checkNumber > 10)
                {
                    labNote.Visible = true;
                }
                else
                {
                    tbxSöktValör.Enabled = false;
                    kortlek = true;
                    flip = true;
                    counter++;
                    Invalidate();
                }
            }
            catch
            {
                labNote.Visible = true;
            }

        }

        private void btnBlanda_Click(object sender, EventArgs e)
        {
            labNote.Visible = false;
            tbxSöktValör.Enabled = true;
            tbxSöktValör.Text = "";
            tbxIndex.Text = "";
            shuffle(arList);
            kortlek = true;
            counter = 0;
            
            //txResultet.Text = "";
            //for (int i = 0; i<9; i++)
            //{
            //    txResultet.AppendText(shuffleList[i].ToString() + "\r\n");
            //}
            Invalidate();

        }

        void shuffle(int[] arList)
        {
            shuffleList = arList.OrderBy(a => Guid.NewGuid()).ToList();

        }


        protected override void OnPaint(PaintEventArgs e)
        {
            
            SolidBrush brush = new SolidBrush(Color.Red);

            if (kortlek)
            {
                g = e.Graphics;
                int x2 = 80;
                int y2 = 280;
                for (int i = 0; i < 9; i++)
                {

                    g.FillRectangle(brush, x2 - 30, y2 - 45, 150, 200);
                    x2 = x2 + 155;

                }
            }

            if (flip)
            {
                g = e.Graphics;
                filpCard(g);
            }
        }


        private void txResultet_TextChanged(object sender, EventArgs e)
        {
            kortlek = false;
            Invalidate();
        }
    
        void filpCard(Graphics g)
        {
            xPostition = 80;

            for (int c = 0; c< counter; ++c) { 
                int y = 280;
                string s = shuffleList[c].ToString();
                card.Rita(g, s, true, xPostition, y);
                xPostition = xPostition + 155;
                flip = false;
               
            }
            if (tbxSöktValör.Text == shuffleList[counter-1].ToString())
            {
                tbxIndex.Text = (counter-1).ToString();
                MessageBox.Show($"Index är: {counter-1}","Done!");
                btnSekventiell.Enabled = false;
            }

        }

        private void tbxSöktValör_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxSöktValör.Text))
            {
                labNote.Visible = false;
                btnSekventiell.Enabled = true;
            }
            else
            {
                labNote.Visible = true;
                btnSekventiell.Enabled = false;
            }

            Invalidate();
        }
    }
}
