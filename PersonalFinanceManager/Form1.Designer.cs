namespace PersonalFinanceManager
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel3 = new Panel();
            label2 = new Label();
            lblBalans = new Label();
            expenseControl1 = new ExpenseControl();
            incomeControl1 = new IncomeControl();
            reportsControl1 = new ReportsControl();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1235, 79);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(368, 20);
            label1.Name = "label1";
            label1.Size = new Size(562, 46);
            label1.TabIndex = 0;
            label1.Text = "Personal Finance Manager System";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 192);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 79);
            panel2.Name = "panel2";
            panel2.Size = new Size(236, 708);
            panel2.TabIndex = 1;
            // 
            // button3
            // 
            button3.BackColor = Color.Green;
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.ForeColor = Color.White;
            button3.Location = new Point(6, 144);
            button3.Name = "button3";
            button3.Size = new Size(222, 61);
            button3.TabIndex = 2;
            button3.Text = "Reports";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.ForeColor = Color.White;
            button2.Location = new Point(6, 77);
            button2.Name = "button2";
            button2.Size = new Size(222, 61);
            button2.TabIndex = 1;
            button2.Text = "Expences";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.White;
            button1.Location = new Point(6, 10);
            button1.Name = "button1";
            button1.Size = new Size(222, 61);
            button1.TabIndex = 0;
            button1.Text = "Incomes";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(lblBalans);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(236, 79);
            panel3.Name = "panel3";
            panel3.Size = new Size(999, 67);
            panel3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.FromArgb(192, 64, 0);
            label2.Location = new Point(245, 0);
            label2.Name = "label2";
            label2.Size = new Size(222, 62);
            label2.TabIndex = 1;
            label2.Text = "Balance: ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBalans
            // 
            lblBalans.AutoSize = true;
            lblBalans.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblBalans.ForeColor = Color.FromArgb(192, 64, 0);
            lblBalans.Location = new Point(473, 5);
            lblBalans.Name = "lblBalans";
            lblBalans.Size = new Size(54, 62);
            lblBalans.TabIndex = 0;
            lblBalans.Text = "0";
            lblBalans.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // expenseControl1
            // 
            expenseControl1.Dock = DockStyle.Fill;
            expenseControl1.Location = new Point(236, 146);
            expenseControl1.Name = "expenseControl1";
            expenseControl1.Size = new Size(999, 641);
            expenseControl1.TabIndex = 3;
            // 
            // incomeControl1
            // 
            incomeControl1.Dock = DockStyle.Fill;
            incomeControl1.Location = new Point(236, 146);
            incomeControl1.Name = "incomeControl1";
            incomeControl1.Size = new Size(999, 641);
            incomeControl1.TabIndex = 4;
            // 
            // reportsControl1
            // 
            reportsControl1.Dock = DockStyle.Fill;
            reportsControl1.Location = new Point(236, 146);
            reportsControl1.Name = "reportsControl1";
            reportsControl1.Size = new Size(999, 641);
            reportsControl1.TabIndex = 5;
            reportsControl1.Load += reportsControl1_Load;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1235, 787);
            Controls.Add(reportsControl1);
            Controls.Add(incomeControl1);
            Controls.Add(expenseControl1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Main Form";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Label lblBalans;
        private Label label2;
        private Button button3;
        private Button button2;
        private Button button1;
        private ExpenseControl expenseControl1;
        private IncomeControl incomeControl1;
        private ReportsControl reportsControl1;
    }
}
