using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;
using MetroFramework.Forms;




namespace PS4_Compiler_GUI_with_VS_EXC
{
    public partial class MainForm : MetroForm
    {
        public object SelectedValue { get; private set; }
        public int SelectedIndex { get; private set; }
        private string ImportFolderPath;
        private string OutputFolderPath;
        public MainForm()
        {
            InitializeComponent();


            MaximizeBox = true;
            MinimizeBox = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CreateDefaultProject_Click(object sender, EventArgs e)
        {
            var box = (comboBox1.SelectedItem, "Game for Project", new string[] { "Black Ops III", "Black Ops 4" });
            SelectedIndex = comboBox1.SelectedIndex;
            if (SelectedIndex >= 0 && SelectedIndex < comboBox1.Items.Count)
            {
                SelectedValue = comboBox1.Items[SelectedIndex];
            }
            else
            {
                SelectedValue = null;
            }

            var game = (box.SelectedItem.ToString() == "Black Ops 4") ? "T8" : "T7";
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = true;
            fbd.Description = "Select a folder to copy the default project to";
            if (fbd.ShowDialog() != DialogResult.OK) return;
            Program.CopyDefaultProject(fbd.SelectedPath, game);
            Process.Start(fbd.SelectedPath);
            MessageBox.Show("Success!", "Project installed successfully", MessageBoxButtons.OK);

        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Program.InstallUpdate();
          MessageBox.Show("Success!", "Compiler installed successfully", MessageBoxButtons.OK);
        }

        private void InstallVSCExt_Click(object sender, EventArgs e)
        {
            Program.UpdateVSCExtension();
MessageBox.Show("Success!", "Extension installed successfully", MessageBoxButtons.OK);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/@wtflightningstaff8038");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/@anthonything");
        }
    }
    }

    

