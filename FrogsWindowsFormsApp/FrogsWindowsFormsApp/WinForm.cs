using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrogsWindowsFormsApp
{
    public partial class WinForm : Form
    {
        private string countMotions = "0";
        public WinForm(string countMoves)
        {
            InitializeComponent();

            countMotions = countMoves;
        }

        private void WinForm_Load(object sender, EventArgs e)
        {            
            countMotionsWinLabel.Text = countMotions;

            if (countMotions == "24")
            {
                bestScoreLabel.Text = "Вы прошли игру с наилучшим результатом!";
            }
        }
    }
}
