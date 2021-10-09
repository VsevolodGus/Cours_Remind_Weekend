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
    public partial class Weekeneds : Form
    {
        public Weekeneds()
        {
            InitializeComponent();
        }

        
        private int Left_Days()
        {
            return 7 - Convert.ToInt32(DateTime.Now.DayOfWeek);
        }
        private void Weekeneds_Load(object sender, EventArgs e)
        {
            Days.Text = "";

            
            if (DateTime.Now.DayOfWeek.ToString() == "Thursday")
            {
                Days.Text = "После завтра";
            }
            else if (DateTime.Now.DayOfWeek.ToString() == "Friday")
            {
                Days.Text = "Завтра";
            }
            else if (DateTime.Now.DayOfWeek.ToString() == "Saturday" || DateTime.Now.DayOfWeek.ToString() == "Sunday")
            {
                Days.Text = "Уже начались!";
            }
            else
            {
                Days.Text = Convert.ToString(Left_Days());
            }

            if (DateTime.Now.DayOfWeek.ToString() != "Thursday" && DateTime.Now.DayOfWeek.ToString() != "Friday" &&
                DateTime.Now.DayOfWeek.ToString() != "Saturday" && DateTime.Now.DayOfWeek.ToString() != "Sunday")
                Days.Text += " дней";
        }
    }
}
