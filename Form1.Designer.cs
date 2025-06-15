namespace ToDoList
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            task = new TextBox();
            List3 = new ListBox();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            List2 = new ListBox();
            List1 = new ListBox();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            attentionDialog = new Label();
            ımageList1 = new ImageList(components);
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewCheckBoxColumn();
            taskTextEmpty = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Font = new Font("Lucida Handwriting", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(0, 0, 192);
            button1.Location = new Point(334, 121);
            button1.Name = "button1";
            button1.Size = new Size(115, 49);
            button1.TabIndex = 0;
            button1.Text = "Add Task";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // task
            // 
            task.BackColor = Color.OldLace;
            task.Font = new Font("Lucida Handwriting", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            task.ForeColor = Color.FromArgb(64, 0, 0);
            task.Location = new Point(39, 126);
            task.Multiline = true;
            task.Name = "task";
            task.Size = new Size(277, 40);
            task.TabIndex = 1;
            // 
            // List3
            // 
            List3.FormattingEnabled = true;
            List3.Location = new Point(51, 311);
            List3.Name = "List3";
            List3.Size = new Size(185, 104);
            List3.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Info;
            button2.Font = new Font("Lucida Handwriting", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(0, 0, 192);
            button2.Location = new Point(473, 121);
            button2.Name = "button2";
            button2.Size = new Size(115, 49);
            button2.TabIndex = 3;
            button2.Text = "Delete Task(s)";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sitka Small", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(39, 98);
            label2.Name = "label2";
            label2.Size = new Size(113, 25);
            label2.TabIndex = 5;
            label2.Text = "New Task:";
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(39, 170);
            label3.Name = "label3";
            label3.Size = new Size(186, 21);
            label3.TabIndex = 9;
            label3.Text = "Select a priority level";
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(169, 191);
            label4.Name = "label4";
            label4.Size = new Size(90, 17);
            label4.TabIndex = 10;
            label4.Text = "(3 max, 1 min)";
            // 
            // List2
            // 
            List2.FormattingEnabled = true;
            List2.Location = new Point(286, 311);
            List2.Name = "List2";
            List2.Size = new Size(185, 104);
            List2.TabIndex = 11;
            // 
            // List1
            // 
            List1.FormattingEnabled = true;
            List1.Location = new Point(517, 311);
            List1.Name = "List1";
            List1.Size = new Size(185, 104);
            List1.TabIndex = 12;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Small", 10.1999989F, FontStyle.Bold);
            label1.ForeColor = Color.SlateBlue;
            label1.Location = new Point(41, 273);
            label1.Name = "label1";
            label1.Size = new Size(218, 22);
            label1.TabIndex = 13;
            label1.Text = "Highest Priority Tasks";
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Sitka Small", 10.1999989F, FontStyle.Bold);
            label5.ForeColor = Color.SlateBlue;
            label5.Location = new Point(286, 273);
            label5.Name = "label5";
            label5.Size = new Size(196, 22);
            label5.TabIndex = 14;
            label5.Text = "Med. Priority Tasks";
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Sitka Small", 10.1999989F, FontStyle.Bold);
            label6.ForeColor = Color.SlateBlue;
            label6.Location = new Point(517, 273);
            label6.Name = "label6";
            label6.Size = new Size(188, 22);
            label6.TabIndex = 15;
            label6.Text = "Low Priority Tasks";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.ForeColor = Color.Black;
            radioButton1.Location = new Point(334, 172);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(38, 24);
            radioButton1.TabIndex = 16;
            radioButton1.TabStop = true;
            radioButton1.Tag = "List1";
            radioButton1.Text = "1";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Transparent;
            radioButton2.ForeColor = Color.Black;
            radioButton2.Location = new Point(290, 172);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(38, 24);
            radioButton2.TabIndex = 17;
            radioButton2.TabStop = true;
            radioButton2.Tag = "List2";
            radioButton2.Text = "2";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.BackColor = Color.Transparent;
            radioButton3.ForeColor = Color.Black;
            radioButton3.Location = new Point(246, 172);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(38, 24);
            radioButton3.TabIndex = 18;
            radioButton3.TabStop = true;
            radioButton3.Tag = "List3";
            radioButton3.Text = "3";
            radioButton3.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Sitka Small Semibold", 10.1999989F, FontStyle.Bold);
            label7.ForeColor = Color.SlateBlue;
            label7.Location = new Point(772, 131);
            label7.Name = "label7";
            label7.Size = new Size(139, 22);
            label7.TabIndex = 20;
            label7.Text = "Tasks Status";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.Red;
            dateTimePicker1.CalendarMonthBackground = Color.White;
            dateTimePicker1.CalendarTitleBackColor = Color.FromArgb(192, 0, 192);
            dateTimePicker1.CalendarTitleForeColor = SystemColors.HotTrack;
            dateTimePicker1.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(16, 36);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(268, 27);
            dateTimePicker1.TabIndex = 27;
            // 
            // attentionDialog
            // 
            attentionDialog.BackColor = Color.Transparent;
            attentionDialog.Font = new Font("Swis721 Hv BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            attentionDialog.ForeColor = Color.Red;
            attentionDialog.Location = new Point(378, 180);
            attentionDialog.Name = "attentionDialog";
            attentionDialog.Size = new Size(265, 20);
            attentionDialog.TabIndex = 28;
            attentionDialog.Text = "Please select a priority level!\r\n";
            attentionDialog.Visible = false;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "indir (1).jpeg");
            ımageList1.Images.SetKeyName(1, "indir.jpeg");
            ımageList1.Images.SetKeyName(2, "Pin by rie on homescreen _ Pink wallpaper ipad, Cute wallpapers for ipad, My melody wallpaper.jpeg");
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LightSteelBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView1.GridColor = Color.IndianRed;
            dataGridView1.Location = new Point(772, 170);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(301, 239);
            dataGridView1.TabIndex = 29;
            // 
            // Column1
            // 
            Column1.HeaderText = "Task Name";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 190;
            // 
            // Column2
            // 
            Column2.HeaderText = "Status";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Resizable = DataGridViewTriState.True;
            Column2.SortMode = DataGridViewColumnSortMode.Automatic;
            Column2.Width = 55;
            // 
            // taskTextEmpty
            // 
            taskTextEmpty.AutoSize = true;
            taskTextEmpty.BackColor = Color.Transparent;
            taskTextEmpty.Font = new Font("Swis721 Hv BT", 10.2F);
            taskTextEmpty.ForeColor = Color.Red;
            taskTextEmpty.Location = new Point(378, 200);
            taskTextEmpty.Name = "taskTextEmpty";
            taskTextEmpty.Size = new Size(244, 20);
            taskTextEmpty.TabIndex = 30;
            taskTextEmpty.Text = "Task text can not be empty!";
            taskTextEmpty.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1093, 553);
            Controls.Add(taskTextEmpty);
            Controls.Add(dataGridView1);
            Controls.Add(attentionDialog);
            Controls.Add(dateTimePicker1);
            Controls.Add(label7);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(List1);
            Controls.Add(List2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(List3);
            Controls.Add(task);
            Controls.Add(button1);
            DoubleBuffered = true;
            ForeColor = Color.DarkSlateBlue;
            Name = "Form1";
            Text = "To Do List App (◠‿◠✿)";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox task;
        private ListBox List3;
        private Button button2;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox List2;
        private ListBox List1;
        private Label label1;
        private Label label5;
        private Label label6;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private Label attentionDialog;
        private ImageList ımageList1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewCheckBoxColumn Column2;
        private Label taskTextEmpty;
    }
}
