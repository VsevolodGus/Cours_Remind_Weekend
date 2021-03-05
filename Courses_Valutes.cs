using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Cours_Remind_Weekened
{
    public partial class Courses_Valutes : Form
    {
        public Courses_Valutes()
        {
            InitializeComponent();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            DateTimePicker now = new DateTimePicker();
            now.Value = DateTime.UtcNow;
            if (DateAt.Value < DateBefore.Value && DateAt.Value< now.Value && DateBefore.Value <= now.Value)
            {
                Cours_Remind_Weekened.ServiceReference1.DailyInfoSoapClient client = new Cours_Remind_Weekened.ServiceReference1.DailyInfoSoapClient();
                Data2.DataSource = client.DragMetDynamic(DateAt.Value, DateBefore.Value).Tables[0];
            }
            else
            {
                MessageBox.Show("Мы не можем заглянуть в будущее, выберите коректные даты",
                    "Внимание",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                DateAt = now;
                DateBefore = now;
            }
        } 
    }
}