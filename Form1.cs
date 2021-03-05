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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Weekeneds holiday = null;
        Remind_Date Napomn = null;
        Courses_Valutes Select_Valutes = null;
        private void Courses_Click(object sender, EventArgs e)
        {
            if (Select_Valutes == null || Select_Valutes.IsDisposed)
                Select_Valutes = new Courses_Valutes(); // открывает новое окно
             
            if (!Select_Valutes.Visible)
                Select_Valutes.Show();
        }

        private void Remind_Click(object sender, EventArgs e)
        {
            if (Napomn == null || Napomn.IsDisposed)
                Napomn = new Remind_Date();
            
            if(!Napomn.Visible)
                Napomn.Show(); // 
        }

        
        private void Holiday_Click(object sender, EventArgs e)
        {
            
            if ( holiday == null || holiday.IsDisposed)
                 holiday = new Weekeneds();

            if (!holiday.Visible)
                holiday.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
