namespace personal_planning_system
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
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            textname = new TextBox();
            textcost = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SteelBlue;
            label1.Font = new Font("Lucida Handwriting", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(262, 16);
            label1.Name = "label1";
            label1.Size = new Size(231, 36);
            label1.TabIndex = 0;
            label1.Text = "Add your bill";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 78);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kristen ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 122);
            label2.Name = "label2";
            label2.Size = new Size(129, 23);
            label2.TabIndex = 2;
            label2.Text = "Add the date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(180, 121);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Kristen ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 185);
            label3.Name = "label3";
            label3.Size = new Size(59, 23);
            label3.TabIndex = 4;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Kristen ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 236);
            label4.Name = "label4";
            label4.Size = new Size(52, 23);
            label4.TabIndex = 5;
            label4.Text = "Cost";
            // 
            // textname
            // 
            textname.Location = new Point(180, 177);
            textname.Name = "textname";
            textname.Size = new Size(200, 23);
            textname.TabIndex = 6;
            // 
            // textcost
            // 
            textcost.Location = new Point(180, 228);
            textcost.Name = "textcost";
            textcost.Size = new Size(200, 23);
            textcost.TabIndex = 7;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(90, 321);
            button1.Name = "button1";
            button1.Size = new Size(84, 30);
            button1.TabIndex = 8;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(305, 321);
            button2.Name = "button2";
            button2.Size = new Size(75, 30);
            button2.TabIndex = 9;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(180, 372);
            button3.Name = "button3";
            button3.Size = new Size(126, 31);
            button3.TabIndex = 10;
            button3.Text = "View Budget";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.computer_icons_invoice_image_clip_art_expense_png_favpng_TuQ95NrH17f6JUBBAgey0pZAT;
            pictureBox1.Location = new Point(466, 112);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(285, 255);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textcost);
            Controls.Add(textname);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Add Bill";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label4;
        private TextBox textname;
        private TextBox textcost;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
    }
}