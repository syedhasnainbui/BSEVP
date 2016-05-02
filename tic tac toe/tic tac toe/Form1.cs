using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[,] pos=new int[3,3];
        int count, val, a, b, c = 1, d = 1, diff = 1, vs = 1;
        char let;
        string pl1 = "You", pl2 = "Computer";
        Random rnd=new Random();
        bool turn = true;
        void reset()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    pos[i, j] = 0;
                }
                foreach (Control cntrl in this.Controls)
                {
                    if (cntrl is Label)
                    {
                        cntrl.ResetText();
                    }
                }
                count = 0;
                val = 1;
                let = 'x';
                label10.Text = pl1 + "to play Now.";
            }
        }
        bool play(int l,int m)
        {
            if(pos[l,m]==0)
            {
                a=c;b=d;c=l;d=m;
                Label ctrl=link(l,m);
                ctrl.Text=let.ToString();
                pos[l,m]=val;
                flip();
                checkwin(l,m,pos[l,m]);
                return true;
            }
            else return false;

        }
            Label link(int l,int m)
            {
                if(l==0)
                {
                    if(m==0)
                        return label1;
                    if(m==1)
                        return label2;
                    if(m==3)
                        return label3;

                }
                if(l==1)
                {
                    if(m==0)
                        return label4;
                    if(m==1)
                        return label5;
                    if(m==2)
                        return label6;
                    
                }
                if(l==2)
                {
                    if(m==0)
                        return label7;
                    if(m==1)
                        return label8;
                    if(m==2)
                        return label9;
                }
                return null;
            }

            void flip()
            {
                if (let == 'x')
                {
                    let = '0';
                    val = 4;
                    count++;
                }
                else
                {
                    let = 'x';
                    val = 1;
                    count++;
                }
            }
            void checkwin(int l, int m, int n)
            {
                if (count == 1)
                    if (vs == 1)
                        turn = true;
                if (count > 4)
                {
                    if ((pos[l, 0] + pos[l, 1] + pos[l, 2] == n * 3) || (pos[0, m] + pos[1, m] + pos[2, m] == n * 3))
                    {
                        count = n;
                    }
                    else
                    {
                        if ((pos[0, 0] + pos[1, 1] + pos[2, 2] == n * 3) || (pos[2, 0] + pos[1, 1] + pos[0, 2] == n * 3))
                        {
                            count = n;
                        }
                        else
                        {
                            if (count == 9)
                            {
                                count = 0;
                            }
                        }


                    }
                    if (count == 1 || count == 0)
                    {
                        if (count == 1)
                            declare(pl1 + "(playing x) Wins!");
                        if (count == 0)
                            declare("The Game is Draw!");
                        reset();
                        
                    }
                    else
                        if (count == 4)
                        {
                            declare(pl2 + "(playing 0) wins!");
                            String temp = pl1;
                            pl1 = pl2;
                            pl2 = temp;
                            reset();
                            
                        }
                }
            }
            void declare(string s)
            {

                if (MessageBox.Show(s+"Do You Want To Continue ?",
                    "",MessageBoxButtons.YesNo,MessageBoxIcon.Question)
                    !=DialogResult.Yes)
                {
                    Application.Exit();
                }

            }


         
               

              


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void easToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator2_Click(object sender, EventArgs e)
        {

        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lineShape5_Click(object sender, EventArgs e)
        {

        }
        void VsComputerToolScriptMenuItemClick(object sender,EventArgs e)
        {
            pl1 = "You";
            pl2 = "Computer";
            reset();
            vsComputerToolStripMenuItem.Checked = true;
            turn = false;

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void NewGameToolStripMenuItemClick(object sender, EventArgs e)
        {
            reset();

        }

        private void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("this is a simple game in which win is achieved when\n three concsecutive blocks in a row,column or diagonal\n are occupied before the opponents does the same");
        }
    }

}
