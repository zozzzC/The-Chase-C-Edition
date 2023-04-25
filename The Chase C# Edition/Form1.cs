using System.Drawing.Text;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace The_Chase_C__Edition
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            int countFrom = 60;
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            PrivateFontCollection font = new PrivateFontCollection();
            font.AddFontFile("C:\\Users\\Chloe\\Downloads\\Agrandir-Font-Family\\Agrandir - Free For Personal Use\\Agrandir-TextBold.otf");
            lblStudents.Font = new Font(font.Families[0], 30);
            lblTeachers.Font = new Font(font.Families[0], 30);
            label1.Font = new Font(font.Families[0], 30);
            label2.Font = new Font(font.Families[0], 30);
            Form2 f2 = new Form2();
            f2.Show();


        }

        public class timerStart()
        {

        }

    }
}