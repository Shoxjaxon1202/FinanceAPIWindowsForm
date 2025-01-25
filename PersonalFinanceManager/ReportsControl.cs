using System;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf; // Windows Forms uchun kerak

namespace PersonalFinanceManager
{
    public partial class ReportsControl : UserControl
    {

        public ReportsControl()
        {
            InitializeComponent();

            // PieChart obyektini yaratish
          
            // PieChart-ni forma ichiga qo‘shish
        }

        private void ReportsControl_Load(object sender, EventArgs e)
        {
            //pieChart1.Series.Add(new LiveCharts.Wpf.PieSeries
            //{
            //    Title = "Transport",
            //    Values = new LiveCharts.ChartValues<double> { 500 }
            //});
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Qo‘shimcha logika bo‘lishi mumkin
        }
    }
}
