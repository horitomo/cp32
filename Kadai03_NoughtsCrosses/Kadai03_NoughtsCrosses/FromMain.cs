using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kadai03_NoughtsCrosses
{
    public partial class FromMain : Form
    {
        String prev = "〇";
        String next = "✕";
        Boolean flag = true;
        Boolean okflag = false;
        int winPlayer = 0;
        int count = 0;
        int[] array = new int[9];
        public FromMain()
        {
            InitializeComponent();
        }

        private void FromMain_Load(object sender, EventArgs e)
        {
            
            foreach (Control c2 in this.panel1.Controls)
            {

                Button l2 = (Button)c2;
                l2.Text = "";
                l2.Enabled = true;
            }
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = 0;
            }
            okflag = false;
            winPlayer = 0;
            this.clear.Enabled = false;
            count = 0;
            Random random = new Random();
            int marubatu = (int)random.Next(0,2);
            if(marubatu == 0)
            {
                flag = !flag;
            }
            if (flag)
            {
                this.turn.Text = prev;
            }else
            {
                this.turn.Text = next;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            count++;
            if (!this.clear.Enabled)
            {
                this.clear.Enabled = true;
            }
            String val = "";
            Button b = (Button)sender;
            if (flag)
            {
                b.Text = prev;
                val = b.Tag.ToString();
                array[int.Parse(val)] = 1;
            }
            else
            {
                b.Text = next;
                val = b.Tag.ToString();
                array[int.Parse(val)] = 2;
            }

            flag = !flag;
            b.Enabled = false;
            if (flag)
            {
                this.turn.Text = prev;
            }
            else
            {
                this.turn.Text = next;
            }

            judge();
            if (okflag)
            {
                String msg = "";
                if(winPlayer == 1)
                {
                    msg = "〇";
                }else
                {
                    msg = "✕";
                }
                this.turn.Text = "End";
                DialogResult resultBox = MessageBox.Show(msg+"の勝ち", "決着", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (resultBox.Equals(DialogResult.OK))
                {
                    reset(sender);
                }
            }else if(count == 9)
            {
                this.turn.Text = "end";
                DialogResult resultBox = MessageBox.Show("引き分け", "未決着", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (resultBox.Equals(DialogResult.OK))
                {
                    reset(sender);
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            DialogResult clearBox = MessageBox.Show("初期化しますか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (clearBox.Equals(DialogResult.OK))
            {
                reset(sender);
            }
            
        }

        private void reset(object sender)
        {
            FromMain_Load(sender,null);
        }

        //private enum MARUBATU{Y,N}
        //private MARUBATU[] table = new MARUBATU[9];
        private void judge()
        {
            

            int hantei = 0;
            int hanteiG = 0;

            for(int j = 0; j < 3; j++)
            {
                    for (int k = j + 3; k < j + 7; k = k+3)
                    {
                        hanteiG = array[j];
                        if (hanteiG == array[k] && hanteiG != 0)
                        {
                            if(k == (j + 6))
                            {
                                okflag = true;
                                winPlayer = hanteiG;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }   
            }

            for(int o = 0; o < 7; o += 3)
            {
                    for(int p = o+1; p < o + 3; p++)
                    {
                        hantei = array[o];
                        if (hantei == array[p] && hantei != 0)
                        {
                            if (p == (o + 2))
                            {
                                okflag = true;
                                winPlayer = hantei;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
            }

            if(array[0] == array[4] && array[0] == array[8] && array[0] != 0)
            {
                winPlayer = array[0];
                okflag = true;
            }else if(array[2] == array[4] && array[4] == array[6] && array[2] != 0){
                winPlayer = array[2];
                okflag = true;
            }
        }
    }
}
