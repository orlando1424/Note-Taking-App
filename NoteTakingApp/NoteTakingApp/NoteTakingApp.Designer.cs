namespace NoteTakingApp
{
    partial class NoteTakingApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteTakingApp));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.newMetroButton = new MetroFramework.Controls.MetroButton();
            this.saveMetroButton = new MetroFramework.Controls.MetroButton();
            this.readMetroButton = new MetroFramework.Controls.MetroButton();
            this.deleteMetroButton = new MetroFramework.Controls.MetroButton();
            this.titleTextBox = new MetroFramework.Controls.MetroTextBox();
            this.messageTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(359, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(213, 213);
            this.dataGridView1.TabIndex = 4;
            // 
            // newMetroButton
            // 
            this.newMetroButton.Location = new System.Drawing.Point(12, 301);
            this.newMetroButton.Name = "newMetroButton";
            this.newMetroButton.Size = new System.Drawing.Size(101, 44);
            this.newMetroButton.TabIndex = 9;
            this.newMetroButton.Text = "New";
            this.newMetroButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.newMetroButton.Click += new System.EventHandler(this.newMetroButton_Click);
            // 
            // saveMetroButton
            // 
            this.saveMetroButton.Location = new System.Drawing.Point(119, 301);
            this.saveMetroButton.Name = "saveMetroButton";
            this.saveMetroButton.Size = new System.Drawing.Size(101, 44);
            this.saveMetroButton.TabIndex = 10;
            this.saveMetroButton.Text = "Save";
            this.saveMetroButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.saveMetroButton.Click += new System.EventHandler(this.saveMetroButton_Click);
            // 
            // readMetroButton
            // 
            this.readMetroButton.Location = new System.Drawing.Point(226, 301);
            this.readMetroButton.Name = "readMetroButton";
            this.readMetroButton.Size = new System.Drawing.Size(101, 44);
            this.readMetroButton.TabIndex = 11;
            this.readMetroButton.Text = "Read";
            this.readMetroButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.readMetroButton.Click += new System.EventHandler(this.readMetroButton_Click);
            // 
            // deleteMetroButton
            // 
            this.deleteMetroButton.Location = new System.Drawing.Point(333, 301);
            this.deleteMetroButton.Name = "deleteMetroButton";
            this.deleteMetroButton.Size = new System.Drawing.Size(101, 44);
            this.deleteMetroButton.TabIndex = 12;
            this.deleteMetroButton.Text = "Delete";
            this.deleteMetroButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.deleteMetroButton.Click += new System.EventHandler(this.deleteMetroButton_Click);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(60, 20);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(117, 23);
            this.titleTextBox.TabIndex = 13;
            this.titleTextBox.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(98, 59);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(246, 221);
            this.messageTextBox.TabIndex = 14;
            this.messageTextBox.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.metroLabel1.Location = new System.Drawing.Point(18, 24);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(36, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "Title:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(9, 59);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(60, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel2.TabIndex = 20;
            this.metroLabel2.Text = "Message";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseStyleColors = true;
            // 
            // NoteTakingApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(584, 403);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.deleteMetroButton);
            this.Controls.Add(this.readMetroButton);
            this.Controls.Add(this.saveMetroButton);
            this.Controls.Add(this.newMetroButton);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NoteTakingApp";
            this.Text = "Notes App";
            this.Load += new System.EventHandler(this.NoteTakingApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton newMetroButton;
        private MetroFramework.Controls.MetroButton saveMetroButton;
        private MetroFramework.Controls.MetroButton readMetroButton;
        private MetroFramework.Controls.MetroButton deleteMetroButton;
        private MetroFramework.Controls.MetroTextBox titleTextBox;
        private MetroFramework.Controls.MetroTextBox messageTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}

