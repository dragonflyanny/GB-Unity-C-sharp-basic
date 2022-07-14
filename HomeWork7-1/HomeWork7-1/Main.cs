using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork7_1
{
    public partial class Main : Form
    {
        public Random random = new Random();
        private int computerNumber;
        private int userNumber;
        private int count;

        public Main()
        {
            InitializeComponent();
            UpdateState(userNumber, random.Next(20));
            count = 0;
            UpdateCount(count);
        }
        private void UpdateState(int userNamber)
        {
            labelUserNumber.Text = $"Текущее число: {userNumber}";
        }

        private void UpdateState(int userNamber, int computerNumber)
        {
            UpdateState(userNumber);
            this.computerNumber = computerNumber;
            labelComputerNumber.Text = $"Получите число: {computerNumber}";
        }

        private void UpdateCount(int Count)
        {
            labelCount.Text = $"Ходов: {count}";
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            userNumber = 0;
            UpdateState(userNumber, random.Next(20));
            count = 0;
            UpdateCount(count);
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            UpdateState(++userNumber);
            UpdateCount(++count);
            СheckWin();
        }

        private void buttonMulty_Click(object sender, EventArgs e)
        {
            UpdateState(userNumber *=2);
            UpdateCount(++count);
            СheckWin();
        }

        private void СheckWin()
        {
            if (userNumber == computerNumber)
            {
                MessageBox.Show($"Вы успешно завершили игру за {count} ходов", "Две игры", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void СheckNumber()
        {
            if (userNumber > computerNumber)
            {
                MessageBox.Show("Ваше число больше загаданного", "Две игры", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (userNumber > computerNumber)
            {
                MessageBox.Show("Ваше число меньше загаданного", "Две игры", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (userNumber == computerNumber)
            {
                СheckWin();
            }

        }

        private void buttonUdvo_Click(object sender, EventArgs e)
        {

            buttonPlus.Visible = true;
            buttonMulty.Visible = true;
            labelComputerNumber.Visible = true;
            labelUserNumber.Visible = true;
            labelCount.Visible = true;
            buttonReset.Visible = true;
            labelAnswer.Visible = true;



            textBoxUserNumber.Visible = false;
            buttonOk.Visible = false;

        }

        private void buttonUgad_Click(object sender, EventArgs e)
        {
        labelComputerNumber.Visible = true;
        labelUserNumber.Visible = true;
        textBoxUserNumber.Visible = true;
        buttonOk.Visible = true;
            labelCount.Visible = true;

            buttonReset.Visible = true;

            buttonPlus.Visible = false;
            buttonMulty.Visible = false;
            labelAnswer.Visible = true;




        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            userNumber = Convert.ToInt32(textBoxUserNumber.Text);
            UpdateCount(++count);
            СheckNumber();
            //textBoxUserNumber.Text = "";
        }
    }
}
