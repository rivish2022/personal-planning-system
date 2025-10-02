namespace personal_planning_system
{
    partial class Form5
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(322, 13);
            label1.Name = "label1";
            label1.Size = new Size(121, 42);
            label1.TabIndex = 0;
            label1.Text = "Notes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kristen ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(197, 129);
            label2.Name = "label2";
            label2.Size = new Size(110, 23);
            label2.TabIndex = 2;
            label2.Text = "Add a note";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Kristen ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(81, 260);
            label3.Name = "label3";
            label3.Size = new Size(54, 23);
            label3.TabIndex = 3;
            label3.Text = "Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 297);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(60, 350);
            button2.Name = "button2";
            button2.Size = new Size(75, 28);
            button2.TabIndex = 6;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 128);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 70);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.note;
            pictureBox1.Location = new Point(31, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 146);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(322, 112);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(466, 78);
            textBox1.TabIndex = 9;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(249, 220);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(539, 189);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = "";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Button button2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private RichTextBox richTextBox1;
    }
}