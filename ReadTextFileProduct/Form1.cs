using ReadTextFileProduct.Actions;
using ReadTextFileProduct.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadTextFileProduct
{
    public partial class Form1 : Form
    {
        List<ContentFileModel> list = new List<ContentFileModel>();
        string savePath = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            exportFile.Enabled = false;
            productName.Enabled = false;
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {

            ReadFileTextAction readFileTextAction = new ReadFileTextAction();

            try
            {
                var FD = new System.Windows.Forms.OpenFileDialog();
                if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string fileToOpen = FD.FileName;

                    if (fileToOpen != "")
                    {
                        list = readFileTextAction.ReadFileText(fileToOpen);

                        if(list.Count != 0)
                        {
                            string text = "";

                            foreach (ContentFileModel item in list)
                            {
                                text += $"{item.Name}, {item.NameProduct}, {item.Amount}, {item.Price} \n";
                            }

                        }
                        //MessageBox.Show("Chuyển đổi file thành công");
                        productName.Enabled = true;
                        exportFile.Enabled = true;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void exportFile_Click(object sender, EventArgs e)
        {
            ExportFileAction exportFileAction = new ExportFileAction();

            if (productName.Text == "" )
            {
                MessageBox.Show("Chưa đặt tên cho file");
                productName.Focus();
                return;
            }
            else
            {
                using (var fbd = new FolderBrowserDialog())
                {

                    DialogResult result = fbd.ShowDialog();
                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        savePath = fbd.SelectedPath;

                        if (savePath[savePath.Length - 1] != '\\')
                        {
                            savePath += '\\';
                        }

                        exportFileAction.ExportFile(list, productName.Text, savePath);
                    }
                }
            }

        }
    }
}
