namespace The_Chase_C__Edition
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            lblStudents = new Label();
            lblTeachers = new Label();
            label1 = new Label();
            label2 = new Label();
            countdowntime = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.THE_CHASE;
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1348, 836);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblStudents
            // 
            lblStudents.AutoSize = true;
            lblStudents.BackColor = Color.FromArgb(207, 63, 63);
            lblStudents.ForeColor = Color.FromArgb(255, 224, 92);
            lblStudents.Location = new Point(130, 356);
            lblStudents.Name = "lblStudents";
            lblStudents.Size = new Size(62, 15);
            lblStudents.TabIndex = 1;
            lblStudents.Text = "STUDENTS";
            // 
            // lblTeachers
            // 
            lblTeachers.AutoSize = true;
            lblTeachers.BackColor = Color.FromArgb(207, 63, 63);
            lblTeachers.ForeColor = Color.FromArgb(255, 224, 92);
            lblTeachers.Location = new Point(962, 356);
            lblTeachers.Name = "lblTeachers";
            lblTeachers.Size = new Size(63, 15);
            lblTeachers.TabIndex = 2;
            lblTeachers.Text = "TEACHERS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(207, 63, 63);
            label1.ForeColor = Color.FromArgb(255, 224, 92);
            label1.Location = new Point(962, 448);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 4;
            label1.Text = "TEACHERS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(207, 63, 63);
            label2.ForeColor = Color.FromArgb(255, 224, 92);
            label2.Location = new Point(130, 448);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 3;
            label2.Text = "STUDENTS";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1346, 825);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(lblTeachers);
            Controls.Add(lblStudents);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblStudents;
        private Label lblTeachers;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer countdowntime;
    }
}