using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        private List<string> ToDoList = new List<string>();
        private List<RadioButton> priorityBtn = new List<RadioButton>();
        private List<ListBox> Lists = new List<ListBox>();
        Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            LoadTasks();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Lists.Add(List1);
            Lists.Add(List2);
            Lists.Add(List3);
            List3.SelectionMode = SelectionMode.MultiExtended;
            List2.SelectionMode = SelectionMode.MultiExtended;
            List1.SelectionMode = SelectionMode.MultiExtended;
            priorityBtn.Add(radioButton1);
            priorityBtn.Add(radioButton2);
            priorityBtn.Add(radioButton3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool radioSelected = false;
            radioButton3.Tag = "List3";
            radioButton2.Tag = "List2";
            radioButton1.Tag = "List1";

             if (string.IsNullOrWhiteSpace(task.Text))  //textbox boþ ise
             {
                timer.Interval = 1000;     // 1.5 sn
                timer.Tick += Timer_Tick;   // Timer için belirlenen süre dolduðunda tetiklenir
                timer.Start();
                taskTextEmpty.Visible = true;
                return;
             }

            foreach (RadioButton radiobtn in priorityBtn)
            {
                if ((radiobtn.Checked) && (!string.IsNullOrWhiteSpace(task.Text)))  // ikisi de dolu
                {
                    radioSelected = true;
                    string targetList = radiobtn.Tag.ToString();

                    switch (targetList)
                    {
                        case "List3":
                            ToDoList.Add(task.Text);
                            List3.Items.Add(task.Text);
                            dataGridView1.Rows.Add(task.Text);
                            break;
                        case "List2":
                            ToDoList.Add(task.Text);
                            List2.Items.Add(task.Text);
                            dataGridView1.Rows.Add(task.Text);
                            break;
                        case "List1":
                            ToDoList.Add(task.Text);
                            List1.Items.Add(task.Text);
                            dataGridView1.Rows.Add(task.Text);
                            break;
                    }
                    task.Clear();
                    SaveTasks();
                    break;
                }
            }

            if ((!radioSelected)) // textbox var ve radiobtn seçili deðil ise)
            {
                timer.Interval = 1000;
                timer.Tick += Timer_Tick;
                timer.Start();
                attentionDialog.Visible = true;
            }

        }
        
        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            attentionDialog.Visible = false;
            taskTextEmpty.Visible = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DeleteSelectedItems(List1);
            DeleteSelectedItems(List2);
            DeleteSelectedItems(List3);
        }
        private void DeleteSelectedItems(ListBox list)
        {
            for (int i = list.SelectedIndices.Count - 1; i >= 0; i--)
            {
                int index = list.SelectedIndices[i];
                list.Items.RemoveAt(index);
                ToDoList.RemoveAt(index);
                dataGridView1.Rows.RemoveAt(index);
            }
        }
        private void SaveTasks()
        {
            File.WriteAllLines("ToDoList.txt", ToDoList);

        }

        private void LoadTasks()
        {
            if (File.Exists("ToDoList.txt"))
            {
                ToDoList = new List<string>(File.ReadAllLines("ToDoList.txt"));
                for (int i = 0; i < Lists.Count; i++)
                {
                    Lists[i].Items.AddRange(ToDoList.ToArray());
                }
            }
        }

    }
}
