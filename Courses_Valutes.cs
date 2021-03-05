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
            Cours_Remind_Weekened.ServiceReference1.DailyInfoSoapClient client = new Cours_Remind_Weekened.ServiceReference1.DailyInfoSoapClient();
            Data2.DataSource = client.DragMetDynamic(DateAt.Value, DateBefore.Value).Tables[0];
        } 
    }
}