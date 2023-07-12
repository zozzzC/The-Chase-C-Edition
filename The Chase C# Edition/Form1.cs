using System.Drawing;
using System.Drawing.Text;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace The_Chase_C__Edition
{
    public partial class Form1 : Form
    {
        int timerCheck = 0;
        int timerValue = 60;
        int time = 0;
        int sPts = 0;
        int tPts = 0; //student and teacher pts
        public static List<(string, string)> listOfAll = new List<(string, string)>();

        Boolean studentPtSelect = true;
        PrivateFontCollection font = new PrivateFontCollection();
        public Form1()
        {

            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int countFrom = 60;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            font.AddFontFile("C:\\Users\\Chloe\\Downloads\\Agrandir-Font-Family\\Agrandir - Free For Personal Use\\Agrandir-TextBold.otf");

            //loop to change all fonts to custom one

            foreach (Label lb in this.Controls.OfType<Label>())
            {
                lb.Font = new Font(font.Families[0], 30);
            }


            txtBoxTimer.Visible = false;
        }

        private void lblTimer_Click(object sender, EventArgs e)
        {
            //click timer label to change the time. click timer label again to confirm the time.
            if (timerCheck == 0)
            {
                txtBoxTimer.BringToFront();
                txtBoxTimer.Visible = false;
                time = Int32.Parse(txtBoxTimer.Text);
                timerCheck = 1;
            }
            else if (timerCheck == 1)
            {
                txtBoxTimer.BringToFront();
                txtBoxTimer.Visible = true;
                timerCheck = 2;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //add point to selected
            if (studentPtSelect == true)
            {
                //change pts in students label 
                sPts += 1;
                lblSPts.Text = sPts.ToString();
            }
            else
            {
                tPts += 1;
                lblTPts.Text = tPts.ToString();

            }
        }

        private void lblStudents_Click(object sender, EventArgs e)
        {
            //select/change the students points, by default this is true
            studentPtSelect = true;
            lblSPts.Text = sPts.ToString();
            lblStudents.Font = new Font(font.Families[0], 30, FontStyle.Italic);
            lblTeachers.Font = new Font(font.Families[0], 30, FontStyle.Bold);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //remove pointif (studentPtSelect == true)
            if (studentPtSelect == true)
            {
                //change pts in students label 
                sPts -= 1;
                lblSPts.Text = sPts.ToString();
            }
            else
            {
                tPts -= 1;
                lblTPts.Text = tPts.ToString();

            }
        }

        private void lblTeachers_Click(object sender, EventArgs e)
        {
            //select/change the teachers points, by default this is true
            studentPtSelect = false;
            lblTPts.Text = tPts.ToString();
            lblTeachers.Font = new Font(font.Families[0], 30, FontStyle.Italic);
            lblStudents.Font = new Font(font.Families[0], 30, FontStyle.Bold);
        }

        private void btnCSVUpload_Click(object sender, EventArgs e)
        {
            //select and upload csv files
            Form2 form = new Form2();
            form.Show();
        }

        private void btnNextQ_Click(object sender, EventArgs e)
        {
            //when button is pressed, it will show question, and then pressed again it will show answer, then another time it will move to another question 
            for (int i = 0; i <= listOfAll.Count -1; i++)
            {

            }
        }
    }
}