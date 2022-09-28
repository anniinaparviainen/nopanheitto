namespace nopanheitto
{
    public partial class Form1 : Form
    {
        Random rng = new Random();

        Dice noppa1 = new Dice();
        Dice noppa2 = new Dice();


        public Form1()
        {

           



            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            count++;




            if (count == 1)
            {
                noppa1.Roll(rng);
                label1.Text = noppa1.Luku1.ToString();

                button1.Enabled = false;

            }


                        
                   

          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = 0;
            count++;

            if (count == 1)
            {
                noppa2.Roll(rng);
                label2.Text = noppa2.Luku2.ToString();

          
                button2.Enabled = false;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text != string.Empty || label2.Text != string.Empty || label3.Text != string.Empty)
            {
                label1.Text = "";
                label2.Text = "";
                label3.Text = "";

                button1.Enabled = true;
                button2.Enabled= true;
              
            }
        }
    }
}