using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using PersonalFinanceManager;
using PersonalFinanceManager.UI;

namespace PersonalFinanceManager
{
    public partial class ExpenseControl : UserControl
    {
        private readonly ApiService _apiService;
        public ExpenseControl()
        {
            InitializeComponent();
            _apiService = new ApiService("http://localhost:5000/api/");
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var expense = new Expense
            {
                Date = dateTimePicker1.Value,
                Amount = decimal.Parse(txtAmount.Text),
                Category = comSource.Text,
                Description = txtDescription.Text
            };

            try
            {
                await _apiService.PostAsync("expenses", expense);
                MessageBox.Show("Xarajat muvaffaqiyatli qo‘shildi!");
                //this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Xato: {ex.Message}");
            }
        }
    }
}
