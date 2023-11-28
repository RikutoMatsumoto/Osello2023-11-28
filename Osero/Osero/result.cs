using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Osero
{
    public partial class result : Form
    {
        public result(int BlackPoint, int WhitePoint)
        {
            InitializeComponent();

            lblBlackPoint.Text = BlackPoint.ToString();
            lblWhitePoint.Text = WhitePoint.ToString();

            if (BlackPoint > WhitePoint)
            {
                Winner.Text = "黒";
                Winner.Left = 32;
            }
            else if (BlackPoint < WhitePoint)
            {
                Winner.Text = "白";
                Winner.Left = 32;
            }
            else
            {
                Winner.Text = "引き分け";
                Winner.Left = 66;
                lblWinner.Text = "";
            }

        }

        //再戦
        private void Rematch_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //終了
        private void End_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
