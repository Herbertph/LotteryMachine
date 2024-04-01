

namespace FunkoLottery
{
    public partial class Form1 : Form
    {
        Image[] images = new Image[6];
        int animationDuration = 1500;
        int elapsedTime = 0;
        private int rollCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < images.Length; i++)
            {
                images[i] = Image.FromFile("images\\" + (i + 1) + ".png");
            }
        }

        Random numbers = new Random();

        private void btnDraw_Click(object sender, EventArgs e)
        {
            lblWinMessage.Text = string.Empty;
           timer1.Start();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedTime += timer1.Interval;

            if (rollCount > 2)
            {
                if (ShouldIncreaseWinChance())
                {
                    int winningNumber = numbers.Next(images.Length);
                    pbxNumberOne.Image = images[winningNumber];
                    pbxNumberTwo.Image = images[winningNumber];
                    pbxNumberThree.Image = images[winningNumber];
                    CheckWin(winningNumber, winningNumber, winningNumber);
                    FinishRoll();
                    return;
                }
            }
                       
            pbxNumberOne.Image = images[numbers.Next(images.Length)];
            pbxNumberTwo.Image = images[numbers.Next(images.Length)];
            pbxNumberThree.Image = images[numbers.Next(images.Length)];

            if (elapsedTime >= animationDuration)
            {
                timer1.Stop(); 

                int numberOne = numbers.Next(images.Length);
                int numberTwo = numbers.Next(images.Length);
                int numberThree = numbers.Next(images.Length);

                pbxNumberOne.Image = images[numberOne];
                pbxNumberTwo.Image = images[numberTwo];
                pbxNumberThree.Image = images[numberThree];

                elapsedTime = 0;

                CheckWin(numberOne, numberTwo, numberThree);
            }
        }

        private bool ShouldIncreaseWinChance()
        {
            //Raise the chance of winning after 2 rolls
            int chance = numbers.Next(100);
            return chance < 15 * (rollCount - 2);
        }

        private void FinishRoll()
        {
            timer1.Stop(); 
            elapsedTime = 0;

            if (!timer1.Enabled)
            {
                int numberOne = Array.IndexOf(images, pbxNumberOne.Image);
                int numberTwo = Array.IndexOf(images, pbxNumberTwo.Image);
                int numberThree = Array.IndexOf(images, pbxNumberThree.Image);
                CheckWin(numberOne, numberTwo, numberThree);
            }
        }

        private void CheckWin(int numberOne, int numberTwo, int numberThree)
        {
            if (numberOne == numberTwo && numberTwo == numberThree)
            {
                lblWinMessage.Text = "Congratulations! You won!";
                rollCount = 0;
            }
            else
            {
                lblWinMessage.Text = "Sorry, you lost. Try again!";
            }
        }
    }
}
