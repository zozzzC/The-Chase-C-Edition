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
            lblTPts = new Label();
            lblSPts = new Label();
            countdowntime = new System.Windows.Forms.Timer(components);
            lblTimer = new Label();
            button9 = new Button();
            button8 = new Button();
            txtBoxTimer = new TextBox();
            lblTimeCount = new Label();
            btnCSVUpload = new Button();
            btnNextQ = new Button();
            btnPrevQ = new Button();
            lblDisplayQ = new Label();
            lblDisplayA = new Label();
            btnTimeStart = new Button();
            button1 = new Button();
            button2 = new Button();
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
            lblStudents.BackColor = Color.FromArgb(207, 63, 63);
            lblStudents.ForeColor = Color.FromArgb(255, 224, 92);
            lblStudents.Location = new Point(36, 356);
            lblStudents.Name = "lblStudents";
            lblStudents.Size = new Size(458, 64);
            lblStudents.TabIndex = 1;
            lblStudents.Text = "STUDENTS";
            lblStudents.TextAlign = ContentAlignment.TopCenter;
            lblStudents.Click += lblStudents_Click;
            // 
            // lblTeachers
            // 
            lblTeachers.BackColor = Color.FromArgb(207, 63, 63);
            lblTeachers.ForeColor = Color.FromArgb(255, 224, 92);
            lblTeachers.Location = new Point(868, 356);
            lblTeachers.Name = "lblTeachers";
            lblTeachers.Size = new Size(453, 64);
            lblTeachers.TabIndex = 2;
            lblTeachers.Text = "TEACHERS";
            lblTeachers.TextAlign = ContentAlignment.TopCenter;
            lblTeachers.Click += lblTeachers_Click;
            // 
            // lblTPts
            // 
            lblTPts.BackColor = Color.FromArgb(207, 63, 63);
            lblTPts.ForeColor = Color.FromArgb(255, 224, 92);
            lblTPts.Location = new Point(868, 448);
            lblTPts.Name = "lblTPts";
            lblTPts.Size = new Size(453, 55);
            lblTPts.TabIndex = 4;
            lblTPts.Text = "0";
            lblTPts.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblSPts
            // 
            lblSPts.BackColor = Color.FromArgb(207, 63, 63);
            lblSPts.ForeColor = Color.FromArgb(255, 224, 92);
            lblSPts.Location = new Point(36, 448);
            lblSPts.Name = "lblSPts";
            lblSPts.Size = new Size(458, 55);
            lblSPts.TabIndex = 3;
            lblSPts.Text = "0";
            lblSPts.TextAlign = ContentAlignment.TopCenter;
            // 
            // countdowntime
            // 
            countdowntime.Tick += countdowntime_Tick;
            // 
            // lblTimer
            // 
            lblTimer.BackColor = Color.FromArgb(207, 63, 63);
            lblTimer.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblTimer.ForeColor = Color.FromArgb(255, 224, 92);
            lblTimer.Location = new Point(558, 209);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(196, 63);
            lblTimer.TabIndex = 5;
            lblTimer.Text = "TIME";
            lblTimer.TextAlign = ContentAlignment.MiddleCenter;
            lblTimer.Click += lblTimer_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(1147, 694);
            button9.Name = "button9";
            button9.RightToLeft = RightToLeft.Yes;
            button9.Size = new Size(75, 31);
            button9.TabIndex = 39;
            button9.Text = "-";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(1246, 694);
            button8.Name = "button8";
            button8.Size = new Size(75, 31);
            button8.TabIndex = 38;
            button8.Text = "+";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // txtBoxTimer
            // 
            txtBoxTimer.Location = new Point(603, 310);
            txtBoxTimer.Name = "txtBoxTimer";
            txtBoxTimer.Size = new Size(100, 23);
            txtBoxTimer.TabIndex = 41;
            // 
            // lblTimeCount
            // 
            lblTimeCount.BackColor = Color.FromArgb(207, 63, 63);
            lblTimeCount.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblTimeCount.ForeColor = Color.FromArgb(255, 224, 92);
            lblTimeCount.Location = new Point(575, 289);
            lblTimeCount.Name = "lblTimeCount";
            lblTimeCount.Size = new Size(167, 59);
            lblTimeCount.TabIndex = 42;
            lblTimeCount.Text = "0";
            lblTimeCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCSVUpload
            // 
            btnCSVUpload.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCSVUpload.Location = new Point(1246, 782);
            btnCSVUpload.Name = "btnCSVUpload";
            btnCSVUpload.Size = new Size(75, 31);
            btnCSVUpload.TabIndex = 43;
            btnCSVUpload.Text = "Settings";
            btnCSVUpload.UseVisualStyleBackColor = true;
            btnCSVUpload.Click += btnCSVUpload_Click;
            // 
            // btnNextQ
            // 
            btnNextQ.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNextQ.Location = new Point(1246, 740);
            btnNextQ.Name = "btnNextQ";
            btnNextQ.RightToLeft = RightToLeft.No;
            btnNextQ.Size = new Size(75, 31);
            btnNextQ.TabIndex = 44;
            btnNextQ.Text = "-->";
            btnNextQ.UseVisualStyleBackColor = true;
            btnNextQ.Click += btnNextQ_Click;
            // 
            // btnPrevQ
            // 
            btnPrevQ.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrevQ.Location = new Point(1147, 740);
            btnPrevQ.Name = "btnPrevQ";
            btnPrevQ.RightToLeft = RightToLeft.No;
            btnPrevQ.Size = new Size(75, 31);
            btnPrevQ.TabIndex = 45;
            btnPrevQ.Text = "<--";
            btnPrevQ.UseVisualStyleBackColor = true;
            btnPrevQ.Click += btnPrevQ_Click;
            // 
            // lblDisplayQ
            // 
            lblDisplayQ.BackColor = Color.FromArgb(207, 63, 63);
            lblDisplayQ.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblDisplayQ.ForeColor = Color.FromArgb(255, 224, 92);
            lblDisplayQ.Location = new Point(33, 516);
            lblDisplayQ.Name = "lblDisplayQ";
            lblDisplayQ.Size = new Size(1288, 59);
            lblDisplayQ.TabIndex = 46;
            lblDisplayQ.Text = "Question";
            lblDisplayQ.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDisplayA
            // 
            lblDisplayA.BackColor = Color.FromArgb(207, 63, 63);
            lblDisplayA.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblDisplayA.ForeColor = Color.FromArgb(255, 224, 92);
            lblDisplayA.Location = new Point(33, 575);
            lblDisplayA.Name = "lblDisplayA";
            lblDisplayA.Size = new Size(1288, 59);
            lblDisplayA.TabIndex = 47;
            lblDisplayA.Text = "Answer";
            lblDisplayA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnTimeStart
            // 
            btnTimeStart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTimeStart.Location = new Point(1246, 648);
            btnTimeStart.Name = "btnTimeStart";
            btnTimeStart.Size = new Size(75, 31);
            btnTimeStart.TabIndex = 48;
            btnTimeStart.Text = "Start";
            btnTimeStart.UseVisualStyleBackColor = true;
            btnTimeStart.Click += btnTimeStart_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(1147, 648);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.Yes;
            button1.Size = new Size(75, 31);
            button1.TabIndex = 49;
            button1.Text = "Pause";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(1051, 648);
            button2.Name = "button2";
            button2.Size = new Size(75, 31);
            button2.TabIndex = 50;
            button2.Text = "End";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1346, 825);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnTimeStart);
            Controls.Add(lblDisplayA);
            Controls.Add(lblDisplayQ);
            Controls.Add(btnPrevQ);
            Controls.Add(btnNextQ);
            Controls.Add(btnCSVUpload);
            Controls.Add(lblTimeCount);
            Controls.Add(txtBoxTimer);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(lblTimer);
            Controls.Add(lblTPts);
            Controls.Add(lblSPts);
            Controls.Add(lblTeachers);
            Controls.Add(lblStudents);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblStudents;
        private Label lblTeachers;
        private Label lblTPts;
        private Label lblSPts;
        private System.Windows.Forms.Timer countdowntime;
        private Label lblTimer;
        private Button button9;
        private Button button8;
        private TextBox txtBoxTimer;
        private Label lblTimeCount;
        private Button btnCSVUpload;
        private Button btnNextQ;
        private Button btnPrevQ;
        private Label lblDisplayQ;
        private Label lblDisplayA;
        private Button btnTimeStart;
        private Button button1;
        private Button button2;
    }
}