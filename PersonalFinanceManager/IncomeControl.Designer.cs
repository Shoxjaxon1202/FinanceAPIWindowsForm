namespace PersonalFinanceManager
{
    partial class IncomeControl
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
            dateTimePicker1 = new DateTimePicker();
            txtAmount = new TextBox();
            comSource = new ComboBox();
            txtDescription = new TextBox();
            btnEdit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            btnSave = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            dateTimePicker1.Location = new Point(100, 157);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(274, 39);
            dateTimePicker1.TabIndex = 0;
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            txtAmount.Location = new Point(100, 285);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(274, 39);
            txtAmount.TabIndex = 1;
            // 
            // comSource
            // 
            comSource.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            comSource.FormattingEnabled = true;
            comSource.Location = new Point(620, 148);
            comSource.Name = "comSource";
            comSource.Size = new Size(274, 39);
            comSource.TabIndex = 2;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            txtDescription.Location = new Point(620, 285);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(274, 39);
            txtDescription.TabIndex = 3;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Purple;
            btnEdit.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(421, 351);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(176, 67);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(100, 114);
            label1.Name = "label1";
            label1.Size = new Size(76, 31);
            label1.TabIndex = 5;
            label1.Text = "Date: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(100, 242);
            label2.Name = "label2";
            label2.Size = new Size(114, 31);
            label2.TabIndex = 6;
            label2.Text = "Amount: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(620, 114);
            label3.Name = "label3";
            label3.Size = new Size(99, 31);
            label3.TabIndex = 7;
            label3.Text = "Source: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(620, 242);
            label4.Name = "label4";
            label4.Size = new Size(150, 31);
            label4.TabIndex = 8;
            label4.Text = "Description: ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 447);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1005, 204);
            dataGridView1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(378, 36);
            label5.Name = "label5";
            label5.Size = new Size(239, 46);
            label5.TabIndex = 10;
            label5.Text = "Incomes Page";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Purple;
            btnSave.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(226, 351);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(176, 67);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Purple;
            btnDelete.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(620, 351);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(176, 67);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // IncomeControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEdit);
            Controls.Add(txtDescription);
            Controls.Add(comSource);
            Controls.Add(txtAmount);
            Controls.Add(dateTimePicker1);
            Name = "IncomeControl";
            Size = new Size(1005, 651);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private TextBox txtAmount;
        private ComboBox comSource;
        private TextBox txtDescription;
        private Button btnEdit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView1;
        private Label label5;
        private Button btnSave;
        private Button btnDelete;
    }
}
