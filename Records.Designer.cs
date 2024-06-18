namespace FeckroBeckrGame_SAS
{
    partial class Records
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
            this.textBox_searchResults = new System.Windows.Forms.TextBox();
            this.textBox_searchName = new System.Windows.Forms.TextBox();
            this.b_Search = new System.Windows.Forms.Button();
            this.b_ShowRecords = new System.Windows.Forms.Button();
            this.textBox_searchEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_searchResults
            // 
            this.textBox_searchResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_searchResults.Location = new System.Drawing.Point(12, 176);
            this.textBox_searchResults.Multiline = true;
            this.textBox_searchResults.Name = "textBox_searchResults";
            this.textBox_searchResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_searchResults.Size = new System.Drawing.Size(617, 403);
            this.textBox_searchResults.TabIndex = 0;
            // 
            // textBox_searchName
            // 
            this.textBox_searchName.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox_searchName.Location = new System.Drawing.Point(12, 12);
            this.textBox_searchName.Name = "textBox_searchName";
            this.textBox_searchName.Size = new System.Drawing.Size(177, 22);
            this.textBox_searchName.TabIndex = 1;
            this.textBox_searchName.Text = "enter a name";
            this.textBox_searchName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_search_MouseClick);
            this.textBox_searchName.TextChanged += new System.EventHandler(this.textBox_searchName_TextChanged);
            // 
            // b_Search
            // 
            this.b_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Search.Location = new System.Drawing.Point(272, 31);
            this.b_Search.Name = "b_Search";
            this.b_Search.Size = new System.Drawing.Size(75, 23);
            this.b_Search.TabIndex = 2;
            this.b_Search.Text = "search";
            this.b_Search.UseVisualStyleBackColor = true;
            this.b_Search.Click += new System.EventHandler(this.b_Search_Click);
            // 
            // b_ShowRecords
            // 
            this.b_ShowRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_ShowRecords.Location = new System.Drawing.Point(233, 106);
            this.b_ShowRecords.Name = "b_ShowRecords";
            this.b_ShowRecords.Size = new System.Drawing.Size(158, 50);
            this.b_ShowRecords.TabIndex = 3;
            this.b_ShowRecords.Text = "show all records";
            this.b_ShowRecords.UseVisualStyleBackColor = true;
            this.b_ShowRecords.Click += new System.EventHandler(this.b_ShowRecords_Click);
            // 
            // textBox_searchEmail
            // 
            this.textBox_searchEmail.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox_searchEmail.Location = new System.Drawing.Point(12, 50);
            this.textBox_searchEmail.Name = "textBox_searchEmail";
            this.textBox_searchEmail.Size = new System.Drawing.Size(177, 22);
            this.textBox_searchEmail.TabIndex = 4;
            this.textBox_searchEmail.Text = "entar an email";
            this.textBox_searchEmail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_searchEmail_MouseClick);
            this.textBox_searchEmail.TextChanged += new System.EventHandler(this.textBox_searchEmail_TextChanged);
            // 
            // Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 591);
            this.Controls.Add(this.textBox_searchEmail);
            this.Controls.Add(this.b_ShowRecords);
            this.Controls.Add(this.b_Search);
            this.Controls.Add(this.textBox_searchName);
            this.Controls.Add(this.textBox_searchResults);
            this.Name = "Records";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Records";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_searchResults;
        private System.Windows.Forms.TextBox textBox_searchName;
        private System.Windows.Forms.Button b_Search;
        private System.Windows.Forms.Button b_ShowRecords;
        private System.Windows.Forms.TextBox textBox_searchEmail;
    }
}