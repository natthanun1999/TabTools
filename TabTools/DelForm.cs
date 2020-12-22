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

namespace TabTools
{
    public partial class DelForm : Form
    {
        private Point current_pos = new Point(12, 57);
        private Point last_Pos = new Point(0, 0);

        private int amountItems = 0;

        private string[,] files;

        private Custom_Button.FlatBtn[] dynamicBtn;

        public List<int> items_list { get; set; }

        public DelForm()
        {
            InitializeComponent();
        }

        private void DelForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;

            items_list = new List<int>();

            Initialize();
        }

        private void Initialize()
        {
            //Load Location of Tools
            string file_name = "LocationTools.txt";
            StreamReader reader = new StreamReader(file_name);

            string line = "";

            int row = 0;
            int col = 0;

            int count = 0;

            while ((line = reader.ReadLine()) != null && count != (amountItems + 1))
            {
                if (count != 0)
                {
                    string[] part = line.Split(';');

                    files[row, col] = part[0];
                    files[row, col + 1] = count.ToString();

                    #region Dynamic_Button
                    //Color
                    dynamicBtn[row].BackColor = Color.FromArgb(50, 50, 50);
                    dynamicBtn[row].IdleColor = Color.FromArgb(50, 50, 50);
                    dynamicBtn[row].ActiveColor = Color.FromArgb(60, 60, 60);

                    //Text
                    dynamicBtn[row].TextButton = files[row, col];

                    //Size (Button)
                    dynamicBtn[row].Size = new Size(301, 42);

                    //Location (Button)
                    dynamicBtn[row].Location = current_pos;
                    last_Pos = current_pos;
                    current_pos.Y = last_Pos.Y + 42 + 14;

                    //Location (Form [Bottom])
                    this.Height = current_pos.Y + 14;

                    //Event (Button)
                    dynamicBtn[row].Click += new EventHandler(Button_Click);

                    //Add to Container
                    this.Controls.Add(dynamicBtn[row]);
                    #endregion

                    row++;
                }
                else
                {
                    //Get Items Amount
                    if (line != null)
                    {
                        amountItems = Int32.Parse(line);

                        //Allocate Array
                        files = new string[amountItems, 2];

                        dynamicBtn = new Custom_Button.FlatBtn[amountItems];

                        for (int n = 0; n < amountItems; n++)
                        {
                            dynamicBtn[n] = new Custom_Button.FlatBtn();
                        }
                    }
                }

                count++;
            }

            reader.Close();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirm_Btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void Button_Click(object sender, System.EventArgs e)
        {
            int row = Array.IndexOf(dynamicBtn, sender as Custom_Button.FlatBtn);

            int index = Int32.Parse(files[row, 1]);

            //Check If already selected
            if (items_list.Contains(index))
            {
                items_list.Remove(index);

                dynamicBtn[row].BackColor = Color.FromArgb(50, 50, 50);
                dynamicBtn[row].IdleColor = Color.FromArgb(50, 50, 50);
                dynamicBtn[row].ActiveColor = Color.FromArgb(60, 60, 60);
            }
            else
            {
                items_list.Add(index);

                dynamicBtn[row].BackColor = Color.Tomato;
                dynamicBtn[row].IdleColor = Color.Tomato;
                dynamicBtn[row].ActiveColor = Color.Salmon;
            }

            items_list.Sort();
        }
    }
}
