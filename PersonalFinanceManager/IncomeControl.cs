using PersonalFinanceManager.UI;
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

namespace PersonalFinanceManager
{
    public partial class IncomeControl : UserControl
    {
        private readonly ApiService _apiService;
        public IncomeControl()
        {
            InitializeComponent();
            _apiService = new ApiService("http://localhost:5255/api/");
        }

        private async void btnSave_Click_1(object sender, EventArgs e)
        {
            var income = new Income
            {
                Date = dateTimePicker1.Value,
                Amount = decimal.Parse(txtAmount.Text),
                Source = comSource.Text,
                Description = txtDescription.Text
            };

            try
            {
                await _apiService.PostAsync("income_table", income);
                MessageBox.Show("Daromad muvaffaqiyatli qo‘shildi!");
                //this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Xato: {ex.Message}");
            }
        }
    }
}
