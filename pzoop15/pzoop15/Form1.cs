using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pzoop15
{
    public partial class Form1 : Form
    {
        private string selectedFolderPath;

        public Form1()
        {
            InitializeComponent();
        }



        private void LoadImages()
        {
            listBox1.Items.Clear();

            string[] imageFiles = Directory.GetFiles(selectedFolderPath, "*.jpg");

            foreach (string imageFile in imageFiles)
            {
                listBox1.Items.Add(Path.GetFileName(imageFile));
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string selectedImage = Path.Combine(selectedFolderPath, listBox1.SelectedItem.ToString());
                pictureBox1.Image = Image.FromFile(selectedImage);
            }
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string selectedImage = Path.Combine(selectedFolderPath, listBox1.SelectedItem.ToString());
                pictureBox1.Image = Image.FromFile(selectedImage);
            }
            else
            {
                MessageBox.Show("Виберіть картинку зі списку.");
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    selectedFolderPath = dialog.SelectedPath;
                    LoadImages();
                }
            }
        }
    }
}
