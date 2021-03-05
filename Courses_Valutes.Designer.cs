
namespace Cours_Remind_Weekened
{
    partial class Courses_Valutes
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.DateAt = new System.Windows.Forms.DateTimePicker();
            this.DateBefore = new System.Windows.Forms.DateTimePicker();
            this.Update = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Data2 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Data2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(54, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "ОТ";
            // 
            // DateAt
            // 
            this.DateAt.Location = new System.Drawing.Point(160, 28);
            this.DateAt.Name = "DateAt";
            this.DateAt.Size = new System.Drawing.Size(200, 20);
            this.DateAt.TabIndex = 3;
            // 
            // DateBefore
            // 
            this.DateBefore.Location = new System.Drawing.Point(160, 60);
            this.DateBefore.Name = "DateBefore";
            this.DateBefore.Size = new System.Drawing.Size(200, 20);
            this.DateBefore.TabIndex = 4;
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.SystemColors.Highlight;
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Update.Location = new System.Drawing.Point(521, 23);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(141, 78);
            this.Update.TabIndex = 5;
            this.Update.Text = "Обновить ";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(54, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "ДО";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(69, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(329, 34);
            this.label6.TabIndex = 8;
            this.label6.Text = "Курс драгоценных металлов";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Data2
            // 
            this.Data2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data2.Location = new System.Drawing.Point(9, 141);
            this.Data2.Name = "Data2";
            this.Data2.Size = new System.Drawing.Size(453, 309);
            this.Data2.TabIndex = 10;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(515, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 124);
            this.label1.TabIndex = 14;
            this.label1.Text = "1- Золото,\r\n2- Серебро\r\n3 -Платина\r\n4 — Палладий";
            // 
            // Courses_Valutes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Cours_Remind_Weekened.Properties.Resources.Без_имени;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(826, 462);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Data2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.DateBefore);
            this.Controls.Add(this.DateAt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Courses_Valutes";
            this.Text = "Узнать курс валют";
            ((System.ComponentModel.ISupportInitialize)(this.Data2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DateAt;
        private System.Windows.Forms.DateTimePicker DateBefore;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView Data2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
    }
}