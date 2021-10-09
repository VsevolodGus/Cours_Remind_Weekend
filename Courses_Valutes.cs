using System;
using System.Windows.Forms;

namespace Cours_Remind_Weekened
{
    public partial class Courses_Valutes : Form
    {
        public Courses_Valutes()
        {
            InitializeComponent();
        }

        private async void Update_Click(object sender, EventArgs e)
        {
            var dateNow = new DateTimePicker
            {
                Value = DateTime.UtcNow
            };

            if (DateAt.Value < DateBefore.Value && DateAt.Value< dateNow.Value && DateBefore.Value <= dateNow.Value)
            {
                ServiceReference1.DailyInfoSoapClient client = new ServiceReference1.DailyInfoSoapClient();
                var data = await client.DragMetDynamicAsync(DateAt.Value, DateBefore.Value);
                Data2.DataSource = data.Tables[0];
            }
            else
            {
                MessageBox.Show("Мы не можем заглянуть в будущее, выберите коректные даты",
                    "Внимание",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                DateAt = dateNow;
                DateBefore = dateNow;
            }
        } 
    }
}