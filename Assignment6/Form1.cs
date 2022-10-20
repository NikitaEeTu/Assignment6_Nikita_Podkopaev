using Microsoft.VisualBasic.Devices;
using System.CodeDom;
using System.Drawing.Text;
using System.Reflection.Metadata.Ecma335;

namespace Assignment6
{
    public partial class Form1 : Form
    {

        private static String[] choicesArr = new String[3]{ "rock", "paper", "scissors" };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startTheGame("rock");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            startTheGame("paper");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            startTheGame("scissors");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private String determineWinner(String userChoice, String computerChoice)
        {
            if (userChoice.Equals("rock") && computerChoice.Equals("scissors")
                || userChoice.Equals("paper") && computerChoice.Equals("rock")
                || userChoice.Equals("scissors") && userChoice.Equals("paper"))
            {
                return "User has won 🧍‍♂️";
            }
            else if (userChoice.Equals(computerChoice))
            {
                return "Draw 👨🏻‍💻";
            }
            else
            {
                return "Computer has won💻";
            }
        }

        private int generateRandomNumber(int min, int max)
        {
            Random r = new Random();

            return r.Next(min, max);
        }

        private void startTheGame(String userChoice)
        {
            int computerRandomNumber = generateRandomNumber(0, choicesArr.Length);
            String computerChoice = choicesArr[computerRandomNumber];

            displayCurrentGame(userChoice, computerChoice);

            textBox1.Text = determineWinner(userChoice, computerChoice);
        }

        private void displayCurrentGame(String userChoice, String computerChoice)
        {
            Image[] imageArr = new Image[] { Properties.Resources.stone, Properties.Resources.note, Properties.Resources.scissors };

            int userElemIndex = Array.IndexOf(choicesArr, userChoice);
            int computerElemIndex = Array.IndexOf(choicesArr, computerChoice);

            pictureBox1.Image = imageArr[userElemIndex];
            pictureBox2.Image = imageArr[computerElemIndex];
        }
    }
}