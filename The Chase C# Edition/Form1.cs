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
        int questionNumber = 0; //counts the index of the question we are on. 
        int countOfClick = 0; //used to count if we are at the 'answer' part of a question or the 'question' part (for question viewing) odd = question, even = answer
        int countOfBack = 0; //counts how many times we went 'backwards', IE, what to display next.
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

            lblDisplayA.Font = new Font(font.Families[0], 20);
            lblDisplayQ.Font = new Font(font.Families[0], 20);

            txtBoxTimer.Visible = false;
        }

        private void lblTimer_Click(object sender, EventArgs e)
        {
            //click timer label to change the time. click timer label again to confirm the time.
            if (timerCheck == 0)
            {
                txtBoxTimer.BringToFront();
                txtBoxTimer.Visible = false;
                try
                {
                    time = Int32.Parse(txtBoxTimer.Text);
                    timerCheck = 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid time. Please make sure the time is a WHOLE number in SECONDS.");
                }
               
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
            QuestionNavigation("Next");
        }

        private void btnPrevQ_Click(object sender, EventArgs e)
        {
            //the reverse, if button is clicked it will revert back to the last question.
            QuestionNavigation("Prev");
        }

        private void QuestionNavigation(string type)
        {
            try
            {
                if (type == "Prev") //if we're going backwards we need to also go backwards in the questions. this part is a bit more complicated.
                {

                    //first, we check if the last value was a question or an answer.

                    if (countOfClick % 2 == 0) //therefore we are in a QUESTION and going back to the LAST question
                    {
                        lblDisplayQ.Text = listOfAll.ElementAt((int)questionNumber).Item1;
                        lblDisplayA.Text = listOfAll.ElementAt((int)questionNumber).Item2;
                    }
                    else
                    {
                        //if we're on an answer we need to hide the answer
                        lblDisplayA.Text = "";
                        questionNumber--;
                    }
                    countOfClick--;
                }
                else
                {
                    if (countOfClick % 2 == 0) //therefore we are in a QUESTION
                    {
                        lblDisplayQ.Text = listOfAll.ElementAt((int)questionNumber).Item1;
                        lblDisplayA.Text = "";
                    }
                    else
                    {
                        lblDisplayA.Text = listOfAll.ElementAt((int)questionNumber).Item2;
                        questionNumber++;
                    }
                    countOfClick++;
                }
                label1.Text = "count of click: " + countOfClick + "q number: " + questionNumber;

            }
            catch (Exception ex) //mostly used if listOfAll is null, so the user probably didnt enter a csv file
            {
                if (countOfClick < 0)
                {
                    countOfClick = 0;
                    lblDisplayA.Text = "";
                } 

                if (questionNumber < 0)
                {
                    questionNumber = 0;
                    lblDisplayQ.Text = "";
                }
                //if we reached the end = index OOB, we need to show this to the user. 

                if (questionNumber == listOfAll.Count)
                {
                    MessageBox.Show("You have reached the end of the questions.");
                    questionNumber--;

                }
                    MessageBox.Show("Error in showing questions. Did you enter a valid CSV file?");

                
            }


        }
    }
}