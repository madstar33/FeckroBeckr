using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FeckroBeckrGame_SAS
{
    public partial class game : Form
    {
        //choising random color for textbox one to fore...
        Color ColorSelection(int x)
        {
            Color C = Color.White;
            switch (x)
            {
                case 1: C = Color.White; break;
                case 2: C = Color.Black; break;
                case 3: C = Color.Red; break;
                case 4: C = Color.Blue; break;
                case 5: C = Color.Yellow; break;
                case 6: C = Color.Orange; break;
            }
            return C;
        }
        //for changing the color of textboxes by mouse weel...
        Color MouseWeelColors(int count, int delta)
        {
          Color WeelColor = Color.White;
            if (delta > 0)
            {
                switch (count)
                {
                    case 1: WeelColor = Color.Yellow; break;
                    case 2: WeelColor = Color.White; break;
                    case 3: WeelColor = Color.Red; break;
                    case 4: WeelColor = Color.Blue; break;
                    case 5: WeelColor = Color.Orange; break;
                    case 6: WeelColor = Color.Black; break;
                }
            }
            if (delta < 0)
            {
                switch (count)
                {
                    case -1: WeelColor = Color.Red; break;
                    case -2: WeelColor = Color.White; break;
                    case -3: WeelColor = Color.Yellow; break;
                    case -4: WeelColor = Color.Black; break;
                    case -5: WeelColor = Color.Orange; break;
                    case -6: WeelColor = Color.Blue; break;
                }
            }        
        return WeelColor;
        }
 
        //sounds...
        SoundPlayer sound = new SoundPlayer(@"G:\SAS.Programming\game music.wav");
        private void game_Load(object sender, EventArgs e)
        {
            sound.PlayLooping();
        }
        public game()
        {
            InitializeComponent();
        }      
        FileInfo fileinformation = new FileInfo(@"G:\SAS.Programming\source\repos\FeckroBeckrGame_SAS\FeckroBeckrGame_scors.txt");
        private void button2_Click(object sender, EventArgs e)
        {
            //start timer...
            timer1.Enabled = true;
            //these textboxes will gone too...
            textBox_Hide.Visible = true;
            //using ClolorSelection method for textbox one to fore...
            Random random = new Random();
            textBox1.BackColor = ColorSelection(random.Next(1, 6));
            textBox2.BackColor = ColorSelection(random.Next(1, 6));
            textBox3.BackColor = ColorSelection(random.Next(1, 6));
            textBox4.BackColor = ColorSelection(random.Next(1, 6));
            //enabling the butten next...
            b_next.Enabled = true;
            //butten go will gone...
            b_go.Enabled = false; b_go.Visible = false;
            //generate mouse weel methods...
            {
                textBox5.MouseWheel += textBox5_MouseWeel;
                textBox6.MouseWheel += textBox6_MouseWeel;
                textBox7.MouseWheel += textBox7_MouseWeel;
                textBox8.MouseWheel += textBox8_MouseWeel;
                textBox9.MouseWheel += textBox9_MouseWeel;
                textBox10.MouseWheel += textBox10_MouseWeel;
                textBox11.MouseWheel += textBox11_MouseWeel;
                textBox12.MouseWheel += textBox12_MouseWeel;
                textBox13.MouseWheel += textBox13_MouseWeel;
                textBox14.MouseWheel += textBox14_MouseWeel;
                textBox15.MouseWheel += textBox15_MouseWeel;
                textBox16.MouseWheel += textBox16_MouseWeel;
                textBox17.MouseWheel += textBox17_MouseWeel;
                textBox18.MouseWheel += textBox18_MouseWeel;
                textBox19.MouseWheel += textBox19_MouseWeel;
                textBox20.MouseWheel += textBox20_MouseWeel;
                textBox21.MouseWheel += textBox21_MouseWeel;
                textBox22.MouseWheel += textBox22_MouseWeel;
                textBox23.MouseWheel += textBox23_MouseWeel;
                textBox24.MouseWheel += textBox24_MouseWeel;
            }
        }
        //for changing the color of textboxes by MouseWeelColors method...
        int count;
        private void textBox24_MouseWeel(object sender, MouseEventArgs e)
        {
            if (NextCounter == 4)
            {
                if (e.Delta > 0)
                {
                    count++;
                    if (count < 0 || count >= 7)
                        count = 0;
                    else if (count >= 1)
                        textBox24.BackColor = MouseWeelColors(count, e.Delta);
                }
                if (e.Delta < 0)
                {
                    count--;
                    if (count > 0 || count <= -7)
                        count = 0;
                    else if (count <= -1)
                        textBox24.BackColor = MouseWeelColors(count, e.Delta);
                }
            }
        }
        private void textBox23_MouseWeel(object sender, MouseEventArgs e)
        {
            if (NextCounter == 4)
            {
                if (e.Delta > 0)
                {
                    count++;
                    if (count < 0 || count >= 7)
                        count = 0;
                    else if (count >= 1)
                        textBox23.BackColor = MouseWeelColors(count, e.Delta);
                }
                if (e.Delta < 0)
                {
                    count--;
                    if (count > 0 || count <= -7)
                        count = 0;
                    else if (count <= -1)
                        textBox23.BackColor = MouseWeelColors(count, e.Delta);
                }
            }
        }
        private void textBox22_MouseWeel(object sender, MouseEventArgs e)
        {
            if (NextCounter == 4)
            {
                if (e.Delta > 0)
                {
                    count++;
                    if (count < 0 || count >= 7)
                        count = 0;
                    else if (count >= 1)
                        textBox22.BackColor = MouseWeelColors(count, e.Delta);
                }
                if (e.Delta < 0)
                {
                    count--;
                    if (count > 0 || count <= -7)
                        count = 0;
                    else if (count <= -1)
                        textBox22.BackColor = MouseWeelColors(count, e.Delta);
                }
            }
        }
        private void textBox21_MouseWeel(object sender, MouseEventArgs e)
        {
            if (NextCounter == 4)
            {
                if (e.Delta > 0)
                {
                    count++;
                    if (count < 0 || count >= 7)
                        count = 0;
                    else if (count >= 1)
                        textBox21.BackColor = MouseWeelColors(count, e.Delta);
                }
                if (e.Delta < 0)
                {
                    count--;
                    if (count > 0 || count <= -7)
                        count = 0;
                    else if (count <= -1)
                        textBox21.BackColor = MouseWeelColors(count, e.Delta);
                }
            }
        }
        private void textBox20_MouseWeel(object sender, MouseEventArgs e)
        {
            if (NextCounter == 3)
            {
                if (e.Delta > 0)
                {
                    count++;
                    if (count < 0 || count >= 7)
                        count = 0;
                    else if (count >= 1)
                        textBox20.BackColor = MouseWeelColors(count, e.Delta);
                }
                if (e.Delta < 0)
                {
                    count--;
                    if (count > 0 || count <= -7)
                        count = 0;
                    else if (count <= -1)
                        textBox20.BackColor = MouseWeelColors(count, e.Delta);
                }
            }
        }
        private void textBox19_MouseWeel(object sender, MouseEventArgs e)
        {
            if (NextCounter == 3)
            {
                if (e.Delta > 0)
                {
                    count++;
                    if (count < 0 || count >= 7)
                        count = 0;
                    else if (count >= 1)
                        textBox19.BackColor = MouseWeelColors(count, e.Delta);
                }
                if (e.Delta < 0)
                {
                    count--;
                    if (count > 0 || count <= -7)
                        count = 0;
                    else if (count <= -1)
                        textBox19.BackColor = MouseWeelColors(count, e.Delta);
                }
            }
        }
        private void textBox18_MouseWeel(object sender, MouseEventArgs e)
        {
            if (NextCounter == 3)
            {
                if (e.Delta > 0)
                {
                    count++;
                    if (count < 0 || count >= 7)
                        count = 0;
                    else if (count >= 1)
                        textBox18.BackColor = MouseWeelColors(count, e.Delta);
                }
                if (e.Delta < 0)
                {
                    count--;
                    if (count > 0 || count <= -7)
                        count = 0;
                    else if (count <= -1)
                        textBox18.BackColor = MouseWeelColors(count, e.Delta);
                }
            }
        }
        private void textBox17_MouseWeel(object sender, MouseEventArgs e)
        {
            if (NextCounter == 3)
            {
                if (e.Delta > 0)
                {
                    count++;
                    if (count < 0 || count >= 7)
                        count = 0;
                    else if (count >= 1)
                        textBox17.BackColor = MouseWeelColors(count, e.Delta);
                }
                if (e.Delta < 0)
                {
                    count--;
                    if (count > 0 || count <= -7)
                        count = 0;
                    else if (count <= -1)
                        textBox17.BackColor = MouseWeelColors(count, e.Delta);
                }
            }
        }
        private void textBox16_MouseWeel(object sender, MouseEventArgs e)
        {
            if (NextCounter == 2)
            {
                if (e.Delta > 0)
                {
                    count++;
                    if (count < 0 || count >= 7)
                        count = 0;
                    else if (count >= 1)
                        textBox16.BackColor = MouseWeelColors(count, e.Delta);
                }
                if (e.Delta < 0)
                {
                    count--;
                    if (count > 0 || count <= -7)
                        count = 0;
                    else if (count <= -1)
                        textBox16.BackColor = MouseWeelColors(count, e.Delta);
                }
            }
        }
        private void textBox15_MouseWeel(object sender, MouseEventArgs e)
        {
            if (NextCounter == 2)
            {
                if (e.Delta > 0)
                {
                    count++;
                    if (count < 0 || count >= 7)
                        count = 0;
                    else if (count >= 1)
                        textBox15.BackColor = MouseWeelColors(count, e.Delta);
                }
                if (e.Delta < 0)
                {
                    count--;
                    if (count > 0 || count <= -7)
                        count = 0;
                    else if (count <= -1)
                        textBox15.BackColor = MouseWeelColors(count, e.Delta);
                }
            }
        }
        private void textBox14_MouseWeel(object sender, MouseEventArgs e)
        {
            if (NextCounter == 2)
            {
                if (e.Delta > 0)
                {
                    count++;
                    if (count < 0 || count >= 7)
                        count = 0;
                    else if (count >= 1)
                        textBox14.BackColor = MouseWeelColors(count, e.Delta);
                }
                if (e.Delta < 0)
                {
                    count--;
                    if (count > 0 || count <= -7)
                        count = 0;
                    else if (count <= -1)
                        textBox14.BackColor = MouseWeelColors(count, e.Delta);
                }
            }
        }
        private void textBox13_MouseWeel(object sender, MouseEventArgs e)
        {
            if (NextCounter == 2)
            {
                if (e.Delta > 0)
                {
                    count++;
                    if (count < 0 || count >= 7)
                        count = 0;
                    else if (count >= 1)
                        textBox13.BackColor = MouseWeelColors(count, e.Delta);
                }
                if (e.Delta < 0)
                {
                    count--;
                    if (count > 0 || count <= -7)
                        count = 0;
                    else if (count <= -1)
                        textBox13.BackColor = MouseWeelColors(count, e.Delta);
                }
            }
        }
        private void textBox12_MouseWeel(object sender, MouseEventArgs e)
        {
            if (NextCounter == 1)
            {
                if (e.Delta > 0)
                {
                    count++;
                    if (count < 0 || count >= 7)
                        count = 0;
                    else if (count >= 1)
                        textBox12.BackColor = MouseWeelColors(count, e.Delta);
                }
                if (e.Delta < 0)
                {
                    count--;
                    if (count > 0 || count <= -7)
                        count = 0;
                    else if (count <= -1)
                        textBox12.BackColor = MouseWeelColors(count, e.Delta);
                }
            }
        }
        private void textBox11_MouseWeel(object sender, MouseEventArgs e)
        {
            if (NextCounter == 1)
            {
                if (e.Delta > 0)
                {
                    count++;
                    if (count < 0 || count >= 7)
                        count = 0;
                    else if (count >= 1)
                        textBox11.BackColor = MouseWeelColors(count, e.Delta);
                }
                if (e.Delta < 0)
                {
                    count--;
                    if (count > 0 || count <= -7)
                        count = 0;
                    else if (count <= -1)
                        textBox11.BackColor = MouseWeelColors(count, e.Delta);
                }
            }
        }
        private void textBox10_MouseWeel(object sender, MouseEventArgs e)
        {
            if (NextCounter == 1)
            {
                if (e.Delta > 0)
                {
                    count++;
                    if (count < 0 || count >= 7)
                        count = 0;
                    else if (count >= 1)
                        textBox10.BackColor = MouseWeelColors(count, e.Delta);
                }
                if (e.Delta < 0)
                {
                    count--;
                    if (count > 0 || count <= -7)
                        count = 0;
                    else if (count <= -1)
                        textBox10.BackColor = MouseWeelColors(count, e.Delta);
                }
            }
        }
        private void textBox9_MouseWeel(object sender, MouseEventArgs e)
        {
            if (NextCounter == 1)
            {
                if (e.Delta > 0)
                {
                    count++;
                    if (count < 0 || count >= 7)
                        count = 0;
                    else if (count >= 1)
                        textBox9.BackColor = MouseWeelColors(count, e.Delta);
                }
                if (e.Delta < 0)
                {
                    count--;
                    if (count > 0 || count <= -7)
                        count = 0;
                    else if (count <= -1)
                        textBox9.BackColor = MouseWeelColors(count, e.Delta);
                }
            }
        }
        private void textBox8_MouseWeel(object sender, MouseEventArgs e)
        {
            if (NextCounter == 0)
            {
                if (e.Delta > 0)
                {
                    count++;
                    if (count < 0 || count >= 7)
                        count = 0;
                    else if (count >= 1)
                        textBox8.BackColor = MouseWeelColors(count, e.Delta);
                }
                if (e.Delta < 0)
                {
                    count--;
                    if (count > 0 || count <= -7)
                        count = 0;
                    else if (count <= -1)
                        textBox8.BackColor = MouseWeelColors(count, e.Delta);
                }
            }
        }
        private void textBox7_MouseWeel(object sender, MouseEventArgs e)
        {
            if (NextCounter == 0)
            {
                if (e.Delta > 0)
                {
                    count++;
                    if (count < 0 || count >= 7)
                        count = 0;
                    else if (count >= 1)
                        textBox7.BackColor = MouseWeelColors(count, e.Delta);
                }
                if (e.Delta < 0)
                {
                    count--;
                    if (count > 0 || count <= -7)
                        count = 0;
                    else if (count <= -1)
                        textBox7.BackColor = MouseWeelColors(count, e.Delta);
                }
            }
        }
        private void textBox6_MouseWeel(object sender, MouseEventArgs e)
        {
            if (NextCounter == 0)
            {
                if (e.Delta > 0)
                {
                    count++;
                    if (count < 0 || count >= 7)
                        count = 0;
                    else if (count >= 1)
                        textBox6.BackColor = MouseWeelColors(count, e.Delta);
                }
                if (e.Delta < 0)
                {
                    count--;
                    if (count > 0 || count <= -7)
                        count = 0;
                    else if (count <= -1)
                        textBox6.BackColor = MouseWeelColors(count, e.Delta);
                }
            }
        }
        private void textBox5_MouseWeel(object sender, MouseEventArgs e)
        {
            if (NextCounter == 0)
            {
                if (e.Delta > 0)
                {
                    count++;
                    if (count < 0 || count >= 7)
                        count = 0;
                    else if (count >= 1)
                        textBox5.BackColor = MouseWeelColors(count, e.Delta);
                }
                if (e.Delta < 0)
                {
                    count--;                
                    if (count > 0 || count <= -7)
                        count = 0;
                    else if (count <= -1)
                        textBox5.BackColor = MouseWeelColors(count, e.Delta);
                }   
            }
        }
        //checking...
        int NextCounter = 0;
        int score = 0;
        private void b_next_Click(object sender, EventArgs e)
        {
            //when user'll win... 
            if (score == 20)
            {
                //saving the row which you won...
                FileStream filestream = fileinformation.Open(FileMode.Append, FileAccess.Write);
                StreamWriter streamwriter = new StreamWriter(filestream);
            
                switch (NextCounter)
                {
                    case 1:
                        {
                            streamwriter.WriteLine($"   score: {score} earnd in first row, amazing!!!");
                            break;
                        }
                    case 2:
                        {
                            streamwriter.WriteLine($"   score: {score} earnd in second row!");
                            break;
                        }
                    case 3:
                        {
                            streamwriter.WriteLine($"   score: {score} earnd in third row");
                            break;
                        }
                    case 4:
                        {
                            streamwriter.WriteLine($"   score: {score} earnd in fourth row");
                            break;
                        }
                    case 5:
                        {
                            streamwriter.WriteLine($"   score: {score} earnd in fifth row");
                            break;
                        }
                }
                streamwriter.Close();
                filestream.Close();

                MessageBox.Show("congratulations you're winner.", "you win", MessageBoxButtons.OK);
                NextCounter = 5;
                b_next.Enabled = false; b_next.Visible = false;
                b_close.Enabled = true; b_close.Visible = true;
                timer1.Enabled = false; textBox_Hide.Visible = false;
            }
            //making sure to all rows' textboxes are colored...
            switch (NextCounter)
            {
                //making sure to first row's textboxes are colored...
                case 0:
                    {
                        if (textBox5.BackColor == Color.Beige || textBox6.BackColor == Color.Beige || textBox7.BackColor == Color.Beige || textBox8.BackColor == Color.Beige)
                        {
                            MessageBox.Show("select a color by mouse weel for first row", "uncorrecte color", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            return;
                        }
                        break;
                    }
                //making sure to second row's textboxes are colored...
                case 1:
                    {
                        if (textBox9.BackColor == Color.Beige || textBox10.BackColor == Color.Beige || textBox11.BackColor == Color.Beige || textBox12.BackColor == Color.Beige)
                        {
                            MessageBox.Show("select a color by mouse weel for second row", "uncorrecte color", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            return;
                        }
                        break;
                    }
                //making sure to 3th row's textboxes are colored...
                case 2:
                    {
                        if (textBox13.BackColor == Color.Beige || textBox14.BackColor == Color.Beige || textBox15.BackColor == Color.Beige || textBox16.BackColor == Color.Beige)
                        {
                            MessageBox.Show("select a color by mouse weel for third row", "uncorrecte color", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            return;
                        }
                        break;
                    }
                //making sure to 4th row's textboxes are colored...
                case 3:
                    {
                        if (textBox17.BackColor == Color.Beige || textBox18.BackColor == Color.Beige || textBox19.BackColor == Color.Beige || textBox20.BackColor == Color.Beige)
                        {
                            MessageBox.Show("select a color by mouse weel for fourth row", "uncorrecte color", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            return;
                        }
                        break;
                    }
                //making sure to 4th row's textboxes are colored...
                case 4:
                    {
                        if (textBox21.BackColor == Color.Beige || textBox22.BackColor == Color.Beige || textBox23.BackColor == Color.Beige || textBox24.BackColor == Color.Beige)
                        {
                            MessageBox.Show("select a color by mouse weel for fifth row", "uncorrecte color", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            return;
                        }
                        break;
                    }
            }
            NextCounter++;
            //checking rows' color by checkboxes...   
            switch (NextCounter)
            {
                //checking first row...
                case 1:
                    {
                        if (textBox5.BackColor == textBox1.BackColor)
                        {
                            checkBox1.BackColor = Color.Black;
                            checkBox1.Checked = true;
                            score += 5;
                        }
                        else if (textBox5.BackColor == textBox2.BackColor || textBox5.BackColor == textBox3.BackColor || textBox5.BackColor == textBox4.BackColor)
                        {
                            checkBox1.BackColor = Color.White;
                            checkBox1.Checked = true;
                        }
                        if (textBox6.BackColor == textBox2.BackColor)
                        {
                            checkBox2.BackColor = Color.Black;
                            checkBox2.Checked = true;
                            score += 5;
                        }
                        else if (textBox6.BackColor == textBox1.BackColor || textBox6.BackColor == textBox3.BackColor || textBox6.BackColor == textBox4.BackColor)
                        {
                            checkBox2.BackColor = Color.White;
                            checkBox2.Checked = true;
                        }
                        if (textBox7.BackColor == textBox3.BackColor)
                        {
                            checkBox3.BackColor = Color.Black;
                            checkBox3.Checked = true;
                            score += 5;
                        }
                        else if (textBox7.BackColor == textBox1.BackColor || textBox7.BackColor == textBox2.BackColor || textBox7.BackColor == textBox4.BackColor)
                        {
                            checkBox3.BackColor = Color.White;
                            checkBox3.Checked = true;
                        }
                        if (textBox8.BackColor == textBox4.BackColor)
                        {
                            checkBox4.BackColor = Color.Black;
                            checkBox4.Checked = true;
                            score += 5;
                        }
                        else if (textBox8.BackColor == textBox1.BackColor || textBox8.BackColor == textBox2.BackColor || textBox8.BackColor == textBox3.BackColor)
                        {
                            checkBox4.BackColor = Color.White;
                            checkBox4.Checked = true;
                        }
                        label_score.Text = score.ToString();
                        break;
                    }

                //checking second row...
                case 2:
                    {
                        if (textBox9.BackColor == textBox1.BackColor)
                        {
                            checkBox5.BackColor = Color.Black;
                            checkBox5.Checked = true;
                            if (!(textBox5.BackColor == textBox1.BackColor))
                                score += 5;
                        }
                        else if (textBox9.BackColor == textBox2.BackColor || textBox9.BackColor == textBox3.BackColor || textBox9.BackColor == textBox4.BackColor)
                        {
                            checkBox5.BackColor = Color.White;
                            checkBox5.Checked = true;
                        }
                        if (textBox10.BackColor == textBox2.BackColor)
                        {
                            checkBox6.BackColor = Color.Black;
                            checkBox6.Checked = true;
                            if (!(textBox6.BackColor == textBox2.BackColor))
                                score += 5;
                        }
                        else if (textBox10.BackColor == textBox1.BackColor || textBox10.BackColor == textBox3.BackColor || textBox10.BackColor == textBox4.BackColor)
                        {
                            checkBox6.BackColor = Color.White;
                            checkBox6.Checked = true;
                        }
                        if (textBox11.BackColor == textBox3.BackColor)
                        {
                            checkBox7.BackColor = Color.Black;
                            checkBox7.Checked = true;
                            if (!(textBox7.BackColor == textBox3.BackColor))
                                score += 5;
                        }
                        else if (textBox11.BackColor == textBox1.BackColor || textBox11.BackColor == textBox2.BackColor || textBox11.BackColor == textBox4.BackColor)
                        {
                            checkBox7.BackColor = Color.White;
                            checkBox7.Checked = true;
                        }
                        if (textBox12.BackColor == textBox4.BackColor)
                        {
                            checkBox8.BackColor = Color.Black;
                            checkBox8.Checked = true;
                            if (!(textBox8.BackColor == textBox4.BackColor))
                                score += 5;
                        }
                        else if (textBox12.BackColor == textBox1.BackColor || textBox12.BackColor == textBox2.BackColor || textBox12.BackColor == textBox3.BackColor)
                        {
                            checkBox8.BackColor = Color.White;
                            checkBox8.Checked = true;
                        }
                        label_score.Text = score.ToString();
                        break;
                    }
                //checking 3th row...
                case 3:
                    {
                        if (textBox13.BackColor == textBox1.BackColor)
                        {
                            checkBox9.BackColor = Color.Black;
                            checkBox9.Checked = true;
                            if (!(textBox9.BackColor == textBox1.BackColor) && !(textBox5.BackColor == textBox1.BackColor))
                                score += 5;
                        }
                        else if (textBox13.BackColor == textBox2.BackColor || textBox13.BackColor == textBox3.BackColor || textBox13.BackColor == textBox4.BackColor)
                        {
                            checkBox9.BackColor = Color.White;
                            checkBox9.Checked = true;
                        }
                        if (textBox14.BackColor == textBox2.BackColor)
                        {
                            checkBox10.BackColor = Color.Black;
                            checkBox10.Checked = true;
                            if (!(textBox10.BackColor == textBox2.BackColor) && !(textBox6.BackColor == textBox2.BackColor))
                                score += 5;
                        }
                        else if (textBox14.BackColor == textBox1.BackColor || textBox14.BackColor == textBox3.BackColor || textBox14.BackColor == textBox4.BackColor)
                        {
                            checkBox10.BackColor = Color.White;
                            checkBox10.Checked = true;
                        }
                        if (textBox15.BackColor == textBox3.BackColor)
                        {
                            checkBox11.BackColor = Color.Black;
                            checkBox11.Checked = true;
                            if (!(textBox11.BackColor == textBox3.BackColor) && !(textBox7.BackColor == textBox3.BackColor))
                                score += 5;
                        }
                        else if (textBox15.BackColor == textBox1.BackColor || textBox15.BackColor == textBox2.BackColor || textBox15.BackColor == textBox4.BackColor)
                        {
                            checkBox11.BackColor = Color.White;
                            checkBox11.Checked = true;
                        }
                        if (textBox16.BackColor == textBox4.BackColor)
                        {
                            checkBox12.BackColor = Color.Black;
                            checkBox12.Checked = true;
                            if (!(textBox12.BackColor == textBox4.BackColor) && !(textBox8.BackColor == textBox4.BackColor))
                                score += 5;
                        }
                        else if (textBox16.BackColor == textBox1.BackColor || textBox16.BackColor == textBox2.BackColor || textBox16.BackColor == textBox3.BackColor)
                        {
                            checkBox12.BackColor = Color.White;
                            checkBox12.Checked = true;
                        }
                        label_score.Text = score.ToString();
                        break;
                    }
                //checking 4th row...
                case 4:
                    {
                        if (textBox17.BackColor == textBox1.BackColor)
                        {
                            checkBox13.BackColor = Color.Black;
                            checkBox13.Checked = true;
                            if (!(textBox13.BackColor == textBox1.BackColor) && !(textBox9.BackColor == textBox1.BackColor) && !(textBox5.BackColor == textBox1.BackColor))
                                score += 5;
                        }
                        else if (textBox17.BackColor == textBox2.BackColor || textBox17.BackColor == textBox3.BackColor || textBox17.BackColor == textBox4.BackColor)
                        {
                            checkBox13.BackColor = Color.White;
                            checkBox13.Checked = true;
                        }
                        if (textBox18.BackColor == textBox2.BackColor)
                        {
                            checkBox14.BackColor = Color.Black;
                            checkBox14.Checked = true;
                            if (!(textBox14.BackColor == textBox2.BackColor) && !(textBox10.BackColor == textBox2.BackColor) && !(textBox6.BackColor == textBox2.BackColor))
                                score += 5;
                        }
                        else if (textBox18.BackColor == textBox1.BackColor || textBox18.BackColor == textBox3.BackColor || textBox18.BackColor == textBox4.BackColor)
                        {
                            checkBox14.BackColor = Color.White;
                            checkBox14.Checked = true;
                        }
                        if (textBox19.BackColor == textBox3.BackColor)
                        {
                            checkBox15.BackColor = Color.Black;
                            checkBox15.Checked = true;
                            if (!(textBox15.BackColor == textBox3.BackColor) && !(textBox11.BackColor == textBox3.BackColor) && !(textBox7.BackColor == textBox3.BackColor))
                                score += 5;
                        }
                        else if (textBox19.BackColor == textBox1.BackColor || textBox19.BackColor == textBox2.BackColor || textBox19.BackColor == textBox4.BackColor)
                        {
                            checkBox15.BackColor = Color.White;
                            checkBox15.Checked = true;
                        }
                        if (textBox20.BackColor == textBox4.BackColor)
                        {
                            checkBox16.BackColor = Color.Black;
                            checkBox16.Checked = true;
                            if (!(textBox16.BackColor == textBox4.BackColor) && !(textBox12.BackColor == textBox4.BackColor) && !(textBox8.BackColor == textBox4.BackColor))
                                score += 5;
                        }
                        else if (textBox20.BackColor == textBox1.BackColor || textBox20.BackColor == textBox2.BackColor || textBox20.BackColor == textBox3.BackColor)
                        {
                            checkBox16.BackColor = Color.White;
                            checkBox16.Checked = true;
                        }
                        label_score.Text = score.ToString();
                        break;
                    }
                //checking 5th row...
                case 5:
                    {
                        if (textBox21.BackColor == textBox1.BackColor)
                        {
                            checkBox17.BackColor = Color.Black;
                            checkBox17.Checked = true;
                            if (!(textBox17.BackColor == textBox1.BackColor) && !(textBox13.BackColor == textBox1.BackColor) && !(textBox9.BackColor == textBox1.BackColor) && !(textBox5.BackColor == textBox1.BackColor))
                                score += 5;
                        }
                        else if (textBox21.BackColor == textBox2.BackColor || textBox21.BackColor == textBox3.BackColor || textBox21.BackColor == textBox4.BackColor)
                        {
                            checkBox17.BackColor = Color.White;
                            checkBox17.Checked = true;
                        }
                        if (textBox22.BackColor == textBox2.BackColor)
                        {
                            checkBox18.BackColor = Color.Black;
                            checkBox18.Checked = true;
                            if (!(textBox18.BackColor == textBox2.BackColor) && !(textBox14.BackColor == textBox2.BackColor) && !(textBox10.BackColor == textBox2.BackColor) && !(textBox6.BackColor == textBox2.BackColor))
                                score += 5;
                        }
                        else if (textBox22.BackColor == textBox1.BackColor || textBox22.BackColor == textBox3.BackColor || textBox22.BackColor == textBox4.BackColor)
                        {
                            checkBox18.BackColor = Color.White;
                            checkBox18.Checked = true;
                        }
                        if (textBox23.BackColor == textBox3.BackColor)
                        {
                            checkBox19.BackColor = Color.Black;
                            checkBox19.Checked = true;
                            if (!(textBox19.BackColor == textBox3.BackColor) && !(textBox15.BackColor == textBox3.BackColor) && !(textBox11.BackColor == textBox3.BackColor) && !(textBox7.BackColor == textBox3.BackColor))
                                score += 5;
                        }
                        else if (textBox23.BackColor == textBox1.BackColor || textBox23.BackColor == textBox2.BackColor || textBox23.BackColor == textBox4.BackColor)
                        {
                            checkBox19.BackColor = Color.White;
                            checkBox19.Checked = true;
                        }
                        if (textBox24.BackColor == textBox4.BackColor)
                        {
                            checkBox20.BackColor = Color.Black;
                            checkBox20.Checked = true;
                            if (!(textBox20.BackColor == textBox4.BackColor) && !(textBox16.BackColor == textBox4.BackColor) && !(textBox12.BackColor == textBox4.BackColor) && !(textBox8.BackColor == textBox4.BackColor))
                                score += 5;
                        }
                        else if (textBox24.BackColor == textBox1.BackColor || textBox24.BackColor == textBox2.BackColor || textBox24.BackColor == textBox3.BackColor)
                        {
                            checkBox20.BackColor = Color.White;
                            checkBox20.Checked = true;
                        }
                        label_score.Text = score.ToString();
                        break;
                    }

            }
            //for making a butten to close the game...
            if (NextCounter == 5)
            {
                b_next.Enabled = false; b_next.Visible = false;
                b_close.Enabled = true; b_close.Visible = true;
                textBox_Hide.Visible = false;
                timer1.Enabled = false;
            }
        }
        //for closing the game...
        private void b_close_Click(object sender, EventArgs e)
        {
            sound.Stop();
            this.Close();
        }
        //stop the timer...
        private void puseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sound.Stop();
            timer1.Stop();
            textBox_puse.Visible = true;
            b_next.Visible = false;
        }
        //continue the game...
        private void continueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sound.PlayLooping();
            textBox_puse.Visible = false;
            b_next.Visible = true;
            timer1.Start();
        }
        //playing the game of first...
        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure, your score won't save", "restarting", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) ==DialogResult.Yes)
            {
                sound.PlayLooping();
                second = 0; minute = 2;
                label_time.Text = "0" + minute.ToString() + " : 0" + second.ToString();
                NextCounter = 0; score = 0; count = 0;
                label_score.Text = 0.ToString();
                textBox_puse.Visible = false; textBox_Hide.Visible = false;
                b_go.Enabled = true; b_go.Visible = true;
                b_next.Enabled = false; b_next.Visible = true;
                b_close.Visible = false; b_close.Enabled = false;
                textBox1.BackColor = Color.White; textBox2.BackColor = Color.White; textBox3.BackColor = Color.White; textBox4.BackColor = Color.White;
                textBox5.BackColor = Color.Beige; textBox6.BackColor = Color.Beige; textBox7.BackColor = Color.Beige; textBox8.BackColor = Color.Beige;
                textBox9.BackColor = Color.Beige; textBox10.BackColor = Color.Beige; textBox11.BackColor = Color.Beige; textBox12.BackColor = Color.Beige;
                textBox13.BackColor = Color.Beige; textBox14.BackColor = Color.Beige; textBox15.BackColor = Color.Beige; textBox16.BackColor = Color.Beige;
                textBox17.BackColor = Color.Beige; textBox18.BackColor = Color.Beige; textBox19.BackColor = Color.Beige; textBox20.BackColor = Color.Beige;
                textBox21.BackColor = Color.Beige; textBox22.BackColor = Color.Beige; textBox23.BackColor = Color.Beige; textBox24.BackColor = Color.Beige;

                checkBox1.Checked = false; checkBox1.BackColor = Color.DarkGray;
                checkBox2.Checked = false; checkBox2.BackColor = Color.DarkGray;
                checkBox3.Checked = false; checkBox3.BackColor = Color.DarkGray;
                checkBox4.Checked = false; checkBox4.BackColor = Color.DarkGray;
                checkBox5.Checked = false; checkBox5.BackColor = Color.DarkGray;
                checkBox6.Checked = false; checkBox6.BackColor = Color.DarkGray;
                checkBox7.Checked = false; checkBox7.BackColor = Color.DarkGray;
                checkBox8.Checked = false; checkBox8.BackColor = Color.DarkGray;
                checkBox9.Checked = false; checkBox9.BackColor = Color.DarkGray;
                checkBox10.Checked = false; checkBox10.BackColor = Color.DarkGray;
                checkBox11.Checked = false; checkBox11.BackColor = Color.DarkGray;
                checkBox12.Checked = false; checkBox12.BackColor = Color.DarkGray;
                checkBox13.Checked = false; checkBox13.BackColor = Color.DarkGray;
                checkBox14.Checked = false; checkBox14.BackColor = Color.DarkGray;
                checkBox15.Checked = false; checkBox15.BackColor = Color.DarkGray;
                checkBox16.Checked = false; checkBox16.BackColor = Color.DarkGray;
                checkBox17.Checked = false; checkBox17.BackColor = Color.DarkGray;
                checkBox18.Checked = false; checkBox18.BackColor = Color.DarkGray;
                checkBox19.Checked = false; checkBox19.BackColor = Color.DarkGray;
                checkBox20.Checked = false; checkBox20.BackColor = Color.DarkGray;
            }
            else { sound.Play(); timer1.Start(); }
           
        }
        //going to menue...
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //saving score and row wich user earned...
            FileStream filestream = fileinformation.Open(FileMode.Append, FileAccess.Write);
            StreamWriter streamwriter = new StreamWriter(filestream);
            switch (NextCounter)
            {
                case 1:
                    {
                        streamwriter.WriteLine($"  score: {score} earnd in first row, amazing!!!");
                        break;
                    }
                case 2:
                    {
                        streamwriter.WriteLine($"  score: {score} earnd in second row!");
                        break;
                    }
                case 3:
                    {
                        streamwriter.WriteLine($"  score: {score} earnd in third row");
                        break;
                    }
                case 4:
                    {
                        streamwriter.WriteLine($"  score: {score} earnd in fourth row");
                        break;
                    }
                case 5:
                    {
                        streamwriter.WriteLine($"  score: {score} earnd in fifth row");
                        break;
                    }
            }
            streamwriter.Close();
            filestream.Close();
            this.Close();
        }
        //two minet to finish the game...
        int second = 0;
        int minute = 2;
        public void timer1_Tick(object sender, EventArgs e)
        {
            if (second == 0 && (minute == 1 || minute == 2))
            {
                second = 60;
                minute--;
            }
            label_time.Text = "0" + Convert.ToString(minute) + " : " + Convert.ToString(second--);
            if (minute == 0 && second == -1)
            {
                timer1.Enabled = false;
                FileStream filestream = fileinformation.Open(FileMode.Append, FileAccess.Write);
                StreamWriter streamwriter = new StreamWriter(filestream);
                switch (NextCounter)
                {
                    case 1:
                        {
                            streamwriter.WriteLine($"  score: {score} earnd in first row.");
                            break;
                        }
                    case 2:
                        {
                            streamwriter.WriteLine($"  score: {score} earnd in second row.");
                            break;
                        }
                    case 3:
                        {
                            streamwriter.WriteLine($"  score: {score} earnd in third row");
                            break;
                        }
                    case 4:
                        {
                            streamwriter.WriteLine($"  score: {score} earnd in fourth row");
                            break;
                        }
                    case 5:
                        {
                            streamwriter.WriteLine($"  score: {score} earnd in fifth row");
                            break;
                        }
                }
                streamwriter.Close();
                filestream.Close();              
                NextCounter = 5;
                MessageBox.Show("sorry but your time is up", "game over", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                sound.Stop();
                b_next.Enabled = false; b_next.Visible = false;
                b_close.Enabled = true; b_close.Visible = true;
                this.Close();
            }
        }

       

        //HOW CAN I DELETE IT ???
        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
