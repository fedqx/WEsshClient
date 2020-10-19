namespace WEsshClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernamebox = new System.Windows.Forms.TextBox();
            this.ipbox = new System.Windows.Forms.TextBox();
            this.portbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.portcheckbox = new System.Windows.Forms.CheckBox();
            this.portforwardbox = new System.Windows.Forms.ListBox();
            this.portforwardaddbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.portforwardtextbox = new System.Windows.Forms.TextBox();
            this.connectbutton = new System.Windows.Forms.Button();
            this.profilenamebox = new System.Windows.Forms.TextBox();
            this.saveprofilebutton = new System.Windows.Forms.Button();
            this.profilebox = new System.Windows.Forms.ListBox();
            this.loadprofilebutton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.sshkeylabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hostname or IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // usernamebox
            // 
            this.usernamebox.Location = new System.Drawing.Point(192, 74);
            this.usernamebox.Name = "usernamebox";
            this.usernamebox.Size = new System.Drawing.Size(100, 22);
            this.usernamebox.TabIndex = 2;
            // 
            // ipbox
            // 
            this.ipbox.Location = new System.Drawing.Point(192, 29);
            this.ipbox.Name = "ipbox";
            this.ipbox.Size = new System.Drawing.Size(100, 22);
            this.ipbox.TabIndex = 1;
            // 
            // portbox
            // 
            this.portbox.Location = new System.Drawing.Point(192, 116);
            this.portbox.Name = "portbox";
            this.portbox.Size = new System.Drawing.Size(100, 22);
            this.portbox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Port";
            // 
            // portcheckbox
            // 
            this.portcheckbox.AutoSize = true;
            this.portcheckbox.Location = new System.Drawing.Point(66, 173);
            this.portcheckbox.Name = "portcheckbox";
            this.portcheckbox.Size = new System.Drawing.Size(138, 21);
            this.portcheckbox.TabIndex = 6;
            this.portcheckbox.Text = "Port Forwarding?";
            this.portcheckbox.UseVisualStyleBackColor = true;
            // 
            // portforwardbox
            // 
            this.portforwardbox.FormattingEnabled = true;
            this.portforwardbox.ItemHeight = 16;
            this.portforwardbox.Location = new System.Drawing.Point(67, 269);
            this.portforwardbox.Name = "portforwardbox";
            this.portforwardbox.Size = new System.Drawing.Size(120, 84);
            this.portforwardbox.TabIndex = 8;
            // 
            // portforwardaddbutton
            // 
            this.portforwardaddbutton.Location = new System.Drawing.Point(309, 223);
            this.portforwardaddbutton.Name = "portforwardaddbutton";
            this.portforwardaddbutton.Size = new System.Drawing.Size(75, 23);
            this.portforwardaddbutton.TabIndex = 9;
            this.portforwardaddbutton.Text = "Add\r\n";
            this.portforwardaddbutton.UseVisualStyleBackColor = true;
            this.portforwardaddbutton.Click += new System.EventHandler(this.portforwardaddbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Port Forward Rule:";
            // 
            // portforwardtextbox
            // 
            this.portforwardtextbox.Location = new System.Drawing.Point(192, 223);
            this.portforwardtextbox.Name = "portforwardtextbox";
            this.portforwardtextbox.Size = new System.Drawing.Size(100, 22);
            this.portforwardtextbox.TabIndex = 4;
            // 
            // connectbutton
            // 
            this.connectbutton.Location = new System.Drawing.Point(637, 34);
            this.connectbutton.Name = "connectbutton";
            this.connectbutton.Size = new System.Drawing.Size(117, 66);
            this.connectbutton.TabIndex = 12;
            this.connectbutton.Text = "Connect";
            this.connectbutton.UseVisualStyleBackColor = true;
            this.connectbutton.Click += new System.EventHandler(this.connectbutton_Click);
            // 
            // profilenamebox
            // 
            this.profilenamebox.Location = new System.Drawing.Point(531, 220);
            this.profilenamebox.Name = "profilenamebox";
            this.profilenamebox.Size = new System.Drawing.Size(100, 22);
            this.profilenamebox.TabIndex = 13;
            // 
            // saveprofilebutton
            // 
            this.saveprofilebutton.Location = new System.Drawing.Point(666, 221);
            this.saveprofilebutton.Name = "saveprofilebutton";
            this.saveprofilebutton.Size = new System.Drawing.Size(75, 23);
            this.saveprofilebutton.TabIndex = 14;
            this.saveprofilebutton.Text = "Save";
            this.saveprofilebutton.UseVisualStyleBackColor = true;
            this.saveprofilebutton.Click += new System.EventHandler(this.saveprofilebox_Click);
            // 
            // profilebox
            // 
            this.profilebox.FormattingEnabled = true;
            this.profilebox.ItemHeight = 16;
            this.profilebox.Location = new System.Drawing.Point(531, 246);
            this.profilebox.Name = "profilebox";
            this.profilebox.Size = new System.Drawing.Size(120, 84);
            this.profilebox.TabIndex = 15;
            // 
            // loadprofilebutton
            // 
            this.loadprofilebutton.Location = new System.Drawing.Point(666, 288);
            this.loadprofilebutton.Name = "loadprofilebutton";
            this.loadprofilebutton.Size = new System.Drawing.Size(75, 23);
            this.loadprofilebutton.TabIndex = 16;
            this.loadprofilebutton.Text = "Load";
            this.loadprofilebutton.UseVisualStyleBackColor = true;
            this.loadprofilebutton.Click += new System.EventHandler(this.loadprofilebutton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Selected SSH key:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Open File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sshkeylabel
            // 
            this.sshkeylabel.AutoSize = true;
            this.sshkeylabel.Location = new System.Drawing.Point(204, 384);
            this.sshkeylabel.Name = "sshkeylabel";
            this.sshkeylabel.Size = new System.Drawing.Size(0, 17);
            this.sshkeylabel.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sshkeylabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.loadprofilebutton);
            this.Controls.Add(this.profilebox);
            this.Controls.Add(this.saveprofilebutton);
            this.Controls.Add(this.profilenamebox);
            this.Controls.Add(this.connectbutton);
            this.Controls.Add(this.portforwardtextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.portforwardaddbutton);
            this.Controls.Add(this.portforwardbox);
            this.Controls.Add(this.portcheckbox);
            this.Controls.Add(this.portbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ipbox);
            this.Controls.Add(this.usernamebox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "WEssh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernamebox;
        private System.Windows.Forms.TextBox ipbox;
        private System.Windows.Forms.TextBox portbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox portcheckbox;
        private System.Windows.Forms.ListBox portforwardbox;
        private System.Windows.Forms.Button portforwardaddbutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox portforwardtextbox;
        private System.Windows.Forms.Button connectbutton;
        private System.Windows.Forms.TextBox profilenamebox;
        private System.Windows.Forms.Button saveprofilebutton;
        private System.Windows.Forms.ListBox profilebox;
        private System.Windows.Forms.Button loadprofilebutton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label sshkeylabel;
    }
}

