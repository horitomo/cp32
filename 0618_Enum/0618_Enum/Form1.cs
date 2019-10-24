using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0618_Enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private enum ICON { Info, Warning, Error};

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label1.Text = ICON.Error.ToString();

            // 列挙型の変数を定義することができる
            ICON icon;
            icon = ICON.Error;

            // Switch
            String message = null;
            switch ( icon )
            {
                case ICON.Info : message = "情熱";
                    break;
                case ICON.Warning : message = "警告";
                    break;
                case ICON.Error : message = "異常";
                    break;
            }

            this.label1.Text = message;
        }
    }
}
