namespace SBSU_DEMO
{
    partial class AttendenceTrackModule
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Lessons = new System.Windows.Forms.ComboBox();
            this.label_lecturerName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Date = new System.Windows.Forms.ComboBox();
            this.button_Rate = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 86);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(850, 482);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(18, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Courses:";
            // 
            // comboBox_Lessons
            // 
            this.comboBox_Lessons.FormattingEnabled = true;
            this.comboBox_Lessons.Location = new System.Drawing.Point(98, 53);
            this.comboBox_Lessons.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Lessons.Name = "comboBox_Lessons";
            this.comboBox_Lessons.Size = new System.Drawing.Size(172, 24);
            this.comboBox_Lessons.TabIndex = 4;
            this.comboBox_Lessons.SelectedIndexChanged += new System.EventHandler(this.chooseCourses);
            // 
            // label_lecturerName
            // 
            this.label_lecturerName.AutoSize = true;
            this.label_lecturerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_lecturerName.Location = new System.Drawing.Point(13, 18);
            this.label_lecturerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_lecturerName.Name = "label_lecturerName";
            this.label_lecturerName.Size = new System.Drawing.Size(0, 17);
            this.label_lecturerName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(323, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Date:";
            // 
            // comboBox_Date
            // 
            this.comboBox_Date.FormattingEnabled = true;
            this.comboBox_Date.Location = new System.Drawing.Point(378, 53);
            this.comboBox_Date.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Date.Name = "comboBox_Date";
            this.comboBox_Date.Size = new System.Drawing.Size(195, 24);
            this.comboBox_Date.TabIndex = 9;
            this.comboBox_Date.SelectedIndexChanged += new System.EventHandler(this.comboBox_Date_SelectedIndexChanged);
            // 
            // button_Rate
            // 
            this.button_Rate.Location = new System.Drawing.Point(663, 55);
            this.button_Rate.Name = "button_Rate";
            this.button_Rate.Size = new System.Drawing.Size(206, 24);
            this.button_Rate.TabIndex = 10;
            this.button_Rate.Text = "Attendance Rate";
            this.button_Rate.UseVisualStyleBackColor = true;
            this.button_Rate.Click += new System.EventHandler(this.button_Rate_Click);
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(797, 12);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 23);
            this.button_back.TabIndex = 11;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // AttendenceTrackModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 582);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_Rate);
            this.Controls.Add(this.comboBox_Date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_lecturerName);
            this.Controls.Add(this.comboBox_Lessons);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AttendenceTrackModule";
            this.Text = "Attendence Track";
            this.Load += new System.EventHandler(this.AttendenceTrackModule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Lessons;
        private System.Windows.Forms.Label label_lecturerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Date;
        private System.Windows.Forms.Button button_Rate;
        private System.Windows.Forms.Button button_back;
    }
}