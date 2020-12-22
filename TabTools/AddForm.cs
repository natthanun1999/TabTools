using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabTools
{
    public partial class AddForm : Form
    {
        public string fileName { get; set; }
        public string filePath { get; set; }

        public AddForm()
        {
            InitializeComponent();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void name_Box_Enter(object sender, EventArgs e)
        {
            string titleName = name_Box.Text;

            if (titleName == "Name")
            {
                name_Box.Text = "";
            }
        }

        private void path_Box_Enter(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filePath = openFile.FileName;

                path_Box.Text = filePath;
            }
        }

        private void add_Btn_Click(object sender, EventArgs e)
        {
            fileName = name_Box.Text;

            this.DialogResult = DialogResult.OK;
            
            this.Close();
        }
    }
}
