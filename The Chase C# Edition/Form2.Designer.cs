namespace The_Chase_C__Edition
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            button7 = new Button();
            textBox1 = new TextBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button8 = new Button();
            openFileDialog1 = new OpenFileDialog();
            label4 = new Label();
            SuspendLayout();
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(185, 143);
            button7.Name = "button7";
            button7.Size = new Size(289, 31);
            button7.TabIndex = 31;
            button7.Text = "Set Current Time as Default";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 145);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(146, 29);
            textBox1.TabIndex = 30;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(417, 34);
            button3.Name = "button3";
            button3.Size = new Size(75, 31);
            button3.TabIndex = 26;
            button3.Text = "STOP MUSIC";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(295, 61);
            button2.Name = "button2";
            button2.Size = new Size(75, 31);
            button2.TabIndex = 25;
            button2.Text = "Play";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(295, 10);
            button1.Name = "button1";
            button1.Size = new Size(75, 31);
            button1.TabIndex = 24;
            button1.Text = "Play";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 57);
            label3.Name = "label3";
            label3.Size = new Size(234, 32);
            label3.TabIndex = 23;
            label3.Text = "Short Theme Music";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(229, 32);
            label2.TabIndex = 22;
            label2.Text = "Long Theme Music";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 108);
            label1.Name = "label1";
            label1.Size = new Size(141, 32);
            label1.TabIndex = 21;
            label1.Text = "Timer (sec)";
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(12, 189);
            button8.Name = "button8";
            button8.RightToLeft = RightToLeft.Yes;
            button8.Size = new Size(165, 31);
            button8.TabIndex = 42;
            button8.Text = "CSV UPLOAD";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 237);
            label4.Name = "label4";
            label4.Size = new Size(842, 210);
            label4.TabIndex = 44;
            label4.Text = resources.GetString("label4.Text");
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 581);
            Controls.Add(label4);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button7;
        private TextBox textBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button8;
        private OpenFileDialog openFileDialog1;
        private Label label4;
    }
}