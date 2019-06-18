using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace LuckyNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewGame();
            txtPlayerCashes.Text = "100";
            txtComputerCashes.Text = "1000";
            lblNumber1.Text = "";
            lblNumber2.Text = "";
            lblNumber3.Text = "";
            txtMoneyBet.Text = "";
            txtPlayerNumber.Text = "";

        }

        Random rand = new Random();
        private double playerCash ;
        private int playerNumber;
        private double computerCash;
            
        private void RePlay()
        {
            NewGame();
            txtPlayerCashes.Text = "100";
            txtComputerCashes.Text = "1000";
            lblNumber1.Text = "";
            lblNumber2.Text = "";
            lblNumber3.Text = "";
            txtMoneyBet.Text = "";
            txtPlayerNumber.Text = "";
        }
        private void NewGame()
        {
            tmrLuckyNumber.Interval = 100;
            btnSpin.Enabled = true;
            btnNew.Enabled = true;
            btnExit.Enabled = true;
            txtMoneyBet.Enabled = true;
            txtPlayerNumber.Enabled = true;

        }
        private void txtPlayerNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsControl(e.KeyChar))
            {
                return;
            }
            if(txtPlayerNumber.Text.Length ==1)
            {
                e.Handled = true;
                return;
            }
            if(!char.IsDigit(e.KeyChar)&& !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void tmrLuckyNumber_Tick(object sender, EventArgs e)
        {
            int number1 = rand.Next(0, 10);
            int number2 = rand.Next(0, 10);
            int number3 = rand.Next(0, 10);

            lblNumber1.Text = number1.ToString();
            lblNumber2.Text = number2.ToString();
            lblNumber3.Text = number3.ToString();
            tmrLuckyNumber.Interval += 50;
            if (tmrLuckyNumber.Interval >=700)
            {
                tmrLuckyNumber.Stop();
                Result();
                NewGame();
            }
        }

        private void Result()
        {
            int soTrung = 0;
            double wincash = 0;
            double moneyBet = int.Parse(txtMoneyBet.Text);
            playerNumber = int.Parse(txtPlayerNumber.Text);
            playerCash = int.Parse(txtPlayerCashes.Text);
            computerCash = int.Parse(txtComputerCashes.Text);
            if (playerNumber == int.Parse(lblNumber1.Text))
            {
                soTrung++;
            }
            if (playerNumber == int.Parse(lblNumber2.Text))
            {
                soTrung++;
            }
            if (playerNumber == int.Parse(lblNumber3.Text))
            {
                soTrung++;
            }
            SoundPlayer sp = new SoundPlayer(Application.StartupPath + "/yeah.wav");
            switch (soTrung)
            {
                case 0:
                    wincash = -moneyBet;
                    MessageBox.Show("Chúc bạn may mắn lần sau T_T ");
                    playerCash += wincash;
                    computerCash -= wincash;
                    break;
                case 1:
                    sp.Play();
                    wincash = -moneyBet;
                    MessageBox.Show("yeah! Bạn trùng 1 số");
                    playerCash -= wincash;
                    computerCash += wincash;
                    break;
                case 2:
                    sp.Play();
                    wincash = moneyBet * 2.5;
                    MessageBox.Show("yeahhhhhh! Bạn trùng 2 số");
                    playerCash += wincash;
                    computerCash -= wincash;
                    break;
                case 3:
                    sp.Play();
                    wincash = moneyBet * 3.5;
                    MessageBox.Show("yeahhhhhhhhhhhhhhh! Bạn trùng 3 số (^__^) ");
                    playerCash += wincash;
                    computerCash -= wincash;
                    break;
                default:
                    break;
            }
            txtPlayerCashes.Text = playerCash.ToString();
            txtComputerCashes.Text = computerCash.ToString();
        }
        private void txtMoneyBet_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            RePlay();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           DialogResult thoat = MessageBox.Show("Bạn muốn thoát chương trình","Quit",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(thoat == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
