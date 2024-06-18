using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;


namespace FeckroBeckrGame_SAS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //for switching to game form...
        private void b_start_Click(object sender, EventArgs e)
        {
            //checking boxes to be filled...
            if ((textBox_name.Text == "enter a name" || textBox_email.Text == "enter your email") || (textBox_name.Text == "" || textBox_email.Text == ""))
            {
                MessageBox.Show("please fill boxes to continue","fill boxes",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                return;
            }
            else
            {
                if (File.Exists(@"G:\SAS.Programming\source\repos\FeckroBeckrGame_SAS\FeckroBeckrGame_scors.txt"))
                {
                    if (!(textBox_email.Text.Contains("@gmail.com")))
                    {
                        textBox_email.Text = textBox_email.Text + "@gmail.com";
                    }

                    //Create object of FileInfo for specified path            
                    FileInfo fileinformation = new FileInfo(@"G:\SAS.Programming\source\repos\FeckroBeckrGame_SAS\FeckroBeckrGame_scors.txt");
                    FileStream filestream = fileinformation.Open(FileMode.Open, FileAccess.Read);
                    StreamReader streamreader = new StreamReader(filestream);
                    string search;
                    while ((search = streamreader.ReadLine()) != null)
                    {
                        if (search.Contains(textBox_email.Text))
                        {
                            streamreader.Close();
                            filestream.Close();
                            MessageBox.Show("The email address already entered!");
                            return;
                        }
                    }
                    streamreader.Close();
                    filestream.Close();

                    FileStream filestream2 = fileinformation.Open(FileMode.Append, FileAccess.Write);
                    StreamWriter streamwriter = new StreamWriter(filestream2);
                    streamwriter.Write("\t\n" + textBox_name.Text + "   ");
                    streamwriter.WriteLine(textBox_email.Text + " : ");
                    MessageBox.Show("good luck");
                    streamwriter.Close();
                    filestream2.Close();
                }
                else  //there isn't any file and we're going to add...
                {
                    if (!(textBox_email.Text.Contains("@gmail") && textBox_email.Text.Contains(".com")))
                    {
                        textBox_email.Text = textBox_email.Text + "@gmail.com";
                    }

                    //Open file for Read or Write
                    //Create object of FileInfo for specified path...           
                    FileInfo fileinformation = new FileInfo(@"G:\SAS.Programming\source\repos\FeckroBeckrGame_SAS\FeckroBeckrGame_scors.txt");
                    FileStream filestream = fileinformation.Open(FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read);
                    StreamWriter streamwriter = new StreamWriter(filestream);
                    streamwriter.Write(textBox_name.Text + "   ");
                    streamwriter.WriteLine(textBox_email.Text + " : ");
                    MessageBox.Show("good luck");
                    streamwriter.Close();
                    filestream.Close();
                }
                game form = new game();
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
           
        }



        private void b_records_Click(object sender, EventArgs e)
        {
            Records recordsForm = new Records();
            this.Hide();
            recordsForm.ShowDialog();
            this.Show();
        }

        private void b_discription_Click(object sender, EventArgs e)
        {
            //for discribe the game...
        }

       
        private void textBox_name_MouseClick (object sender, MouseEventArgs e)
        {
            textBox_name.Text = null;
        }

        private void textBox_email_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_email.Text = null;
        }


        //playing again...
        private void b_playAgain_Click(object sender, EventArgs e)
        {
            if ((textBox_name.Text == "enter a name" || textBox_email.Text == "enter your email") || (textBox_name.Text == "" || textBox_email.Text == ""))
            {
                MessageBox.Show("please fill boxes to continue", "fill boxes", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            else
            {
                if (File.Exists(@"G:\SAS.Programming\source\repos\FeckroBeckrGame_SAS\FeckroBeckrGame_scors.txt"))
                {
                    int count = 1;
                    if (!(textBox_email.Text.Contains("@gmail.com")))
                    {
                        textBox_email.Text = textBox_email.Text + "@gmail.com";
                    }
                    bool flag = false;
                    //Create object of FileInfo for specified path            
                    FileInfo fileinformation = new FileInfo(@"G:\SAS.Programming\source\repos\FeckroBeckrGame_SAS\FeckroBeckrGame_scors.txt");
                    FileStream filestream = fileinformation.Open(FileMode.Open, FileAccess.Read);
                    StreamReader streamreader = new StreamReader(filestream);
                   
                    string search;
                    while ((search = streamreader.ReadLine()) != null)
                    {
                        if (search.Contains(textBox_email.Text))
                        {
                            count++;
                            flag = true;
                            streamreader.Close();
                            filestream.Close();
                            break;
                        }                      
                    }

                    if(flag == false)
                    {
                        MessageBox.Show("the user not found", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        streamreader.Close();
                        filestream.Close();
                        return;
                    }

                    else if (flag == true)
                    {
                        FileStream filestream2 = fileinformation.Open(FileMode.Open, FileAccess.Write);
                        StreamWriter streamwriter = new StreamWriter(filestream2);
                        streamwriter.Write("\t\n" + textBox_name.Text + count + "   ");
                        streamwriter.WriteLine(textBox_email.Text + " : ");
                        streamwriter.Close();
                        filestream2.Close();                      
                        MessageBox.Show("good luck");
                    }
                }
                else
                {
                    MessageBox.Show("no records history, click on start !", "error",MessageBoxButtons.OK ,MessageBoxIcon.Error);
                    return;
                }
                game form = new game();
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
        }




        private void textBox_name_TextChanged(object sender, EventArgs e)
        {
            textBox_name.ForeColor = Color.Black;           
        }

        private void textBox_email_TextChanged(object sender, EventArgs e)
        {
            textBox_email.ForeColor = Color.Black;
        }
    }    
}
