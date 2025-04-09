using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using JackieZ_Group3_Lab89Library;

namespace JackieZ_Group3_Lab89
{
    public partial class s : Form
    {
        private MyDay myDay;

        public s()
        {
            InitializeComponent();
            myDay = MyDay.NewDay();
        }

        private void TodaysTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Add Task button will list the added tasks

        }
        private void MarkTaskCompleteted_SelectedIndexChanged(object sender, EventArgs e)
        {
            //don't delete 

        }
        private void date_Click(object sender, EventArgs e)
        {
        Date: Text = $"Todays Date: {DateTime.Today.ToString("yyyy-MM-dd")}";
            MessageBox.Show("Todays date: ");
        }

        private void CompletedTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < CompletedTasks.Items.Count; i++)
            {
                if (CompletedTasks.GetItemChecked(i))
                {
                    CompletedTasks.Items[i] = $" {{chkListTasks.Items[i]}} (Completed)";
                }
            }
        }

        private void AddTasks_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(AddTasks.Text))
            {
                // Add the task to the list box
                TodaysTasks.Items.Add(AddTasks.Text);
            }
            else
            {
                MessageBox.Show("Enter Task: ");
            }
        }

        private void Evaluations_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }

        private void Courses_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }

        private void Export_Click(object sender, EventArgs e)
        {
            //data from both ListBoxes
            var exportData = new
            {
                Tasks = TodaysTasks.Items.Cast<string>().ToList(),
                Courses = Courses.Items.Cast<string>().ToList(),
                Evaluations = Evaluations.Items.Cast<string>().ToList()
            };

            // Create and configure SaveFileDialog properly
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "JSON Files (*.json)|*.json|All Files (*.*)|*.*",
                Title = "Export Data"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = saveFileDialog.FileName;
                    File.WriteAllText(filePath, JsonSerializer.Serialize(date));
                    MessageBox.Show($"Data exported to {filePath}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Export failed: {ex.Message}");
                }
            }
        }

        private void Import_Click(object sender, EventArgs e)
        {
            //find different way 
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "JSON Files (*.json)|*.json|All Files (*.*)|*.*",
                Title = "Import Data"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = openFileDialog.FileName;
                    var data = JsonSerializer.Deserialize<Dictionary<string, List<string>>>(File.ReadAllText(filePath));

                    if (data != null)
                    {
                        // Update all list boxes
                        if (data.ContainsKey("Tasks"))
                        {
                            UpdateListBox(TodaysTasks, data["Tasks"]);
                        }
                        else
                        {
                            UpdateListBox(TodaysTasks, new List<string>());
                        }

                        //
                        if (data.ContainsKey("Courses"))
                        {
                            UpdateListBox(Courses, data["Courses"]);
                        }
                        else
                        {
                            UpdateListBox(Courses, new List<string>());
                        }

                        //
                        if (data.ContainsKey("Evaluations"))
                        {
                            UpdateListBox(Evaluations, data["Evaluations"]);
                        }
                        else
                        {
                            UpdateListBox(Evaluations, new List<string>());
                        }



                        MessageBox.Show($"Data imported from {filePath}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Import failed: {ex.Message}");
                }
            }
        }
        // Add this helper method
        private void UpdateListBox(ListBox listBox, List<string> items)
        {
            listBox.Items.Clear();
            foreach (var item in items)
            {
                listBox.Items.Add(item);
            }
        }
    }
}
