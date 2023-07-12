using System.Drawing;
using System.Drawing.Text;
using System.Media;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace The_Chase_C__Edition
{
    public partial class Form1 : Form
    {
        int timerCheck = 0; //used when entering the time. 0 means we want to HIDE the textbox, 1 means we want to SHOW the textbox aka change the time. 
        int timeLeft = 0; //counts the amount of time left
        Boolean timeUp = true;
        int time = 0;
        int sPts = 0;
        int tPts = 0; //student and teacher pts
        Boolean timeIsPaused = true;
        int questionNumber = -1; //counts the index of the question we are on. (index starts at 0!)s
        int countOfClick = 0; //used to count if we are at the 'answer' part of a question or the 'question' part (for question viewing) odd = question, even = answer
        int countOfBack = 0; //counts how many times we went 'backwards', IE, what to display next.
        public static List<(string, string)> listOfAll = new List<(string, string)>();
        public static int defaultTime = 60;
        public static Boolean csvImported = false; //makes sure csv is imported before beginning 

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
                txtBoxTimer.Visible = true;
                timerCheck = 1;
            }
            else if (timerCheck == 1)
            {
                txtBoxTimer.BringToFront();
                txtBoxTimer.Visible = false;
                timerCheck = 0;
                try
                {
                    time = Int32.Parse(txtBoxTimer.Text);
                    timerCheck = 0;
                    txtBoxTimer.Text = time.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid time. Please make sure the time is a WHOLE number in SECONDS.");
                }
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

            if (csvImported == true)
            {

                try
                {

                    if (type == "Prev") //if we're going backwards we need to also go backwards in the questions. this part is a bit more complicated.
                    {
                        //check if timer = 0, if it is then we shouldnt be allowed to keep going (preventative measure.) 

                        if (timeUp == false)
                        {

                            //first, we check if the last value was a question or an answer.
                            if (countOfClick == 0)
                            {
                                questionNumber = 0;
                                lblDisplayQ.Text = listOfAll.ElementAt(0).Item1;
                                lblDisplayA.Text = "";
                                countOfClick = 1;

                            }
                            else
                            {
                                if (countOfClick % 2 == 0) //therefore we are in an ANSWER and going back to the LAST question
                                {
                                    //if we're on an answer we need to hide the answer
                                    lblDisplayA.Text = "";
                                }
                                else
                                {
                                    questionNumber--;
                                    lblDisplayQ.Text = listOfAll.ElementAt((int)questionNumber).Item1;
                                    lblDisplayA.Text = listOfAll.ElementAt((int)questionNumber).Item2;
                                }
                                countOfClick--;
                            }

                        }
                        else
                        {
                            MessageBox.Show("Time is up. Please reset the timer!");
                        }

                    }
                    else
                    {
                        if (timeUp == false)
                        {

                            if (countOfClick % 2 == 0) //therefore we are in a QUESTION
                            {
                                questionNumber++;
                                lblDisplayQ.Text = listOfAll.ElementAt((int)questionNumber).Item1;
                                lblDisplayA.Text = "";
                            }
                            else
                            {
                                lblDisplayA.Text = listOfAll.ElementAt((int)questionNumber).Item2;
                            }
                            countOfClick++;
                        }
                        else
                        {
                            MessageBox.Show("Time is up. Please reset the timer!");
                        }
                    }

                }
                catch (Exception ex) //mostly used if listOfAll is null, so the user probably didnt enter a csv file
                {
                    //if we reached the end = index OOB, we need to show this to the user. 

                    if (questionNumber == listOfAll.Count)
                    {
                        MessageBox.Show("You have reached the end of the questions.");
                        questionNumber--;

                    }
                    else if (questionNumber == 0)
                    {

                        MessageBox.Show("You have reached the end of the questions.");
                    }
                    else
                    {
                        countOfClick = 0;
                    }


                }

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
            }
            else
            {
                MessageBox.Show("CSV file has not been imported. Please import a CSV file to show the questions.");
            }



        }

        private void btnTimeStart_Click(object sender, EventArgs e)
        {
            if (csvImported == true)
            {

                //check if timer is still going, if yes then disable since we don't want to reset the time yet. 
                if (timeUp == true)
                {
                    btnTimeStart.Enabled = false;
                    button2.Enabled = true;
                    button1.Enabled = true;
                    if (time == 0)
                    {
                        MessageBox.Show("Time is 0. Using default time of " + defaultTime + " seconds...");
                        time = Convert.ToInt32(defaultTime);
                        txtBoxTimer.Visible = false;
                        countdowntime.Interval = 1000;
                        countdowntime.Start();
                        timeLeft = time;
                    }
                    else
                    {
                        time = Convert.ToInt32(txtBoxTimer.Text);
                        txtBoxTimer.Visible = false;
                        countdowntime.Interval = 1000;
                        countdowntime.Start();
                        timeLeft = time;
                    }
                }
                else
                {
                    btnTimeStart.Enabled = true;
                    button2.Enabled = false;
                    button1.Enabled = false;
                }

            }
            else
            {
                MessageBox.Show("CSV file has not yet been imported. Please import CSV file before continuing!");
            }

        }

        private void countdowntime_Tick(object sender, EventArgs e)
        {

            if (timeLeft >= 0)
            {
                timeLeft = timeLeft - 1;
                lblTimeCount.Text = time--.ToString();
                timeUp = false;
                btnTimeStart.Enabled = false;
                button2.Enabled = true;
                button1.Enabled = true;
            }
            else
            {
                countdowntime.Stop();
                SystemSounds.Exclamation.Play();
                MessageBox.Show("Time's up!");
                timeUp = true;
                time = 0;
                btnTimeStart.Enabled = true;
                button2.Enabled = false;
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //pausing time 

            if (timeIsPaused == true) //if time is paused we must want to play time again
            {
                button1.Text = "Pause";
                countdowntime.Start();
                timeIsPaused = false;
                timeUp = true;
            }
            else //means the time hasn't been paused, aka we are playing right now. 
            {
                button1.Text = "Cont";
                countdowntime.Stop();
                timeIsPaused = true;
                timeUp = false;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //stop time and reset all time
            if (timeUp == false) // means the time hasn't ended yet so we can still use the button
            {
                btnTimeStart.Enabled = true;
                timeUp = true;
                countdowntime.Stop();
                btnTimeStart.Enabled = true;
                button2.Enabled = false;
                button1.Enabled = false;
                time = 0;
            }

        }
    }
}