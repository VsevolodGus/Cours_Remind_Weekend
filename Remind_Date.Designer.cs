
namespace Cours_Remind_Weekened
{
    partial class Remind_Date
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DateToday = new System.Windows.Forms.DateTimePicker();
            this.DateThen = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LeftDays = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DateToday
            // 
            this.DateToday.Location = new System.Drawing.Point(170, 42);
            this.DateToday.Name = "DateToday";
            this.DateToday.Size = new System.Drawing.Size(200, 20);
            this.DateToday.TabIndex = 0;
            // 
            // DateThen
            // 
            this.DateThen.Location = new System.Drawing.Point(170, 68);
            this.DateThen.Name = "DateThen";
            this.DateThen.Size = new System.Drawing.Size(200, 20);
            this.DateThen.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(49, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Сегодня";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(46, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Выбранный день ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(190, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(464, 68);
            this.label3.TabIndex = 6;
            this.label3.Text = "Осталось ждать :";
            // 
            // LeftDays
            // 
            this.LeftDays.BackColor = System.Drawing.Color.Transparent;
            this.LeftDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeftDays.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LeftDays.Location = new System.Drawing.Point(218, 203);
            this.LeftDays.Name = "LeftDays";
            this.LeftDays.Size = new System.Drawing.Size(371, 122);
            this.LeftDays.TabIndex = 7;
            this.LeftDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(534, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 76);
            this.button1.TabIndex = 8;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Remind_Date
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cours_Remind_Weekened.Properties.Resources._1523428286_2af46ba08368f2be0c98fd7755906c53;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LeftDays);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DateThen);
            this.Controls.Add(this.DateToday);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Remind_Date";
            this.Text = "Установить напоминание ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateToday;
        private System.Windows.Forms.DateTimePicker DateThen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LeftDays;
        private System.Windows.Forms.Button button1;
    }
}