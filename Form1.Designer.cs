
namespace Cours_Remind_Weekened
{
    
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Courses = new System.Windows.Forms.Button();
            this.Remind = new System.Windows.Forms.Button();
            this.Holiday = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Courses
            // 
            this.Courses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Courses.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Courses.BackgroundImage = global::Cours_Remind_Weekened.Properties.Resources.Fun_facts_about_money_01;
            this.Courses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Courses.Location = new System.Drawing.Point(296, 36);
            this.Courses.Name = "Courses";
            this.Courses.Size = new System.Drawing.Size(150, 100);
            this.Courses.TabIndex = 0;
            this.Courses.Text = "Узнать курс валют";
            this.Courses.UseVisualStyleBackColor = true;
            this.Courses.Click += new System.EventHandler(this.Courses_Click);
            // 
            // Remind
            // 
            this.Remind.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Remind.BackgroundImage = global::Cours_Remind_Weekened.Properties.Resources.alarm_clock_icon_on_blue_background_9640_2421;
            this.Remind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Remind.Location = new System.Drawing.Point(296, 142);
            this.Remind.Name = "Remind";
            this.Remind.Size = new System.Drawing.Size(150, 100);
            this.Remind.TabIndex = 1;
            this.Remind.Text = "Установить напоминание ";
            this.Remind.UseVisualStyleBackColor = true;
            this.Remind.Click += new System.EventHandler(this.Remind_Click);
            // 
            // Holiday
            // 
            this.Holiday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Holiday.BackgroundImage = global::Cours_Remind_Weekened.Properties.Resources.выходные;
            this.Holiday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Holiday.Location = new System.Drawing.Point(296, 248);
            this.Holiday.Name = "Holiday";
            this.Holiday.Size = new System.Drawing.Size(150, 100);
            this.Holiday.TabIndex = 2;
            this.Holiday.Text = "Узнать сколько осталось до выходных ";
            this.Holiday.UseVisualStyleBackColor = true;
            this.Holiday.Click += new System.EventHandler(this.Holiday_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Cours_Remind_Weekened.Properties.Resources.maxresdefault;
            this.ClientSize = new System.Drawing.Size(754, 411);
            this.Controls.Add(this.Holiday);
            this.Controls.Add(this.Remind);
            this.Controls.Add(this.Courses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Courses;
        private System.Windows.Forms.Button Remind;
        private System.Windows.Forms.Button Holiday;
    }
}

