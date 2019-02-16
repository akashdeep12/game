using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sohi_russian
{
    public partial class Form2 : Form
    {
        
        spinner obj_spinner = new spinner();

        public Form2()
        {
            InitializeComponent();
        }

        private void load_button_Click(object sender, EventArgs e)
        {   //this code shows the gif
            pictureBox1.Image = Image.FromFile(@"C:\Users\PRABHJOT SINGH\Desktop\sohi_russian\Res\load.gif");
            //this code plays the sound
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\PRABHJOT SINGH\Desktop\sohi_russian\Res\load.wav");

            obj_spinner.loadchamber = 1;//this code sets the value of load =1


            Spin_button .Enabled = true;//this code enables the spin button
            load_button .Enabled = false;//this code disable the load button
        }

        private void Spin_button_Click(object sender, EventArgs e)
        {    //this code shows the gif

            pictureBox1.Image = Image.FromFile(@"C:\Users\PRABHJOT SINGH\Desktop\sohi_russian\Res\spin.gif");
            //this code plays the sound
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\PRABHJOT SINGH\Desktop\sohi_russian\Res\spin.wav");


            Random rnd = new Random();

            obj_spinner.spinchamer = rnd.Next(1, 6);

            Shoot_button.Enabled = true;//this code enables the shoot button
            Spin_button.Enabled = false;//this code diable the spin button

        }

        

        private void Shoot_button_Click(object sender, EventArgs e)
        {   //this code shows the gif
            pictureBox1.Image = Image.FromFile(@"C:\Users\PRABHJOT SINGH\Desktop\sohi_russian\Res\shoot.gif");
            //this code plays the sound
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\PRABHJOT SINGH\Desktop\sohi_russian\Res\shoot.wav");
            player.Play();
            int bullete = 0;

            if (obj_spinner.reset == 0)
            {
                Shoot_button.Enabled = false;//this code disable the shoot button
                Spin_button.Enabled = false;//this code diable the shoot button
                load_button.Enabled = false;//this code disable the shoot button
            }


            do
            {
                if (bullete == 0 && obj_spinner.loadchamber == obj_spinner.spinchamer)//this is a if statement
                {

                    MessageBox.Show("won and your score is 10");//this is for the message pop up
                    bullete = 3;//this varable sets the value of bullete=3
                    Shoot_button.Enabled = false;
                    obj_spinner.reset = 0;
                }
                else if (bullete == 1 && obj_spinner.loadchamber == obj_spinner.spinchamer)
                {
                    MessageBox.Show("won and your score is 5");//this is for the message pop up
                    bullete = 3;//this varable sets the value of bullete=3
                    Shoot_button.Enabled = false;
                    obj_spinner.reset = 0;//this varable sets the value of reset=0

                }
                else if (bullete == 2)
                {
                    MessageBox.Show("loose");//this is for the message pop up
                    bullete = 3;//this varable sets the value of bullete=3
                    Shoot_button.Enabled = false;
                    obj_spinner.reset = obj_spinner.reset - 1;

                }
                else
                {
                    bullete++;
                    obj_spinner.spinchamer = obj_spinner.spin_bullete(obj_spinner.spinchamer);
                }
            }
            while (bullete <=2);//this is a do while loop runs until value of bullete is <=2

            

        }

        private void Reset_button_Click(object sender, EventArgs e)
        {
            (new Form2()).Show();// this resets the form to its orignal state
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(obj_spinner.name);
        }
    }
}
