using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Drawing2D;
using Microsoft.Win32;

namespace enem
{
    class enemy
    {
        Random rnd = new Random();
        public int myscore;
        public int allscore;
        public int enemyscore;
        public int[] ex = new int[3];
        // public enemy(int my, int your, int all) { }
        public void getinfo(int my, int your, int all) {
            myscore = my;
            allscore = all;
            enemyscore = your;
        }
       /* public void myturn(int my, int your, int all)
        {
            MessageBox.Show(my.ToString());
            MessageBox.Show(your.ToString());
            MessageBox.Show(all.ToString());
            int take;
            if (all > 18) {
                take = rnd.Next(1, 3);
                all = all - take;
                my = my + take;
                MessageBox.Show(">18");
            }
            else if((my % 2) == 0)
            {
                take = 2;
                all = all - take;
                my = my + take;
            }
            else if(all == 3)
            {
                 if((my % 2) == 0) {
                    take = 2;
                    all = all - take;
                    my = my + take;
                }
                else if((my % 2) == 1)
                {
                    take = 3;
                    all = all - take;
                    my = my + take;
                }
            }
            else if(all < 3)
            {
                 if((my % 2) == 0)
                {
                    take = 2;
                    all = all - take;
                    my = my + take;
                }
                else if((my % 2) == 1)
                {
                    take = 1;
                    all = all - take;
                    my = my + take;
                }
            }
            else {
                MessageBox.Show("else");
            }
            return ex;
        }*/
        public Tuple<int, int,int> myturn(int my,int your, int all)
        {
            MessageBox.Show(my.ToString());
            MessageBox.Show(your.ToString());
            MessageBox.Show(all.ToString());
            int take;
            if (all > 18)
            {
                take = rnd.Next(1, 3);
                all = all - take;
                my = my + take;
                MessageBox.Show(">18");
            }
            else if ((my % 2) == 0)
            {
                take = 2;
                all = all - take;
                my = my + take;
            }
            else if (all == 3)
            {
                if ((my % 2) == 0)
                {
                    take = 2;
                    all = all - take;
                    my = my + take;
                }
                else if ((my % 2) == 1)
                {
                    take = 3;
                    all = all - take;
                    my = my + take;
                }
            }
            else if (all < 3 && all > 0)
            {
                if ((my % 2) == 0)
                {
                    take = 2;
                    all = all - take;
                    my = my + take;
                }
                else if ((my % 2) == 1)
                {
                    take = 1;
                    all = all - take;
                    my = my + take;
                }
            }
            else
            {
                take = rnd.Next(1, 3);
                all = all - take;
                my = my + take;
            }
            return Tuple.Create(my,your,all);
        }
    }
}
