namespace FeckroBeckrGame_SAS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.b_start = new System.Windows.Forms.Button();
            this.b_records = new System.Windows.Forms.Button();
            this.b_discription = new System.Windows.Forms.Button();
            this.b_playAgain = new System.Windows.Forms.Button();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // b_start
            // 
            this.b_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_start.Location = new System.Drawing.Point(140, 127);
            this.b_start.Name = "b_start";
            this.b_start.Size = new System.Drawing.Size(135, 60);
            this.b_start.TabIndex = 0;
            this.b_start.Text = "start";
            this.b_start.UseVisualStyleBackColor = true;
            this.b_start.Click += new System.EventHandler(this.b_start_Click);
            // 
            // b_records
            // 
            this.b_records.AutoSize = true;
            this.b_records.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_records.Location = new System.Drawing.Point(140, 211);
            this.b_records.Name = "b_records";
            this.b_records.Size = new System.Drawing.Size(135, 60);
            this.b_records.TabIndex = 1;
            this.b_records.Text = "records";
            this.b_records.UseVisualStyleBackColor = true;
            this.b_records.Click += new System.EventHandler(this.b_records_Click);
            // 
            // b_discription
            // 
            this.b_discription.AutoSize = true;
            this.b_discription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_discription.Location = new System.Drawing.Point(140, 301);
            this.b_discription.Name = "b_discription";
            this.b_discription.Size = new System.Drawing.Size(135, 60);
            this.b_discription.TabIndex = 2;
            this.b_discription.Text = "description";
            this.b_discription.UseVisualStyleBackColor = true;
            this.b_discription.Click += new System.EventHandler(this.b_discription_Click);
            // 
            // b_playAgain
            // 
            this.b_playAgain.AutoSize = true;
            this.b_playAgain.BackColor = System.Drawing.Color.Gold;
            this.b_playAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_playAgain.Location = new System.Drawing.Point(140, 393);
            this.b_playAgain.Name = "b_playAgain";
            this.b_playAgain.Size = new System.Drawing.Size(135, 60);
            this.b_playAgain.TabIndex = 3;
            this.b_playAgain.Text = "play again";
            this.b_playAgain.UseVisualStyleBackColor = false;
            this.b_playAgain.Click += new System.EventHandler(this.b_playAgain_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.ForeColor = System.Drawing.Color.Thistle;
            this.textBox_name.Location = new System.Drawing.Point(90, 54);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(238, 22);
            this.textBox_name.TabIndex = 4;
            this.textBox_name.Text = "enter a name";
            this.textBox_name.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_name_MouseClick);
            this.textBox_name.TextChanged += new System.EventHandler(this.textBox_name_TextChanged);
            // 
            // textBox_email
            // 
            this.textBox_email.ForeColor = System.Drawing.Color.Thistle;
            this.textBox_email.Location = new System.Drawing.Point(90, 82);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(238, 22);
            this.textBox_email.TabIndex = 5;
            this.textBox_email.Text = "enter your email";
            this.textBox_email.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_email_MouseClick);
            this.textBox_email.TextChanged += new System.EventHandler(this.textBox_email_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(442, 511);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.b_playAgain);
            this.Controls.Add(this.b_discription);
            this.Controls.Add(this.b_records);
            this.Controls.Add(this.b_start);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FeckroBeckr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_start;
        private System.Windows.Forms.Button b_records;
        private System.Windows.Forms.Button b_discription;
        private System.Windows.Forms.Button b_playAgain;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_email;
    }
}

