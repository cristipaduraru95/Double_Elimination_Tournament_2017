using System;
using System.Drawing;
using System.Windows.Forms;

namespace Double_Elimination_Tournament.Classes
{
    public partial class MessageBox : Form
    {
        public static string SelectedWinner;

        public MessageBox()
        {
            InitializeComponent();
        }

        public MessageBox(string firstPlayer, string secondPlayer)
        {
            InitializeComponent();
            SelectedWinner = string.Empty;
            firstPlayerButton.Text = firstPlayer;
            secondPlayerButton.Text = secondPlayer;
        }

        public string GetResult()
        {
            ShowDialog();
            return SelectedWinner;
        }

        public void WinnerSelection(object sender, EventArgs e)
        {
            var button = (Button) sender;
            SelectedWinner = button.Text;
            Hide();
        }

        private void button_MouseHover(object sender, EventArgs e)
        {
            var button = (Button) sender;
            button.BackColor = Color.Chocolate;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            var button = (Button) sender;
            button.BackColor = Color.Gainsboro;
        }
    }
}