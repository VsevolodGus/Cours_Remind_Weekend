using System;
using System.Windows.Forms;

namespace Cours_Remind_Weekened
{
    public partial class Remind_Date : Form
    {
        public Remind_Date()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            LeftDays.Text = "";
            
            if (Convert.ToInt32((DateThen.Value - DateToday.Value).Days) > 0)
            {
                LeftDays.Text = Convert.ToString((DateThen.Value - DateToday.Value).Days) + " дней";
            }
            else if (Convert.ToInt32((DateThen.Value - DateToday.Value).Days) == 0)
            {
                LeftDays.Text = "Это произойдет в течение следующих суток!";
            }
            else
            {
                MessageBox.Show("Уже произошло\n Введите даты на актуальное событие",
                    "Внимание",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
        }
    }
}
