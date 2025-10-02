namespace personal_planning_system
{
    partial class Form4
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
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Kristen ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 152);
            label1.Name = "label1";
            label1.Size = new Size(96, 23);
            label1.TabIndex = 0;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kristen ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 195);
            label2.Name = "label2";
            label2.Size = new Size(92, 23);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(131, 273);
            button1.Name = "button1";
            button1.Size = new Size(96, 37);
            button1.TabIndex = 2;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(68, 44);
            label3.Name = "label3";
            label3.Size = new Size(212, 40);
            label3.TabIndex = 3;
            label3.Text = "FocusFlow";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Brush Script MT", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(131, 93);
            label4.Name = "label4";
            label4.Size = new Size(57, 19);
            label4.TabIndex = 4;
            label4.Text = "Plan It";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.InactiveCaption;
            txtUsername.Location = new Point(160, 152);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(163, 23);
            txtUsername.TabIndex = 5;
            txtUsername.TextChanged += textBox1_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.InactiveCaption;
            txtPassword.Location = new Point(160, 195);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(163, 23);
            txtPassword.TabIndex = 6;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 234);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 19);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(355, 335);
            Controls.Add(checkBox1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private Label label4;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private CheckBox checkBox1;
    }
}