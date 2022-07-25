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
    public partial class MainForm : Form
    {
        private List<PictureBox> rightFrogs;
        private List<PictureBox> leftFrogs;
        public static int CountMotions = 0;
        public MainForm()
        {
            InitializeComponent();

            rightFrogs = new List<PictureBox>() { rightPictureBox1, rightPictureBox2, rightPictureBox3, rightPictureBox4};
            leftFrogs = new List<PictureBox>() { leftPictureBox1, leftPictureBox2, leftPictureBox3, leftPictureBox4 };
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {           

            Swap((PictureBox) sender);

            if(CheckWin())
            {
                var winForm = new WinForm(countMotionsLabel.Text);
                winForm.Show();
            }
        }

        private bool CheckWin()
        {

            foreach(var frog in rightFrogs)
            {
                if(frog.Location.X < frog.Bounds.Width * 5)
                {
                    return false;
                }
            }

            foreach(var frog in leftFrogs)
            {
                if(frog.Location.X > frog.Bounds.Width * 3)
                {
                    return false;
                }
            }

            return true;
        }

        private void Swap(PictureBox clickedPicture)
        {            

            var distance = Math.Abs(emptyPictureBox.Location.X - clickedPicture.Location.X);

            if (distance <= clickedPicture.Size.Width * 2)
            {
                CountMotions++;
                countMotionsLabel.Text = CountMotions.ToString();

                var location = clickedPicture.Location;

                clickedPicture.Location = emptyPictureBox.Location;

                emptyPictureBox.Location = location;
            }
            else
            {
                MessageBox.Show("Такой ход невозможен", "Ошибка");
            }
        }

        private void начатьСначалаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void показатьПравилаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Цель игры расположить лягушек, которые смотрят влево в левую часть," +
                            " которые смотрят вправо в правую часть за минимальное количество перепрыгиваний. " +
                            "Прыгать можно на листок если он находится рядом или через 1 лягушку.", "Правила игры");
        }
    }
}
