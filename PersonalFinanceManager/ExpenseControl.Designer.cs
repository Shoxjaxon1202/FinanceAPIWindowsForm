namespace PersonalFinanceManager
{
    partial class ExpenseControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label5 = new Label();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtDescription = new TextBox();
            comSource = new ComboBox();
            txtAmount = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            btnDelete = new Button();
            button1 = new Button();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(378, 18);
            label5.Name = "label5";
            label5.Size = new Size(251, 46);
            label5.TabIndex = 21;
            label5.Text = "Expenses Page";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 429);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(965, 204);
            dataGridView1.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(620, 224);
            label4.Name = "label4";
            label4.Size = new Size(150, 31);
            label4.TabIndex = 19;
            label4.Text = "Description: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(620, 96);
            label3.Name = "label3";
            label3.Size = new Size(99, 31);
            label3.TabIndex = 18;
            label3.Text = "Source: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(100, 224);
            label2.Name = "label2";
            label2.Size = new Size(114, 31);
            label2.TabIndex = 17;
            label2.Text = "Amount: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(100, 96);
            label1.Name = "label1";
            label1.Size = new Size(76, 31);
            label1.TabIndex = 16;
            label1.Text = "Date: ";
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            txtDescription.Location = new Point(620, 267);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(274, 39);
            txtDescription.TabIndex = 14;
            // 
            // comSource
            // 
            comSource.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            comSource.FormattingEnabled = true;
            comSource.Location = new Point(620, 130);
            comSource.Name = "comSource";
            comSource.Size = new Size(274, 39);
            comSource.TabIndex = 13;
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            txtAmount.Location = new Point(100, 267);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(274, 39);
            txtAmount.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            dateTimePicker1.Location = new Point(100, 139);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(274, 39);
            dateTimePicker1.TabIndex = 11;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Purple;
            btnDelete.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(608, 337);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(176, 67);
            btnDelete.TabIndex = 24;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Purple;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.White;
            button1.Location = new Point(214, 337);
            button1.Name = "button1";
            button1.Size = new Size(176, 67);
            button1.TabIndex = 23;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Purple;
            btnEdit.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(409, 337);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(176, 67);
            btnEdit.TabIndex = 22;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // ExpenseControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDelete);
            Controls.Add(button1);
            Controls.Add(btnEdit);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDescription);
            Controls.Add(comSource);
            Controls.Add(txtAmount);
            Controls.Add(dateTimePicker1);
            Name = "ExpenseControl";
            Size = new Size(965, 633);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private DataGridView dataGridView1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtDescription;
        private ComboBox comSource;
        private TextBox txtAmount;
        private DateTimePicker dateTimePicker1;
        private Button btnDelete;
        private Button button1;
        private Button btnEdit;
    }
}
