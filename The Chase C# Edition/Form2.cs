using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Chase_C__Edition
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //this allows us to upload the csv files so that we can access them in the original form
            //IMAGES ARE NOT YET SUPPORTED!!! 

            openFileDialog1.Filter = "csv files (*.csv)|*.csv";
            var listOfAll = new List<(string, int)>();
            string[] arr = new string[2];
            ListViewItem items;


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = openFileDialog1.FileName;
                    var stream = openFileDialog1.OpenFile();
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null) //loop till end
                        {
                            string[] split = line.Split(",");

                            for (int i = 0; i <= 1; i++)
                            {
                                arr[i] = split[i];

                            }
                            Form1.listOfAll.Add((arr[0], arr[1])); //then we add the info into the list.
                            items = new ListViewItem(arr);
                        }
                    }
                    //if all is successful then we can say the csv is imported. 
                    Form1.csvImported = true;
                    MessageBox.Show("Successful import of CSV file.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in importing CSV file.");
                }
            }


        }



        private void button7_Click(object sender, EventArgs e)
        {
            //set current time entered as default
            try
            {
                Form1.defaultTime = Convert.ToInt32(textBox1.Text);
                MessageBox.Show("Default time is set to " + textBox1.Text);
            }
            catch (Exception ex)
            {
                //if timer value is invalid, show to user
                MessageBox.Show("Time entered is invalid. Please enter a whole number in seconds. Reverting back to default time of 60 seconds.");
                textBox1.Text = "60";
                Form1.defaultTime = Convert.ToInt32(textBox1.Text);
            }
        }
    }
}
