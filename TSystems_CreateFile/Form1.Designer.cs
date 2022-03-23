namespace TSystems_CreateFile
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
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.btnCreateFolder = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.lblDeptid = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Location = new System.Drawing.Point(130, 12);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(75, 23);
            this.btnCreateFile.TabIndex = 0;
            this.btnCreateFile.Text = "Create File";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // btnCreateFolder
            // 
            this.btnCreateFolder.Location = new System.Drawing.Point(396, 12);
            this.btnCreateFolder.Name = "btnCreateFolder";
            this.btnCreateFolder.Size = new System.Drawing.Size(114, 23);
            this.btnCreateFolder.TabIndex = 1;
            this.btnCreateFolder.Text = "Create Folder";
            this.btnCreateFolder.UseVisualStyleBackColor = true;
            this.btnCreateFolder.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(130, 205);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 2;
            this.btnWrite.Text = "Binary Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(412, 205);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(98, 23);
            this.btnRead.TabIndex = 3;
            this.btnRead.Text = "Binary Read";
            this.btnRead.UseVisualStyleBackColor = true;
            // 
            // lblDeptid
            // 
            this.lblDeptid.AutoSize = true;
            this.lblDeptid.Location = new System.Drawing.Point(188, 75);
            this.lblDeptid.Name = "lblDeptid";
            this.lblDeptid.Size = new System.Drawing.Size(44, 13);
            this.lblDeptid.TabIndex = 4;
            this.lblDeptid.Text = "Dept ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(188, 110);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(188, 146);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(48, 13);
            this.lblLocation.TabIndex = 6;
            this.lblLocation.Text = "Location";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(386, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(386, 107);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(386, 146);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDeptid);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnCreateFolder);
            this.Controls.Add(this.btnCreateFile);
            this.Name = "Form1";
            this.Text = "File IO  Operation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.Button btnCreateFolder;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label lblDeptid;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

