using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;
//1)ShortCut
//2)PictureBox
namespace file_explorer
{
    public partial class Form1 : Form
    {
        string sourceFile;
        string destinationName;
        public Form1()
        {
            InitializeComponent();
        }

        private void driveListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dirListBox1.Path = driveListBox1.Drive;

        }

        private void dirListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fileListBox1.Path = dirListBox1.Path;
            fileListBox1.Refresh();
        }

        private void fileListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = fileListBox1.Path + "\\" + fileListBox1.FileName;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sourceFile = fileListBox1.Path + "\\"+fileListBox1.FileName;
            destinationName = fileListBox1.FileName;
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.Copy(sourceFile,dirListBox1.Path+"\\"+destinationName);
            fileListBox1.Refresh();
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string newFolder = Interaction.InputBox("Input folder name","Create folder","");
            Directory.CreateDirectory(dirListBox1.Path+"\\"+newFolder);
            dirListBox1.Refresh();
        }






    }
}
