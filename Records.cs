using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FeckroBeckrGame_SAS
{
    public partial class Records : Form
    {

        public Records()
        {
            InitializeComponent();
        }
        FileInfo fileinformation = new FileInfo(@"G:\SAS.Programming\source\repos\FeckroBeckrGame_SAS\FeckroBeckrGame_scors.txt");
        //searching user...
        private void b_Search_Click(object sender, EventArgs e)
        {  
            bool flag = false;

            if (File.Exists(@"G:\SAS.Programming\source\repos\FeckroBeckrGame_SAS\FeckroBeckrGame_scors.txt"))
            {
                string name = "enter a name", email = "enter an email";
                string search=null;

                //searching by name...
                if(textBox_searchName.Text != name && textBox_searchName.Text != "" && (textBox_searchEmail.Text == email || textBox_searchEmail.Text == ""))
                {
                    FileStream filestream = fileinformation.Open(FileMode.Open, FileAccess.Read);
                    StreamReader streamreader = new StreamReader(filestream);

                    while ((search = streamreader.ReadLine()) != null)
                    {
                        if (search.Contains(textBox_searchName.Text))
                        {
                            textBox_searchResults.Text = search + "\t\n";
                            flag = true;
                            break;
                        }
                    }
                    if (flag == false)
                    {
                        textBox_searchResults.Text = "user Not found!";
                    }

                    streamreader.Close();
                    filestream.Close();
                }

                //searching by email...
                else if (textBox_searchEmail.Text != email && textBox_searchEmail.Text != "" && (textBox_searchName.Text == name || textBox_searchName.Text == ""))
                {
                    if (!(textBox_searchEmail.Text.Contains("@gmail.com")) && textBox_searchEmail.Text != email)
                    {
                        textBox_searchEmail.Text = textBox_searchEmail.Text + "@gmail.com";
                    }

                    FileStream filestream = fileinformation.Open(FileMode.Open, FileAccess.Read);
                    StreamReader streamreader = new StreamReader(filestream);

                    while ((search = streamreader.ReadLine()) != null)
                    {
                        if (search.Contains(textBox_searchEmail.Text))
                        {
                            textBox_searchResults.Text = search + "\t\n";
                            flag = true;
                            break;
                        }
                    }
                    if (flag == false)
                    {
                        textBox_searchResults.Text = "user Not found!";
                    }

                    streamreader.Close();
                    filestream.Close();
                }

                else
                    MessageBox.Show("just fill one of the boxes", "boxes are empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else
                MessageBox.Show("file dosen't exist", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
                

        private void textBox_search_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_searchName.Text = null; 
        }

        private void textBox_searchEmail_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_searchEmail.Text = null;
        }

        private void b_ShowRecords_Click(object sender, EventArgs e)
        {
           
            if (File.Exists(@"G:\SAS.Programming\source\repos\FeckroBeckrGame_SAS\FeckroBeckrGame_scors.txt"))
            {
                FileStream filestream = fileinformation.Open(FileMode.Open, FileAccess.Read);
                StreamReader streamreader = new StreamReader(filestream);

                string search;
                try
                {
                    while ((search = streamreader.ReadLine()) != null)
                    {
                        textBox_searchResults.Text += "\t\n" + search;
                    }
                }
                catch
                {
                    if (MessageBox.Show("i couldn't read records!!", "error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                    {
                        return;
                    }
                }

                streamreader.Close();
                filestream.Close();
            }
            

            else MessageBox.Show("file dosen't exist", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBox_searchName_TextChanged(object sender, EventArgs e)
        {
            textBox_searchName.ForeColor = Color.Black;
        }

        private void textBox_searchEmail_TextChanged(object sender, EventArgs e)
        {
            textBox_searchEmail.ForeColor = Color.Black;
        }
    }
}
