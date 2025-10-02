namespace personal_planning_system
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
            menuStrip2 = new MenuStrip();
            todoListToolStripMenuItem1 = new ToolStripMenuItem();
            budgetTrackerToolStripMenuItem1 = new ToolStripMenuItem();
            addBillToolStripMenuItem1 = new ToolStripMenuItem();
            viewBudgetToolStripMenuItem1 = new ToolStripMenuItem();
            notesToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip2
            // 
            menuStrip2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            menuStrip2.AutoSize = false;
            menuStrip2.BackColor = Color.PowderBlue;
            menuStrip2.Dock = DockStyle.None;
            menuStrip2.Items.AddRange(new ToolStripItem[] { todoListToolStripMenuItem1, budgetTrackerToolStripMenuItem1, notesToolStripMenuItem, exitToolStripMenuItem1 });
            menuStrip2.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            menuStrip2.Location = new Point(153, 96);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(476, 207);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // todoListToolStripMenuItem1
            // 
            todoListToolStripMenuItem1.BackColor = Color.RoyalBlue;
            todoListToolStripMenuItem1.Font = new Font("Kristen ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            todoListToolStripMenuItem1.ForeColor = Color.Black;
            todoListToolStripMenuItem1.Margin = new Padding(2);
            todoListToolStripMenuItem1.Name = "todoListToolStripMenuItem1";
            todoListToolStripMenuItem1.Size = new Size(465, 31);
            todoListToolStripMenuItem1.Text = "To-do List";
            todoListToolStripMenuItem1.Click += todoListToolStripMenuItem1_Click;
            // 
            // budgetTrackerToolStripMenuItem1
            // 
            budgetTrackerToolStripMenuItem1.BackColor = Color.CornflowerBlue;
            budgetTrackerToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { addBillToolStripMenuItem1, viewBudgetToolStripMenuItem1 });
            budgetTrackerToolStripMenuItem1.Font = new Font("Kristen ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            budgetTrackerToolStripMenuItem1.Margin = new Padding(2);
            budgetTrackerToolStripMenuItem1.Name = "budgetTrackerToolStripMenuItem1";
            budgetTrackerToolStripMenuItem1.Size = new Size(465, 31);
            budgetTrackerToolStripMenuItem1.Text = "Budget Tracker";
            // 
            // addBillToolStripMenuItem1
            // 
            addBillToolStripMenuItem1.BackColor = SystemColors.ActiveCaption;
            addBillToolStripMenuItem1.Margin = new Padding(2);
            addBillToolStripMenuItem1.Name = "addBillToolStripMenuItem1";
            addBillToolStripMenuItem1.Size = new Size(213, 32);
            addBillToolStripMenuItem1.Text = "Add Bill";
            addBillToolStripMenuItem1.Click += addBillToolStripMenuItem1_Click;
            // 
            // viewBudgetToolStripMenuItem1
            // 
            viewBudgetToolStripMenuItem1.BackColor = Color.LightSteelBlue;
            viewBudgetToolStripMenuItem1.Margin = new Padding(2);
            viewBudgetToolStripMenuItem1.Name = "viewBudgetToolStripMenuItem1";
            viewBudgetToolStripMenuItem1.Size = new Size(213, 32);
            viewBudgetToolStripMenuItem1.Text = "View Budget";
            viewBudgetToolStripMenuItem1.Click += viewBudgetToolStripMenuItem1_Click;
            // 
            // notesToolStripMenuItem
            // 
            notesToolStripMenuItem.BackColor = Color.SteelBlue;
            notesToolStripMenuItem.Font = new Font("Kristen ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            notesToolStripMenuItem.Margin = new Padding(2);
            notesToolStripMenuItem.Name = "notesToolStripMenuItem";
            notesToolStripMenuItem.Size = new Size(465, 31);
            notesToolStripMenuItem.Text = "Notes";
            notesToolStripMenuItem.Click += notesToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.BackColor = Color.LightSkyBlue;
            exitToolStripMenuItem1.Font = new Font("Kristen ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitToolStripMenuItem1.Margin = new Padding(2);
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(465, 31);
            exitToolStripMenuItem1.Text = "Exit";
            exitToolStripMenuItem1.Click += exitToolStripMenuItem1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources._2;
            pictureBox1.Location = new Point(34, 107);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(705, 375);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip2;
            Name = "Form1";
            Text = "Form 1";
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private MenuStrip menuStrip2;
        private ToolStripMenuItem todoListToolStripMenuItem1;
        private ToolStripMenuItem budgetTrackerToolStripMenuItem1;
        private ToolStripMenuItem addBillToolStripMenuItem1;
        private ToolStripMenuItem viewBudgetToolStripMenuItem1;
        private ToolStripMenuItem notesToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private PictureBox pictureBox1;
    }
}
